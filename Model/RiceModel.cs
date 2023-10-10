using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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


        //add user account
        public Boolean AddRicePlantingRep(RicePlantingRep rpr)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addRicePlantingReport(@ricePrId, @season, @seasonYear, @month, @week, @year, @createdBy)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@ricePrId", rpr.ricePrId);
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

        //generate next rice plant report id

        public string GenerateNextId()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxRicePlantId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    int currentYear = DateTime.Now.Year;

                    if (result == null || result == DBNull.Value)
                    {
                        return $"RICE-{currentYear}-001";
                    }
                    else
                    {
                        string lastId = result.ToString();
                        int lastYear = int.Parse(lastId.Substring(5, 4)); // Extract the year from the last ID
                        int lastNumber = int.Parse(lastId.Substring(10)); // Extract the number part
                        string nextId;

                        if (currentYear == lastYear)
                        {
                            int nextNumber = lastNumber + 1;
                            nextId = $"RICEPLANTING-{currentYear}-{nextNumber.ToString("000")}";
                        }
                        else if (currentYear == lastYear + 1)
                        {
                            nextId = $"RICE-{currentYear}-001"; // Reset for the new year
                        }
                        else
                        {
                            // Handle cases where the current year is not consecutive to the last year
                            throw new InvalidOperationException("Year gap is greater than 1, manual intervention may be needed.");
                        }

                        return nextId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating next ID: " + ex.Message, ex);
            }
        }

        //get rice planting report details
        public RicePlantingRep GetRicePlantReportById(string ricePrId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRicePlantReportById(@ricePrId)", db.GetConnection());
                    command.Parameters.AddWithValue("@ricePrId", ricePrId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RicePlantingRep rpr = null;

                    if (reader.Read())
                    {
                        rpr = new RicePlantingRep();
                        rpr.ricePrId = reader["ricePrId"].ToString();
                        rpr.season= reader["season"].ToString();
                        rpr.seasonYear = reader["seasonYear"].ToString();
                        rpr.month = reader["month"].ToString();
                        rpr.week = reader["week"].ToString();
                        rpr.year = (int)reader["year"];
                        rpr.createdBy = reader["createdBy"].ToString();
                    }

                    reader.Close();
                    return rpr;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting rice planting report by ID: " + ex.Message, ex);
            }
        }

    }
}
