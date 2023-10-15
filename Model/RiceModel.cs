using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    internal class RiceModel
    {
        private DatabaseConnection db;

        public RiceModel()
        {
            db = new DatabaseConnection();
        }

        public DataTable LoadRiceReportDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_report;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice records: " + ex.Message, ex);
            }
        }

        // STANDING

        //generate next rice stand report id

        public string GenerateNextStandId()
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxRiceStandId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    int nextNumber = 1; // Default to 1 if no records are found

                    if (result != null && result != DBNull.Value)
                    {
                        string lastId = result.ToString();
                        string[] parts = lastId.Split('-');

                        if (parts.Length == 3 && parts[0] == "RICESTANDING" && parts[1] == currentYear.ToString())
                        {
                            if (int.TryParse(parts[2], out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    return $"RICESTANDING-{currentYear}-{nextNumber:D2}";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }


        // Add report
        public Boolean AddRiceStandingRep(RiceStandingRep rsr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRiceStandingReport(@riceSrId, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rsr.riceSrId);
                    command.Parameters.AddWithValue("@month", rsr.month);
                    command.Parameters.AddWithValue("@week", rsr.week);
                    command.Parameters.AddWithValue("@year", rsr.year);
                    command.Parameters.AddWithValue("@createdBy", rsr.createdBy);

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

        // get rice standing report details
        public RiceStandingRep GetRiceStandReportById(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRiceStandReportById(@riceSrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RiceStandingRep rsr = null;

                    if (reader.Read())
                    {
                        rsr = new RiceStandingRep();
                        rsr.riceSrId = reader["riceSrId"].ToString();
                        rsr.month = reader["month"].ToString();
                        rsr.week = reader["week"].ToString();
                        rsr.year = reader["year"].ToString();
                        rsr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return rsr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice standing record by ID: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadIrrigatedRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getIrrigatedRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadLowlandRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getLowlandRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadUplandRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getUplandRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadIrrigatedUplandRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getIrrigatedUplandRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadIrrigatedLowlandRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getIrrigatedLowlandRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        public DataTable LoadLowlandUplandRiceStandLogsDataGrid(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getLowlandUplandRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing logs: " + ex.Message, ex);
            }
        }

        // Move Next Rice Standing Logs
        public Boolean MoveNextRiceStandingLogs(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_moveNextRiceStandingLogs(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error moving next rice standing logs: " + ex.Message, ex);
            }
        }

        // Add Rice Standing Logs
        public Boolean AddRiceStandingLogs(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRiceStandingLog(@riceSrId, @brgyId, @farmTypeId, @growthStageId, @seedTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);
                    command.Parameters.AddWithValue("@brgyId", rs.brgyId);
                    command.Parameters.AddWithValue("@farmTypeId", rs.farmTypeId);
                    command.Parameters.AddWithValue("@growthStageId", rs.growthStageId);
                    command.Parameters.AddWithValue("@seedTypeId", rs.seedTypeId);
                    command.Parameters.AddWithValue("@size", rs.size);
                    command.Parameters.AddWithValue("@logDate", rs.logDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new rice standing record: " + ex.Message, ex);
            }
        }

        // Update Rice Standing Log
        public Boolean UpdateRiceStandingLog(RiceStanding rs)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRiceStandingLog(@riceStandingLogsId, @riceSrId, @brgyId, @farmTypeId, @growthStageId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceStandingLogsId", rs.riceStandingLogsId);
                    command.Parameters.AddWithValue("@riceSrId", rs.riceSrId);
                    command.Parameters.AddWithValue("@brgyId", rs.brgyId);
                    command.Parameters.AddWithValue("@farmTypeId", rs.farmTypeId);
                    command.Parameters.AddWithValue("@growthStageId", rs.growthStageId);
                    command.Parameters.AddWithValue("@seedTypeId", rs.seedTypeId);
                    command.Parameters.AddWithValue("@size", rs.size);
                    command.Parameters.AddWithValue("@logDate", rs.logDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new rice standing record: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceStandReportsDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_stand_report;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice standing records: " + ex.Message, ex);
            }
        }

        // get rice standing logs details
        public RiceStanding GetRiceStandingLogsById(int riceStandingLogsId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRiceStandingLogsById(@riceStandingLogsId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceStandingLogsId", riceStandingLogsId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RiceStanding rs = null;

                    if (reader.Read())
                    {
                        rs = new RiceStanding();
                        rs.riceStandingLogsId = (int)reader["riceStandingLogsId"];
                        rs.riceSrId = reader["riceSrId"].ToString();
                        rs.brgyId = (int)reader["brgyId"];
                        rs.farmTypeId = (int)reader["farmTypeId"];
                        rs.growthStageId = (int)reader["growthStageId"];
                        rs.seedTypeId = (int)reader["seedTypeId"];
                        rs.size = (float)reader["size"];
                        rs.logDate = DateTime.Parse(reader["logDate"].ToString());
                    }

                    reader.Close();
                    return rs;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice standing log by ID: " + ex.Message, ex);
            }
        }


        // PLANTING
        public Boolean AddRicePlantingRep(RicePlantingRep rpr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRicePlantingReport(@riceSrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rpr.riceSrId);
                    command.Parameters.AddWithValue("@season", rpr.season);
                    command.Parameters.AddWithValue("@seasonYear", rpr.seasonYear);
                    command.Parameters.AddWithValue("@month", rpr.month);
                    command.Parameters.AddWithValue("@week", rpr.week);
                    command.Parameters.AddWithValue("@year", rpr.year);
                    command.Parameters.AddWithValue("@createdBy", rpr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new rice planting report: " + ex.Message, ex);
            }
        }
      

        ////get rice planting report details
        //public RicePlantingRep GetRicePlantReportById(string ricePrId)
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();

        //            MySqlCommand command = new MySqlCommand("CALL sp_getRicePlantReportById(@ricePrId)", db.GetConnection());
        //            command.Parameters.AddWithValue("@ricePrId", ricePrId);

        //            MySqlDataReader reader = command.ExecuteReader();

        //            RicePlantingRep rpr = null;

        //            if (reader.Read())
        //            {
        //                rpr = new RicePlantingRep();
        //                rpr.ricePrId = reader["ricePrId"].ToString();
        //                rpr.season= reader["season"].ToString();
        //                rpr.seasonYear = reader["seasonYear"].ToString();
        //                rpr.month = reader["month"].ToString();
        //                rpr.week = reader["week"].ToString();
        //                rpr.year = (int)reader["year"];
        //                rpr.createdBy = reader["createdBy"].ToString();
        //            }

        //            reader.Close();
        //            return rpr;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error getting rice planting report by ID: " + ex.Message, ex);
        //    }
        //}

    }
}
