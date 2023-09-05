using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class LetterModel
    {
        //generate new Letter ID
        public string GenerateLetterId()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxLetterId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return "LTR00001";
                    }
                    else
                    {
                        string lastId = result.ToString();
                        int lastNumber = int.Parse(lastId.Substring(4));
                        int nextNumber = lastNumber + 1;
                        string nextId = "LTR" + nextNumber.ToString("00000");
                        return nextId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating letter ID: " + ex.Message, ex);
            }
        }

        //get all predefined tags
        public List<string> LoadTagSuggestions()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    List<string> tagSuggestions = new List<string>();
                    MySqlCommand command = new MySqlCommand("SELECT `tagName` FROM vw_get_all_tags;", db.GetConnection());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tagName = reader.GetString("tagName");
                            tagSuggestions.Add(tagName);
                        }
                    }
                    return tagSuggestions;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading tag suggestions: " + ex.Message, ex);
            }
        }

    }
}
