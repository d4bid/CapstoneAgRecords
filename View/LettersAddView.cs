using AgRecords.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class LettersAddView : Form
    {
        private LetterController letterController;
        private HashSet<string> addedImages = new HashSet<string>(); // Instantiate inside the event handler.

        public LettersAddView()
        {
            InitializeComponent();
            letterController = new LetterController(this);
        }

        private void LettersAddView_Load(object sender, EventArgs e)
        {
            //set initial value of combobox
            comboBoxType.SelectedIndex = 0;

            //generate new letterID
            labelLetterId.Text = letterController.GenerateNewLetterID();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> potentialDuplicates = new List<string>(); // Track potential duplicates.

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Get the file name.
                        string fileName = Path.GetFileName(filePath);

                        // Check if the image is already in the addedImages collection.
                        if (!addedImages.Contains(fileName))
                        {
                            // Load the image and add it to the ImageList with a unique key (use the file name as the key).
                            Image image = Image.FromFile(filePath);
                            imageList1.Images.Add(fileName, image);

                            // Add the file name to the ListView along with the image key.
                            ListViewItem item = new ListViewItem(fileName);
                            item.ImageKey = fileName; // Set the ImageKey to associate the image.
                            listView1.Items.Add(item);

                            // Update the addedImages collection.
                            addedImages.Add(fileName);
                        }
                        else
                        {
                            // Add potential duplicate file name to the list.
                            potentialDuplicates.Add(fileName);
                        }
                    }

                    // Check if there are potential duplicates and display them in a single message box.
                    if (potentialDuplicates.Count > 0)
                    {
                        string duplicatesMessage = $"The following images are potential duplicates and were not added:\n\n";
                        duplicatesMessage += string.Join("\n", potentialDuplicates);

                        MessageBox.Show(duplicatesMessage, "Potential Duplicate Images", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            // To remove an item(s) in the listView using button
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                // Get the file name of the removed item.
                string fileName = item.Text;

                // Remove the item from the ListView.
                listView1.Items.Remove(item);

                // Remove the corresponding entry from addedImages.
                addedImages.Remove(fileName);

            }
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            // To remove an item(s) in the listView using Delete key
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    // Get the file name of the removed item.
                    string fileName = item.Text;

                    // Remove the item from the ListView.
                    listView1.Items.Remove(item);

                    // Remove the corresponding entry from addedImages.
                    addedImages.Remove(fileName);

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LettersView lettersView = new LettersView();
            lettersView.Show();
            this.Close();
        }
    }
}
