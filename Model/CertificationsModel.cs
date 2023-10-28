using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class CertificationsModel
    {
        private DatabaseConnection db;

        public CertificationsModel()
        {
            db = new DatabaseConnection();
        }

        public string GenerateNextCertId()
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectCertId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    int nextNumber = 1; // Default to 1 if no records are found

                    if (result != null && result != DBNull.Value)
                    {
                        string lastId = result.ToString();
                        string[] parts = lastId.Split('-');

                        if (parts.Length == 3 && parts[0] == "CERT" && parts[1] == currentYear.ToString())
                        {
                            if (int.TryParse(parts[2], out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    return $"CORN-{currentYear}-{nextNumber:D2}";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }

        public DataTable GetFarmerInfo()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "SELECT * FROM vw_get_farmer_info;";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading list of farmers: " + ex.Message, ex);
            }
        }

        public Certifications GetFarmerInfoById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCertInfo(@ID)", db.GetConnection());
                    command.Parameters.AddWithValue("@ID", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    Certifications cert = null;

                    if (reader.Read())
                    {
                        cert = new Certifications();
                        cert.rsbsaId = reader["ID"].ToString();
                        cert.refNumber = reader["Reference Number"].ToString();
                        cert.name = reader["Name"].ToString();
                        cert.barangay = reader["Barangay"].ToString();
                    }

                    reader.Close();
                    return cert;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farmer info by ID: " + ex.Message, ex);
            }
        }
    }
}
