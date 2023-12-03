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

        //public DataTable LoadRicePlantingReportDataGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_plant_list;", db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading rice records: " + ex.Message, ex);
        //    }
        //}

        //public DataTable LoadRiceStandingReportDataGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_stand_list;", db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading rice records: " + ex.Message, ex);
        //    }
        //}

        //public DataTable LoadRiceHarvestingReportDataGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_harvest_list;", db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading rice records: " + ex.Message, ex);
        //    }
        //}

        public DataTable LoadRicePlantingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchRicePlanting(@column, @keyword)";
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
                throw new ApplicationException("Error loading rice planting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceStandingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchRiceStanding(@column, @keyword)";
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
                throw new ApplicationException("Error loading rice standing records: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceHarvestingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchRiceHarvesting(@column, @keyword)";
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
                throw new ApplicationException("Error loading rice harvesting records: " + ex.Message, ex);
            }
        }

        public RicePlantingRep GetRicePlantReportById(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRicePlantReportById(@riceSrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RicePlantingRep rpr = null;

                    if (reader.Read())
                    {
                        rpr = new RicePlantingRep();
                        rpr.riceSrId = reader["riceSrId"].ToString();
                        rpr.season = reader["season"].ToString();
                        rpr.seasonYear = reader["seasonYear"].ToString();
                        rpr.month = reader["month"].ToString();
                        rpr.week = reader["week"].ToString();
                        rpr.year = reader["year"].ToString();
                        rpr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return rpr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice planting record by ID: " + ex.Message, ex);
            }
        }

        public RiceHarvestingRep GetRiceHarvestReportById(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRiceHarvestReportById(@riceSrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RiceHarvestingRep rhr = null;

                    if (reader.Read())
                    {
                        rhr = new RiceHarvestingRep();
                        rhr.riceSrId = reader["riceSrId"].ToString();
                        rhr.season = reader["season"].ToString();
                        rhr.seasonYear = reader["seasonYear"].ToString();
                        rhr.month = reader["month"].ToString();
                        rhr.week = reader["week"].ToString();
                        rhr.year = reader["year"].ToString();
                        rhr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return rhr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice harvesting record by ID: " + ex.Message, ex);
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

                        if (parts.Length == 3 && parts[0] == "RICE" && parts[1] == currentYear.ToString())
                        {
                            if (int.TryParse(parts[2], out int lastNumber))
                            {
                                nextNumber = lastNumber + 1;
                            }
                        }
                    }

                    return $"RICE-{currentYear}-{nextNumber:D2}";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }

        public int GetMaxRiceStandingLogId(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getMaxRiceStandingLogId(@riceSrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0; // Handle the case where no result is found
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice standing log ID: " + ex.Message, ex);
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

        public Boolean CheckRiceReportExist(RiceStandingRep rsr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_checkRiceReportExist(@month, @week, @year)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@month", rsr.month);
                    command.Parameters.AddWithValue("@week", rsr.week);
                    command.Parameters.AddWithValue("@year", rsr.year);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int recordExists = Convert.ToInt32(reader["recordExists"]);

                            // Return true if record exists (1), false if not (0)
                            return recordExists == 1;
                        }
                    }

                    return false;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error checking rice standing report existence: " + ex.Message, ex);
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

        public DataTable LoadRiceStandingDataGrid(string riceSrId, int farmId, int seedId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRiceStanding(@riceSrId, @farmId, @seedId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);
                    command.Parameters.AddWithValue("@farmId", farmId);
                    command.Parameters.AddWithValue("@seedId", seedId);

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

        public DataTable LoadRiceStandingTotalDataGrid(string riceSrId, int farmId, int seedId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRiceStandingTotal(@riceSrId, @farmId, @seedId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);
                    command.Parameters.AddWithValue("@farmId", farmId);
                    command.Parameters.AddWithValue("@seedId", seedId);

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

        public DataTable LoadRiceStandingGrandTotalDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRiceStandingGrandTotal(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

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

                    string query = "CALL sp_updateRiceStandingLogs(@riceStandingLogsId, @brgyId, @farmTypeId, @growthStageId, @seedTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceStandingLogsId", rs.riceStandingLogsId);
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

        public RicePlanting GetRicePlantingById(int ricePlantingId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRicePlantingById(@ricePlantingId)", db.GetConnection());
                    command.Parameters.AddWithValue("@ricePlantingId", ricePlantingId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RicePlanting rp = null;

                    if (reader.Read())
                    {
                        rp = new RicePlanting();
                        rp.ricePlantingId = (int)reader["ricePlantingId"];
                        rp.riceSrId = reader["riceSrId"].ToString();
                        rp.brgyId = (int)reader["brgyId"];
                        rp.farmTypeId = (int)reader["farmTypeId"];
                        rp.seedTypeId = (int)reader["seedTypeId"];
                        rp.size = (float)reader["size"];
                    }

                    reader.Close();
                    return rp;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice planting by ID: " + ex.Message, ex);
            }
        }

        public DataTable LoadRicePlantingDataGrid(string riceSrId, int farmId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRicePlanting(@riceSrId, @farmId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);
                    command.Parameters.AddWithValue("@farmId", farmId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice planting records: " + ex.Message, ex);
            }
        }


        // HARVESTING
        public Boolean AddRiceHarvestingRep(RiceHarvestingRep rhr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRiceHarvestingReport(@riceSrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", rhr.riceSrId);
                    command.Parameters.AddWithValue("@season", rhr.season);
                    command.Parameters.AddWithValue("@seasonYear", rhr.seasonYear);
                    command.Parameters.AddWithValue("@month", rhr.month);
                    command.Parameters.AddWithValue("@week", rhr.week);
                    command.Parameters.AddWithValue("@year", rhr.year);
                    command.Parameters.AddWithValue("@createdBy", rhr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new rice harvesting report: " + ex.Message, ex);
            }
        }

        public RiceHarvesting GetRiceHarvestingById(int riceHarvestingId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRiceHarvestingById(@riceHarvestingId)", db.GetConnection());
                    command.Parameters.AddWithValue("@riceHarvestingId", riceHarvestingId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RiceHarvesting rh = null;

                    if (reader.Read())
                    {
                        rh = new RiceHarvesting();
                        rh.riceHarvestingId = (int)reader["riceHarvestingId"];
                        rh.riceSrId = reader["riceSrId"].ToString();
                        rh.brgyId = (int)reader["brgyId"];
                        rh.farmTypeId = (int)reader["farmTypeId"];
                        rh.seedTypeId = (int)reader["seedTypeId"];
                        //rh.yield = (float)reader["yield"];
                        object yieldValue = reader["yield"];
                        rh.yield = yieldValue != DBNull.Value ? Convert.ToSingle(yieldValue) : 0.0f;
                        rh.size = (float)reader["size"];
                    }

                    reader.Close();
                    return rh;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice harvesting by ID: " + ex.Message, ex);
            }
        }

        public Boolean UpdateRiceHarvesting(RiceHarvesting rh)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateRiceHarvesting(@riceHarvestingId, @yield)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceHarvestingId", rh.riceHarvestingId);
                    //command.Parameters.AddWithValue("@brgyId", rh.brgyId);
                    //command.Parameters.AddWithValue("@farmTypeId", rh.farmTypeId);
                    //command.Parameters.AddWithValue("@seedTypeId", rh.seedTypeId);
                    //command.Parameters.AddWithValue("@size", rh.size);
                    command.Parameters.AddWithValue("@yield", rh.yield);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating harvesting record: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceHarvestingDataGrid(string riceSrId, int farmId, int seedId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRiceHarvesting(@riceSrId, @farmId, @seedId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);
                    command.Parameters.AddWithValue("@farmId", farmId);
                    command.Parameters.AddWithValue("@seedId", seedId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice harvesting records: " + ex.Message, ex);
            }
        }

        public int CountRiceReportExist(string month, string week, string year, string season, string seasonYear)
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_checkRiceReportExist(@month, @week, @year, @season, @seasonYear);", db.GetConnection());
                    command.Parameters.AddWithValue("@month", month);
                    command.Parameters.AddWithValue("@week", week);
                    command.Parameters.AddWithValue("@year", year);
                    command.Parameters.AddWithValue("@season", season);
                    command.Parameters.AddWithValue("@seasonYear", seasonYear);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }

                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        // PRINTING REPORTS
        public DataTable LoadRicePlantingDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllRicePlant(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice planting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceStandingDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllRiceStand(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

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

        public DataTable LoadRiceIrrigatedHarvestingDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllRiceIrrigatedHarvest(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading irrigated rice harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceLowlandHarvestingDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllRiceLowlandHarvest(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading lowland rice harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadRiceUplandHarvestingDataGrid(string riceSrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllRiceUplandHarvest(@riceSrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@riceSrId", riceSrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading upland rice harvesting records: " + ex.Message, ex);
            }
        }

        // Barangay
        public DataTable GetAllRiceBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable rolesTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rice_barangay;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(rolesTable);
                    return rolesTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting barangay: " + ex.Message, ex);
            }
        }
    }
}
