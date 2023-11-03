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

                    return $"CERT-{currentYear}-{nextNumber:D2}";
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
                        cert.rsbsaIdLGU = reader["Reference Number"].ToString();
                        cert.name = reader["Name"].ToString();
                        cert.barangay = reader["Barangay"].ToString();
                        cert.farmParcelCount = Convert.ToInt32(reader["farmParcelCount"].ToString());
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

        public Certifications GetEmployeeInfoByUsername(string username)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCertEmployeeInfo(@username)", db.GetConnection());
                    command.Parameters.AddWithValue("@username", username);

                    MySqlDataReader reader = command.ExecuteReader();

                    Certifications cert = null;

                    if (reader.Read())
                    {
                        cert = new Certifications();
                        cert.username = reader["username"].ToString();
                        cert.employeeName = reader["Employee"].ToString();
                        cert.employeePosition = reader["Position"].ToString();
                        cert.headName = reader["Head"].ToString();
                    }

                    reader.Close();
                    return cert;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting employee info by ID: " + ex.Message, ex);
            }
        }

        public List<Certifications> GetCertCommodities(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmInfoForCert(@ID)", db.GetConnection());
                    command.Parameters.AddWithValue("@ID", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    List<Certifications> commoditiesList = new List<Certifications>();

                    while (reader.Read())
                    {
                        Certifications cert = new Certifications
                        {
                            rsbsaId = reader["rsbsaId"].ToString(),
                            rsbsaIdLGU = reader["rsbsaIdLGU"].ToString(),
                            farmParcelNo = reader["farmParcelNo"].ToString(),
                            farmLocBrgy = reader["farmAddress"].ToString(),
                            commodityInfo = reader["commodityInfo"].ToString(),
                        };

                        commoditiesList.Add(cert);
                    }

                    reader.Close();
                    return commoditiesList;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farm parcel commodities by ID: " + ex.Message, ex);
            }
        }

        public Boolean AddCertificate(Certifications cert)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addCertifications(@orNo, @referenceNumber, @name, @farmInfo, @date, @employeeName, @headName)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@referenceNumber", cert.rsbsaIdLGU);
                    command.Parameters.AddWithValue("@orNo", cert.orderNumber);
                    command.Parameters.AddWithValue("@name", cert.name);
                    command.Parameters.AddWithValue("@farmInfo", cert.farmInfo);
                    command.Parameters.AddWithValue("@date", cert.date);
                    command.Parameters.AddWithValue("@employeeName", cert.employeeName);
                    command.Parameters.AddWithValue("@headName", cert.headName);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new rice standing report: " + ex.Message, ex);
            }
        }
    }
}
