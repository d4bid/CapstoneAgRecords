using AgRecords.View;
using MySql.Data.MySqlClient;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    internal class AnalyticsModel
    {
        private DatabaseConnection db;

        public AnalyticsModel()
        {
            db = new DatabaseConnection();
        }

        // DATA
        public float AvgGaiFarming()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataGetAvgGaiFarming();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToSingle(result); // Convert the result to a float
                    }

                    return 0.0f;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public float AvgGaiNonFarming()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataGetAvgGaiNonFarming();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToSingle(result); // Convert the result to a float
                    }

                    return 0.0f;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable CountCoopBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountCoopBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading associations: " + ex.Message, ex);
            }
        }

        public DataTable LoadRecentLetters()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getRecentLetters()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading letters: " + ex.Message, ex);
            }
        }

        public DataTable LoadLetterNotif()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getLetterNotif()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading notifications: " + ex.Message, ex);
            }
        }

        public string CountFarmer()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountFarmer();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string CountFisherfolk()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountFisherfolk();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string CountRsbsaFarmers()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountFarmers();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        // CHARTS

        public DataTable CountFarmerBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountFarmerBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer barangays: " + ex.Message, ex);
            }
        }

        public DataTable CountFarmerCommodity()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountFarmerCommodity()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer commodity: " + ex.Message, ex);
            }
        }

        public DataTable CountFarmerSex()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountFarmerSex()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer sex: " + ex.Message, ex);
            }
        }

        public DataTable CountDailyActivities()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountDailyActivities()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading daily activities: " + ex.Message, ex);
            }
        }

        public DataTable CountActivitiesSection()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountActivitySection()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading daily activities: " + ex.Message, ex);
            }
        }

        // ---------------- RSBSA -----------------------

        public string CountRsbsaWeeklyReg()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountWeeklyReg();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable CountCommodityBarangay(string brgy)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountCommodityBarangay(?)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("brgy", brgy);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer commodity: " + ex.Message, ex);
            }
        }

        public DataTable CountRsbsaRegBrgy(string interval_type)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountRsbsaRegBrgy(?)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("interval_type", interval_type);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading RSBSA registration: " + ex.Message, ex);
            }
        }

        public DataTable CountLivelihoodBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountLivelihoodBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading livelihood per barangay: " + ex.Message, ex);
            }
        }

        public DataTable CountFarmerBrgy()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountFarmerBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer count: " + ex.Message, ex);
            }
        }

        // ---------------- RICE -----------------------

        public string CountRiceFarmers()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountRiceFarmer();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalRiceLandArea()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalRiceLandArea();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayRice()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalBarangayRice();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalRiceAreaPlanted()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalRiceAreaPlanted();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable GetRiceProduction()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_dataRiceProduction()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice production: " + ex.Message, ex);
            }
        }

        public DataTable CountRiceFarmerBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountRiceFarmerBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice farmers per barangay: " + ex.Message, ex);
            }
        }

        public DataTable CountRiceFarmerSex()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountRiceFarmerSex()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice farmers data: " + ex.Message, ex);
            }
        }

        public DataTable CountHarvestedOutOfPlanted()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartRiceHarvestedOutOfPlanted()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice farmers data: " + ex.Message, ex);
            }
        }

        public DataTable TotalRiceLandAreaPerFarmType()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartRiceLandAreaPerFarmType()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading rice farm data: " + ex.Message, ex);
            }
        }

        // Forecasting
        public double RiceProductionActual(int year)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_chartRiceProduction(@year);", db.GetConnection());
                    command.Parameters.AddWithValue("@year", year);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        if (double.TryParse(result.ToString(), out double production))
                        {
                            return production;
                        }
                    }

                    return 0.0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }


        // ---------------- CORN -----------------------

        public string CountCornFarmers()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountCornFarmer();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornLandArea()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalCornLandArea();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayCorn()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalBarangayCorn();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornAreaPlanted()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalCornAreaPlanted();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornAreaPlantedYellow()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalCornAreaPlantedYellow();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornAreaPlantedWhite()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalCornAreaPlantedWhite();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable GetCornProduction()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_dataCornProduction()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn production: " + ex.Message, ex);
            }
        }

        public DataTable CountCornFarmerBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountCornFarmerBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn farmers per barangay: " + ex.Message, ex);
            }
        }

        public DataTable CountCornFarmerSex()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountCornFarmerSex()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading corn farmers data: " + ex.Message, ex);
            }
        }


        // ---------------- HVC -----------------------

        public string CountHvcFarmers()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataCountHvcFarmer();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalHvcLandArea()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalHvcLandArea();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayHvc()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalBarangayHvc();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalHvcAreaPlanted()
        {
            try
            {

                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_dataTotalHvcAreaPlanted();", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return result.ToString(); // Convert the result to a string
                    }

                    return "0";
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable GetHvcList()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_dataListHvc()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading list of HVC: " + ex.Message, ex);
            }
        }

        public DataTable CountHvcFarmerSex()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountHvcFarmerSex()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading HVC farmers data: " + ex.Message, ex);
            }
        }

        public DataTable CountHvcFarmerBarangay()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartCountHvcFarmerBarangay()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading HVC farmers per barangay: " + ex.Message, ex);
            }
        }

        public DataTable TotalStandingHvc()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartTotalStandingHvc()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading total standing HVC: " + ex.Message, ex);
            }
        }

        public DataTable HvcStageProgression(string month, string week)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_chartHvcProgression(@month, @week)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@month", month);
                    command.Parameters.AddWithValue("@week", week);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading farmer commodity: " + ex.Message, ex);
            }
        }

        // ---------------- Letters -----------------------


        // ---------------- WEEKLY ACTIVITIES -----------------------
        public DataTable LoadWeeklyActivitiesDtaGrid(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getWeeklyActivities(@fromDate, @toDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading weekly activities: " + ex.Message, ex);
            }
        }

        public DataTable LoadActivitiesSummaryDtaGrid(DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_getActivitiesSummary(@fromDate, @toDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@fromDate", fromDate);
                    command.Parameters.AddWithValue("@toDate", toDate);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading summary: " + ex.Message, ex);
            }
        }
        
        //public DataTable LoadWeeklyActivitiesDtaGrid()
        //{
        //    try
        //    {
        //        using (DatabaseConnection db = new DatabaseConnection())
        //        {
        //            db.Open();
        //            DataTable dataTable = new DataTable();
        //            string query = "SELECT * FROM vw_get_all_weekly_activities";
        //            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

        //            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //            adapter.Fill(dataTable);
        //            return dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Error loading weekly activities: " + ex.Message, ex);
        //    }
        //}
    }
}
