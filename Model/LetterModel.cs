using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class LetterModel
    {
        public DataTable LoadLettersDataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_letters;", db.GetConnection());
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

        //add new letter
        public Boolean AddNewLetter(Letters letter, StringBuilder concatenatedTags)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewLetter(@letterId, @userId, @letterTitle, @letterType, @letterDescription, @letterTags, @letterTo, @letterFrom)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letter.letterId);
                    command.Parameters.AddWithValue("@userId", letter.userId);
                    command.Parameters.AddWithValue("@letterTitle", letter.letterTitle);
                    command.Parameters.AddWithValue("@letterType", letter.letterType);
                    command.Parameters.AddWithValue("@letterDescription", letter.letterDescription);
                    command.Parameters.AddWithValue("@letterTags", concatenatedTags);
                    command.Parameters.AddWithValue("@letterTo", letter.letterTo);
                    command.Parameters.AddWithValue("@letterFrom", letter.letterFrom);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new letter: " + ex.Message, ex);
            }
        }

        //add new letter page
        public Boolean AddLetterPage(string letterId, string pageNumber, Image pageImage)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewLetterPage(@letterId, @pageNumber, @pageImage)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);
                    command.Parameters.AddWithValue("@pageNumber", pageNumber);

                    // Convert the Image to a byte array
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pageImage.Save(ms, ImageFormat.Jpeg); // Replace with the appropriate image format
                        imageBytes = ms.ToArray();
                    }

                    command.Parameters.AddWithValue("@pageImage", imageBytes);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new letter page: " + ex.Message, ex);
            }
        }

    }
}
