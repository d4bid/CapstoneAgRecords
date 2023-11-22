using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    internal class CornModel
    {
        private DatabaseConnection db;

        public CornModel()
        {
            db = new DatabaseConnection();
        }

        public string GenerateNextCornId()
        {
            try
            {
                int currentYear = DateTime.Now.Year;

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxCornPlantEcoId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    int nextNumber = 1; // Default to 1 if no records are found

                    if (result != null && result != DBNull.Value)
                    {
                        string lastId = result.ToString();
                        string[] parts = lastId.Split('-');

                        if (parts.Length == 3 && parts[0] == "CORN" && parts[1] == currentYear.ToString())
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


        // PLANTING ECO

        public Boolean AddCornPlantingEcoRep(CornReport cr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addCornPlantingEcoReport(@cornPrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cr.cornPrId);
                    command.Parameters.AddWithValue("@season", cr.season);
                    command.Parameters.AddWithValue("@seasonYear", cr.seasonYear);
                    command.Parameters.AddWithValue("@month", cr.month);
                    command.Parameters.AddWithValue("@week", cr.week);
                    command.Parameters.AddWithValue("@year", cr.year);
                    command.Parameters.AddWithValue("@createdBy", cr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding corn report: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingEcoReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchCornPlantingEco(@column, @keyword)";
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
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }

        // Get report ID after CornAddViw
        public CornReport GetCornPlantingEcoReportById(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornPlantingEcoReportById(@cornPrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornReport cr = null;

                    if (reader.Read())
                    {
                        cr = new CornReport();
                        cr.cornPrId = reader["cornPrId"].ToString();
                        cr.season = reader["season"].ToString();
                        cr.seasonYear = reader["seasonYear"].ToString();
                        cr.month = reader["month"].ToString();
                        cr.week = reader["week"].ToString();
                        cr.year = reader["year"].ToString();
                        cr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return cr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting corn planting record by ID: " + ex.Message, ex);
            }
        }

        public Boolean AddCornPlantingEco(CornPlantingEco cpe)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addCornPlantingEco(@cornPrId, @brgyId, @landTypeId, @growthStageId, @seedTypeId, @colorTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cpe.cornPrId);
                    command.Parameters.AddWithValue("@brgyId", cpe.brgyId);
                    command.Parameters.AddWithValue("@landTypeId", cpe.landTypeId);
                    command.Parameters.AddWithValue("@growthStageId", cpe.growthStageId);
                    command.Parameters.AddWithValue("@seedTypeId", cpe.seedTypeId);
                    command.Parameters.AddWithValue("@colorTypeId", cpe.colorTypeId);
                    command.Parameters.AddWithValue("@size", cpe.size);
                    command.Parameters.AddWithValue("@logDate", cpe.logDate);

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

        public Boolean UpdateCornPlantingEco(CornPlantingEco cpe)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateCornPlantingEco(@cornPlantingEcoId, @brgyId, @landTypeId, @growthStageId, @seedTypeId, @colorTypeId, @size, @logDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPlantingEcoId", cpe.cornPlantingEcoId);
                    command.Parameters.AddWithValue("@brgyId", cpe.brgyId);
                    command.Parameters.AddWithValue("@landTypeId", cpe.landTypeId);
                    command.Parameters.AddWithValue("@growthStageId", cpe.growthStageId);
                    command.Parameters.AddWithValue("@seedTypeId", cpe.seedTypeId);
                    command.Parameters.AddWithValue("@colorTypeId", cpe.colorTypeId);
                    command.Parameters.AddWithValue("@size", cpe.size);
                    command.Parameters.AddWithValue("@logDate", cpe.logDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating corn record: " + ex.Message, ex);
            }
        }

        public CornPlantingEco GetCornPlantingEcoById(int cornPlantingEcoId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornPlantingEcoById(@cornPlantingEcoId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornPlantingEcoId", cornPlantingEcoId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornPlantingEco cpe = null;

                    if (reader.Read())
                    {
                        cpe = new CornPlantingEco();
                        cpe.cornPlantingEcoId = (int)reader["cornPlantingEcoId"];
                        cpe.cornPrId = reader["cornPrId"].ToString();
                        cpe.brgyId = (int)reader["brgyId"];
                        cpe.landTypeId = (int)reader["landTypeId"];
                        cpe.growthStageId = (int)reader["growthStageId"];
                        cpe.seedTypeId = (int)reader["seedTypeId"];
                        cpe.colorTypeId = (int)reader["colorTypeId"];
                        cpe.size = (float)reader["size"];
                        cpe.logDate = DateTime.Parse(reader["logDate"].ToString());
                    }

                    reader.Close();
                    return cpe;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting corn record by ID: " + ex.Message, ex);
            }
        }

        public Boolean MoveNextCornPlantingEco(CornPlantingEco cpe)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_moveNextCornPlantingEco(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cpe.cornPrId);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error moving next corn planting record: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingEcoDataGrid(string cornPrId, int colorId, int growthId, int seedId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getCornPlantingEco(@cornPrId, @colorId, @growthId, @seedId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);
                    command.Parameters.AddWithValue("@colorId", colorId);
                    command.Parameters.AddWithValue("@growthId", growthId);
                    command.Parameters.AddWithValue("@seedId", seedId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting by ecological zone records: " + ex.Message, ex);
            }
        }

        public int CountCornReportExist(string month, string week, string year, string season, string seasonYear)
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_checkCornReportExist(@month, @week, @year, @season, @seasonYear);", db.GetConnection());
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

        public DataTable LoadCornPlantingEcoTotalDataGrid(string cornPrId, int colorId, int growthId, int seedId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getCornPlantingEcoTotal(@cornPrId, @colorId, @growthId, @seedId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);
                    command.Parameters.AddWithValue("@colorId", colorId);
                    command.Parameters.AddWithValue("@growthId", growthId);
                    command.Parameters.AddWithValue("@seedId", seedId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting by ecological zone records: " + ex.Message, ex);
            }
        }


        // PLANTING
        public Boolean AddCornPlantingRep(CornReport cr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addCornPlantingReport(@cornPrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cr.cornPrId);
                    command.Parameters.AddWithValue("@season", cr.season);
                    command.Parameters.AddWithValue("@seasonYear", cr.seasonYear);
                    command.Parameters.AddWithValue("@month", cr.month);
                    command.Parameters.AddWithValue("@week", cr.week);
                    command.Parameters.AddWithValue("@year", cr.year);
                    command.Parameters.AddWithValue("@createdBy", cr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding corn report: " + ex.Message, ex);
            }
        }


        public CornReport GetCornPlantingReportById(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornPlantingReportById(@cornPrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornReport cr = null;

                    if (reader.Read())
                    {
                        cr = new CornReport();
                        cr.cornPrId = reader["cornPrId"].ToString();
                        cr.season = reader["season"].ToString();
                        cr.seasonYear = reader["seasonYear"].ToString();
                        cr.month = reader["month"].ToString();
                        cr.week = reader["week"].ToString();
                        cr.year = reader["year"].ToString();
                        cr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return cr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting corn planting record by ID: " + ex.Message, ex);
            }
        }

        //public DataTable LoadCornPlantingReportDataGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_corn_plant_list;", db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading corn records: " + ex.Message, ex);
        //    }
        //}

        public DataTable LoadCornPlantingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchCornPlanting(@column, @keyword)";
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
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }


        public CornPlanting GetCornPlantingById(int cornPlantingId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornPlantingById(@cornPlantingId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornPlantingId", cornPlantingId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornPlanting cp = null;

                    if (reader.Read())
                    {
                        cp = new CornPlanting();
                        cp.cornPlantingId = (int)reader["cornPlantingId"];
                        cp.cornPrId = reader["cornPrId"].ToString();
                        cp.brgyId = (int)reader["brgyId"];
                        cp.landTypeId = (int)reader["landTypeId"];
                        cp.seedTypeId = (int)reader["seedTypeId"];
                        cp.colorTypeId = (int)reader["colorTypeId"];
                        cp.size = (float)reader["size"];
                    }

                    reader.Close();
                    return cp;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice standing log by ID: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingDataGrid(string cornPrId, int seedId, int colorId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getCornPlanting(@cornPrId, @seedId, @colorId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);
                    command.Parameters.AddWithValue("@seedId", seedId);
                    command.Parameters.AddWithValue("@colorId", colorId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }


        // HARVESTING
        public Boolean AddCornHarvestingRep(CornReport cr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addCornHarvestingReport(@cornPrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cr.cornPrId);
                    command.Parameters.AddWithValue("@season", cr.season);
                    command.Parameters.AddWithValue("@seasonYear", cr.seasonYear);
                    command.Parameters.AddWithValue("@month", cr.month);
                    command.Parameters.AddWithValue("@week", cr.week);
                    command.Parameters.AddWithValue("@year", cr.year);
                    command.Parameters.AddWithValue("@createdBy", cr.createdBy);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding corn report: " + ex.Message, ex);
            }
        }

        public CornReport GetCornHarvestingReportById(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornHarvestingReportById(@cornPrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornReport cr = null;

                    if (reader.Read())
                    {
                        cr = new CornReport();
                        cr.cornPrId = reader["cornPrId"].ToString();
                        cr.season = reader["season"].ToString();
                        cr.seasonYear = reader["seasonYear"].ToString();
                        cr.month = reader["month"].ToString();
                        cr.week = reader["week"].ToString();
                        cr.year = reader["year"].ToString();
                        cr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return cr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting corn planting record by ID: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingReportDataGrid(string column, string keyword)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchCornHarvesting(@column, @keyword)";
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
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }

        //public DataTable LoadCornHarvestingReportDataGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_corn_harvest_list;", db.GetConnection());
        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading corn records: " + ex.Message, ex);
        //    }
        //}

        public CornHarvesting GetCornHarvestingById(int cornHarvestingId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getCornHarvestingById(@cornHarvestingId)", db.GetConnection());
                    command.Parameters.AddWithValue("@cornHarvestingId", cornHarvestingId);

                    MySqlDataReader reader = command.ExecuteReader();

                    CornHarvesting ch= null;

                    if (reader.Read())
                    {
                        ch = new CornHarvesting();
                        ch.cornHarvestingId = (int)reader["cornHarvestingId"];
                        ch.cornPrId = reader["cornPrId"].ToString();
                        ch.brgyId = (int)reader["brgyId"];
                        ch.landTypeId = (int)reader["landTypeId"];
                        ch.seedTypeId = (int)reader["seedTypeId"];
                        ch.colorTypeId = (int)reader["colorTypeId"];
                        ch.size = (float)reader["size"];
                        ch.yield = (float)reader["yield"];
                    }

                    reader.Close();
                    return ch;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice standing log by ID: " + ex.Message, ex);
            }
        }

        public Boolean UpdateCornHarvesting(CornHarvesting ch)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateCornPlantingEco(@cornHarvestingId, @yield)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornHarvestingId", ch.cornHarvestingId);
                    command.Parameters.AddWithValue("@yield", ch.yield);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating corn harvesting record: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingDataGrid(string cornPrId, int seedId, int colorId, int landId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getCornHarvesting(@cornPrId, @seedId, @colorId, @landId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);
                    command.Parameters.AddWithValue("@seedId", seedId);
                    command.Parameters.AddWithValue("@colorId", colorId);
                    command.Parameters.AddWithValue("@landId", landId);

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

        // PRINTING REPORT

        // Planting
        public DataTable LoadCornPlantingGmoHybridDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornGmoHybridPlanting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingOpvGreenSweetDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornOpvGreenSweetCornPlanting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingTraditionalGrandTotalDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornTraditionalGrandTotalPlanting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting records: " + ex.Message, ex);
            }
        }

        // Planting by Ecological Zone
        public DataTable LoadCornPlantingEcoYellowDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornYellowPlantingEco(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting by ecological zone records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingEcoWhiteDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornWhitePlantingEco(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting by ecological zone records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornPlantingEcoTotalDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornTotalPlantingEco(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn planting by ecological zone records: " + ex.Message, ex);
            }
        }

        // Harvesting
        public DataTable LoadCornHarvestingGmoDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornGmoHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingHybridDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornHybridHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingOpvDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornOpvHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingGreenSweetDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornGreenSweetHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingTraditionalDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornTraditionalHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        public DataTable LoadCornHarvestingTotalDataGrid(string cornPrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getAllCornTotalHarvesting(@cornPrId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@cornPrId", cornPrId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn harvesting records: " + ex.Message, ex);
            }
        }

        // Barangay
        public DataTable GetAllCornBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable rolesTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_corn_barangay;", db.GetConnection());
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
