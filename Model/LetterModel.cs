using Microsoft.VisualBasic.ApplicationServices;
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

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxLetterId()", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        string today = DateTime.Now.ToString("yyyyMMdd");
                        return today + "00001";
                    }
                    else
                    {
                        string lastId = result.ToString();
                        int lastNumber = int.Parse(lastId.Substring(8));
                        int nextNumber = lastNumber + 1;
                        string nextId = DateTime.Now.ToString("yyyyMMdd") + nextNumber.ToString("00000");
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

                    string query = "CALL sp_addNewLetter(@letterId, @userId, @letterTitle, @letterType, @letterDescription, @letterTags, @letterTo, @letterFrom, @letterAction, @letterDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letter.letterId);
                    command.Parameters.AddWithValue("@userId", letter.userId);
                    command.Parameters.AddWithValue("@letterTitle", letter.letterTitle);
                    command.Parameters.AddWithValue("@letterType", letter.letterType);
                    command.Parameters.AddWithValue("@letterDescription", letter.letterDescription);
                    command.Parameters.AddWithValue("@letterTags", concatenatedTags);
                    command.Parameters.AddWithValue("@letterTo", letter.letterTo);
                    command.Parameters.AddWithValue("@letterFrom", letter.letterFrom);
                    command.Parameters.AddWithValue("@letterAction", letter.letterAction);
                    command.Parameters.AddWithValue("@letterDate", letter.letterDate);

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
        public Boolean AddLetterPage(string letterId, string pageNumber, Image pageImage, string pageFileName)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewLetterPage(@letterId, @pageNumber, @pageImage, @pageFileName)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);
                    command.Parameters.AddWithValue("@pageNumber", pageNumber);
                    command.Parameters.AddWithValue("@pageFileName", pageFileName);

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

        public Letters GetLetterInfoByLetterId(string letterId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getLetterById(@letterId)", db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);

                    MySqlDataReader reader = command.ExecuteReader();

                    Letters letter = null;

                    if (reader.Read())
                    {
                        letter = new Letters();
                        letter.letterId = reader["letterId"].ToString();
                        letter.letterTitle = reader["letterTitle"].ToString();
                        letter.letterType = reader["letterType"].ToString();
                        letter.letterDescription = reader["letterDescription"].ToString();
                        letter.letterTags = reader["letterTags"].ToString();
                        letter.letterTo = reader["letterTo"].ToString();
                        letter.letterFrom = reader["letterFrom"].ToString();
                        letter.letterAction = reader["letterAction"].ToString();
                        letter.letterDate = DateTime.Parse(reader["letterDate"].ToString());

                    }

                    reader.Close();
                    return letter;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting letter info by ID: " + ex.Message, ex);
            }
        }

        public LettersPages GetLetterPagesByLetterId(string letterId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getLetterPagesById(@letterId)", db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);

                    MySqlDataReader reader = command.ExecuteReader();

                    LettersPages letterPages = new LettersPages();

                    while (reader.Read())
                    {
                        string pageFileName = reader["pageFileName"].ToString();
                        byte[] pageImageBytes = (byte[])reader["pageImage"];

                        // Convert the byte array to a System.Drawing.Image
                        using (MemoryStream ms = new MemoryStream(pageImageBytes))
                        {
                            Image pageImage = Image.FromStream(ms);

                            // Add the pageFileName and pageImage to the imageDictionary
                            letterPages.imageDictionary.Add(pageFileName, pageImage);
                        }
                    }

                    reader.Close();
                    return letterPages;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting letter pages by ID: " + ex.Message, ex);
            }
        }

        public Boolean UpdateLetter(Letters letter, StringBuilder concatenatedTags)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateLetter(@letterId, @letterTitle, @letterType, @letterDescription, @letterTags, @letterTo, @letterFrom, @letterAction, @letterDate)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letter.letterId);
                    command.Parameters.AddWithValue("@letterTitle", letter.letterTitle);
                    command.Parameters.AddWithValue("@letterType", letter.letterType);
                    command.Parameters.AddWithValue("@letterDescription", letter.letterDescription);
                    command.Parameters.AddWithValue("@letterTags", concatenatedTags);
                    command.Parameters.AddWithValue("@letterTo", letter.letterTo);
                    command.Parameters.AddWithValue("@letterFrom", letter.letterFrom);
                    command.Parameters.AddWithValue("@letterAction", letter.letterAction);
                    command.Parameters.AddWithValue("@letterDate", letter.letterDate);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating letter: " + ex.Message, ex);
            }
        }

        public Boolean DeleteLetterPageById(string letterId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_deleteLetterPageById(@letterId)", db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);

                    // Execute the command to delete the letter page
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error deleting letter page by ID: " + ex.Message, ex);
            }
        }

        public Boolean UpdateLetterPage(string letterId, string pageNumber, Image pageImage, string pageFileName)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    // Convert the Image to a byte array
                    byte[] imageBytes = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pageImage.Save(ms, ImageFormat.Png);
                        imageBytes = ms.ToArray();
                    }

                    string query = "CALL sp_addNewLetterPage(@letterId, @pageNumber, @pageImage, @pageFileName)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@letterId", letterId);
                    command.Parameters.AddWithValue("@pageNumber", pageNumber);
                    command.Parameters.AddWithValue("@pageFileName", pageFileName);
                    command.Parameters.AddWithValue("@pageImage", imageBytes);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating letter page: " + ex.Message, ex);
            }
        }

        //FOR SEARCHIIIIIIIING

        //Search to all columns
        public DataTable SearchLetterAll(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterAll(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        //Search by categories
        public DataTable SearchLetterID(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterID(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterTitle(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterTitle(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterTags(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterTags(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterType(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterType(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterReceiver(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterReceiver(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterSender(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterSender(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public DataTable SearchLetterDateReceived(string searchText, string letterType)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    string query = "CALL sp_searchLetterDateReceived(@searchText, @letterType)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@searchText", searchText);
                    command.Parameters.AddWithValue("@letterType", letterType);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error Searching Letter: " + ex.Message, ex);
            }
        }

        public Boolean UpdateLetterStatus()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateLetterStatus()";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error updating letter: " + ex.Message, ex);
            }
        }
    }
}
