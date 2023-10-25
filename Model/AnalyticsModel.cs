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
    }
}
