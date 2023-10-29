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
    }
}
