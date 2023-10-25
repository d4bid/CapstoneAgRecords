using AgRecords.Model;
using AgRecords.View;
using Microsoft.VisualBasic;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.Controller
{
    public class LetterController
    {
        private LettersView lettersView;
        private LettersAddView lettersAddView;
        private LettersEditView lettersEditView;


        private LetterModel letterModel;
        UserModel userModel = new UserModel();
        private Boolean isDone = false; //for processing CRUD operations

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public LetterController(LettersView lettersView)
        {
            this.lettersView = lettersView;
            letterModel = new LetterModel();
        }

        public LetterController(LettersAddView lettersAddView)
        {
            this.lettersAddView = lettersAddView;
            letterModel = new LetterModel();
        }

        public LetterController(LettersEditView lettersEditView)
        {
            this.lettersEditView = lettersEditView;
            letterModel = new LetterModel();
        }

        public void GenerateNewLetterID()
        {
            try
            {
                lettersAddView.GenerateNewLetterId(letterModel.GenerateLetterId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable LoadLetterView()
        {
            try
            {
                DataTable lettersTable = letterModel.LoadLettersDataGrid();
                return lettersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Letters Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

        }

        public bool AddLetter(string letterId, string letterTitle, string letterType, string letterDescription, List<TagItem> letterTags, string letterTo, string letterFrom, string letterAction, Dictionary<string, Image> imageDictionary, DateTime letterDate)
        {
            try
            {
                // Create a StringBuilder to efficiently build the concatenated string
                StringBuilder concatenatedTags = new StringBuilder();
                string userId = GetUserIdByFullName(fullName);
                string pageletterId = "";

                foreach (TagItem tagItem in letterTags)
                {
                    string text = tagItem.Text;

                    // Append the text followed by a comma and space to the StringBuilder
                    concatenatedTags.Append(text);
                    concatenatedTags.Append(", ");
                }

                // Check if there are items in the list before removing the trailing comma and space
                if (letterTags.Count > 0)
                {
                    concatenatedTags.Length -= 2; // Remove the last 2 characters (comma and space)
                }


                Letters letter = new Letters()
                {
                    letterId = letterId,
                    userId = userId,
                    letterTitle = letterTitle,
                    letterType = letterType,
                    letterDescription = letterDescription,
                    letterTo = letterTo,
                    letterFrom = letterFrom,
                    letterAction = letterAction,
                    letterDate = letterDate
                };

                if (letter.letterTitle == "")
                {
                    MessageBox.Show("Please provide a title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (concatenatedTags.ToString().Count(c => c == ',') < 2)
                {
                    MessageBox.Show("Please add at least three tags.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterTo == "")
                {
                    MessageBox.Show("Please provide recipient information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterFrom == "")
                {
                    MessageBox.Show("Please provide sender information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterDescription == "")
                {
                    MessageBox.Show("Please provide a description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (imageDictionary.Count < 1)
                {
                    MessageBox.Show("Please attach at least one photo to your letter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (letter.letterTitle != "" && letter.letterDescription != "" && letter.letterTo != "" && letter.letterFrom != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to save this letter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) //proceed to saving the letter
                    {
                        if (letterModel.AddNewLetter(letter, concatenatedTags))
                        {
                            //foreach here, iterate using the dictionary, save only the image
                            int pageNumber = 1;
                            foreach (var kvp in imageDictionary)
                            {
                                Image pageImage = kvp.Value;
                                string pageFileName = kvp.Key;

                                // Call the AddLetterPage method for each image
                                letterModel.AddLetterPage(letter.letterId, pageNumber.ToString(), pageImage, pageFileName);

                                pageNumber++; // Increment the page number
                            }

                            MessageBox.Show("Letter saved succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isDone = true;
                            userModel.InserActionLog(username, "Insert", "Letter", $"{letterId} added successfully.");
                        }
                    }
                    else //cancel saving
                    {

                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Letter was not added. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "Letter", $"{letterId} adding failed.");
                return false;
            }
        }

        public bool UpdateLetter(string letterId, string letterTitle, string letterType, string letterDescription, List<string> letterTags, string letterTo, string letterFrom, string letterAction, Dictionary<string, Image> imageDictionary, DateTime letterDate)
        {
            try
            {
                // Create a StringBuilder to efficiently build the concatenated string
                StringBuilder concatenatedTags = new StringBuilder();
                string pageletterId = "";

                foreach (string tagItem in letterTags)
                {
                    string text = tagItem;

                    // Append the text followed by a comma and space to the StringBuilder
                    concatenatedTags.Append(text);
                    concatenatedTags.Append(", ");
                }

                // Check if there are items in the list before removing the trailing comma and space
                if (letterTags.Count > 0)
                {
                    concatenatedTags.Length -= 2; // Remove the last 2 characters (comma and space)
                }


                Letters letter = new Letters()
                {
                    letterId = letterId,
                    letterTitle = letterTitle,
                    letterType = letterType,
                    letterDescription = letterDescription,
                    letterTo = letterTo,
                    letterFrom = letterFrom,
                    letterAction = letterAction,
                    letterDate = letterDate

                };

                if (letter.letterTitle == "")
                {
                    MessageBox.Show("Please provide a title.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (concatenatedTags.ToString().Count(c => c == ',') < 2)
                {
                    MessageBox.Show("Please add at least three tags.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterTo == "")
                {
                    MessageBox.Show("Please provide recipient information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterFrom == "")
                {
                    MessageBox.Show("Please provide sender information.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (letter.letterDescription == "")
                {
                    MessageBox.Show("Please provide a description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (imageDictionary.Count < 1)
                {
                    MessageBox.Show("Please attach at least one photo to your letter.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (letter.letterTitle != "" && letter.letterDescription != "" && letter.letterTo != "" && letter.letterFrom != "")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to save this letter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) //proceed to saving the letter
                    {
                        letterModel.DeleteLetterPageById(letter.letterId);

                        if (letterModel.UpdateLetter(letter, concatenatedTags))
                        {
                            //foreach here, iterate using the dictionary, save only the image
                            int pageNumber = 1;
                            foreach (var kvp in imageDictionary)
                            {
                                Image pageImage = kvp.Value;
                                string pageFileName = kvp.Key;

                                // Call the AddLetterPage method for each image
                                letterModel.UpdateLetterPage(letter.letterId, pageNumber.ToString(), pageImage, pageFileName);

                                pageNumber++; // Increment the page number
                            }

                            MessageBox.Show("Letter updated succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isDone = true;
                            userModel.InserActionLog(username, "Update", "Letter", $"{letterId} updated successfully.");

                        }
                    }
                    else //cancel saving
                    {

                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update Letter Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Update", "Letter", $"{letterId} update failed.");

                return false;
            }
        }

        public string GetUserIdByFullName(string fullName)
        {
            try
            {
                return userModel.FindUserIDByFullName(fullName);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding User ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public Letters GetLetterInfoByLetterId(string letterId)
        {
            try
            {
                return letterModel.GetLetterInfoByLetterId(letterId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Letter Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public LettersPages GetLetterPagesByLetterId(string letterId)
        {
            try
            {
                return letterModel.GetLetterPagesByLetterId(letterId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Letter Pages Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable SearchLetter(string searchText, string categoryText, string letterType)
        {
            DataTable dt = new DataTable();
            if (categoryText == "All")
            {
                dt = letterModel.SearchLetterAll(searchText, letterType);
            }
            else if (categoryText == "ID")
            {
                dt = letterModel.SearchLetterID(searchText, letterType);
            }
            else if (categoryText == "Title")
            {
                dt = letterModel.SearchLetterTitle(searchText, letterType);
            }
            else if (categoryText == "Type")
            {
                dt = letterModel.SearchLetterType(searchText, letterType);
            }
            else if (categoryText == "Receiver")
            {
                dt = letterModel.SearchLetterReceiver(searchText, letterType);
            }
            else if (categoryText == "Sender")
            {
                dt = letterModel.SearchLetterSender(searchText, letterType);
            }
            else if (categoryText == "Date Received")
            {
                dt = letterModel.SearchLetterDateReceived(searchText, letterType);
            }

            return dt;
        }

    }
}
