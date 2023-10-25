using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class HvcModel
    {
        private DatabaseConnection db;

        public HvcModel()
        {
            db = new DatabaseConnection();
        }

        public string GenerateNextHvcId()
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxHvcId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    int nextNumber = 1; // Default to 1 if no records are found

                    if (result != null && result != DBNull.Value)
                    {
                        string lastId = result.ToString();
                        string[] parts = lastId.Split('-');

                        if (parts.Length == 3 && parts[0] == "HVC" && parts[1] == currentYear.ToString())
                        {
                            if (int.TryParse(parts[2], out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    return $"HVC-{currentYear}-{nextNumber:D2}";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }

        // STANDING
        public Boolean AddHvcStandingRep(HvcReport hr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addHvcStandingReport(@hvcSrId, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@hvcSrId", hr.hvcSrId);
                    command.Parameters.AddWithValue("@month", hr.month);
                    command.Parameters.AddWithValue("@week", hr.week);
                    command.Parameters.AddWithValue("@year", hr.year);
                    command.Parameters.AddWithValue("@createdBy", hr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding HVC report: " + ex.Message, ex);
            }
        }

        public HvcReport GetHvcStandingReportById(string hvcSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getHvcStandingReportById(@hvcSrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@hvcSrId", hvcSrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    HvcReport hsr = null;

                    if (reader.Read())
                    {
                        hsr = new HvcReport();
                        hsr.hvcSrId = reader["hvcSrId"].ToString();
                        hsr.month = reader["month"].ToString();
                        hsr.week = reader["week"].ToString();
                        hsr.year = reader["year"].ToString();
                        hsr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return hsr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting HVC standing record by ID: " + ex.Message, ex);
            }
        }

        public Boolean AddHvcStanding(HvcStanding hs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addHvcStanding(@hvcSrId, @cropStageId, @cropTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@hvcSrId", hs.hvcSrId);
                    command.Parameters.AddWithValue("@cropStageId", hs.cropStageId);
                    command.Parameters.AddWithValue("@cropTypeId", hs.cropTypeId);
                    command.Parameters.AddWithValue("@size", hs.size);
                    command.Parameters.AddWithValue("@logDate", hs.logDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new HVC standing record: " + ex.Message, ex);
            }
        }

        public Boolean UpdateHvcStanding(HvcStanding hs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateHvcStanding(@hvcStandingId, @cropStageId, @cropTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@hvcStandingId", hs.hvcStandingId);
                    command.Parameters.AddWithValue("@cropStageId", hs.cropStageId);
                    command.Parameters.AddWithValue("@cropTypeId", hs.cropTypeId);
                    command.Parameters.AddWithValue("@size", hs.size);
                    command.Parameters.AddWithValue("@logDate", hs.logDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating HVC standing record: " + ex.Message, ex);
            }
        }

        public HvcStanding GetHvcStandingById(int hvcStandingId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getHvcStandingById(@hvcStandingId)", db.GetConnection());
                    command.Parameters.AddWithValue("@hvcStandingId", hvcStandingId);

                    MySqlDataReader reader = command.ExecuteReader();

                    HvcStanding hs = null;

                    if (reader.Read())
                    {
                        hs = new HvcStanding();
                        hs.hvcStandingId= (int)reader["hvcStandingId"];
                        hs.hvcSrId = reader["hvcSrId"].ToString();
                        hs.cropStageId = (int)reader["cropStageId"];
                        hs.cropTypeId = (int)reader["cropTypeId"];
                        hs.size = (float)reader["size"];
                        hs.logDate = DateTime.Parse(reader["logDate"].ToString());
                    }

                    reader.Close();
                    return hs;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting HVC record by ID: " + ex.Message, ex);
            }
        }

        public Boolean MoveNextHvcStanding(HvcStanding hs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_moveNextHvcStanding(@hvcSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@hvcSrId", hs.hvcSrId);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error moving next HVC standing record: " + ex.Message, ex);
            }
        }

        public DataTable LoadHvcStandingDataGrid(string hvcSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getHvcStanding(@hvcSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@hvcSrId", hvcSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading HVC standing records: " + ex.Message, ex);
            }
        }

        public DataTable LoadHvcStandingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchHvcStanding(@column, @keyword)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@column", column);
                    command.Parameters.AddWithValue("@keyword", keyword);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading HVC standing report records: " + ex.Message, ex);
            }
        }


    }
}
