using AgRecords.Controller;
using AgRecords.Model;
using FontAwesome.Sharp;
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
    public partial class LettersEditView : Form
    {
        private LetterController letterController;
        private Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>();
        private List<TagItem> tagItems = new List<TagItem>();
        private List<string> letterTags = new List<string>();
        private int controlHeight = 20;
        public event EventHandler FormClosed;

        public LettersEditView(Letters letters, LettersPages lettersPages)
        {
            letterController = new LetterController(this);
            InitializeComponent();

            labelLetterId.Text = letters.letterId;
            txtBoxTitle.Text = letters.letterTitle;
            comboBoxType.Text = letters.letterType;
            comboBoxAction.Text = letters.letterAction;
            txtBoxDescription.Text = letters.letterDescription;
            txtBoxFrom.Text = letters.letterFrom;
            txtBoxTo.Text = letters.letterTo;
            dateTimePicker1.Value = letters.letterDate;

            //to restore tags
            string[] tagsArray = letters.letterTags.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string tagText in tagsArray)
            {
                RegisterTag(tagText);
            }

            // To restore photos
            foreach (var kvp in lettersPages.imageDictionary)
            {
                string fileName = kvp.Key;
                Image originalImage = kvp.Value;
                Image clonedImage = (Image)originalImage.Clone(); // Clone the original image to avoid conflicts

                // Check if the image is already in the imageList1
                if (!imageList1.Images.ContainsKey(fileName))
                {
                    imageList1.Images.Add(fileName, clonedImage);
                }

                // Check if the ListViewItem with the same fileName already exists in the listViewLetters
                bool itemExists = false;
                foreach (ListViewItem item in listViewLetters.Items)
                {
                    if (item.Text == fileName)
                    {
                        itemExists = true;
                        break;
                    }
                }

                // If the ListViewItem doesn't exist, add it to the listViewLetters
                if (!itemExists)
                {
                    ListViewItem item = new ListViewItem(fileName);
                    item.ImageKey = fileName; // Set the ImageKey to associate the image.
                    listViewLetters.Items.Add(item);
                }

                // Store the key-value pair in your imageDictionary
                if (!imageDictionary.ContainsKey(fileName))
                {
                    imageDictionary.Add(fileName, clonedImage);
                }
                else
                {
                    // If the key already exists, remove the existing image and update with the new one
                    imageDictionary.Remove(fileName);
                    imageDictionary.Add(fileName, clonedImage);
                }
            }
        }

        private Image ImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void LettersEditView_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // To remove an item(s) in the listView using button
            foreach (ListViewItem item in listViewLetters.SelectedItems)
            {
                // Get the file name of the removed item.
                string fileName = item.Text;

                // Remove the item from the ListView.
                listViewLetters.Items.Remove(item);

                // Remove the corresponding image from imageDictionary.
                if (imageDictionary.ContainsKey(fileName))
                {
                    Image removedImage = imageDictionary[fileName];
                    removedImage.Dispose(); // Dispose of the image to free up resources.
                    imageDictionary.Remove(fileName);
                }
            }
        }

        private void listViewLetters_KeyDown(object sender, KeyEventArgs e)
        {
            // To remove an item(s) in the listView using Delete key
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in listViewLetters.SelectedItems)
                {
                    // Get the file name of the removed item.
                    string fileName = item.Text;

                    // Remove the item from the ListView.
                    listViewLetters.Items.Remove(item);

                    // Remove the corresponding image from imageDictionary.
                    if (imageDictionary.ContainsKey(fileName))
                    {
                        Image removedImage = imageDictionary[fileName];
                        removedImage.Dispose(); // Dispose of the image to free up resources.
                        imageDictionary.Remove(fileName);
                    }
                }
            }
        }

        private Boolean RegisterTag(string tagText)
        {
            // Create a panel to hold the label and remove button
            Panel panel = new Panel();
            panel.BackColor = Color.LightGray;
            panel.Margin = new Padding(3);
            panel.Height = controlHeight; // Adjust the height as needed

            // Create a label for the tag text
            Label label = new Label();
            label.Text = tagText;
            label.AutoSize = true;
            label.Dock = DockStyle.Left;

            // Create a button for removing the tag
            Button removeButton = new Button();
            removeButton.Text = "X";
            removeButton.BackColor = Color.Red;
            removeButton.ForeColor = Color.White;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Dock = DockStyle.Right;
            removeButton.Font = new Font(removeButton.Font.FontFamily, 6, FontStyle.Regular); // Adjust font size
            removeButton.Width = 20; // Adjust the width as needed
            removeButton.Height = controlHeight + 2;

            // Define the click event for the remove button
            removeButton.Click += (s, args) =>
            {
                // Handle tag removal logic here (e.g., deleting the tag from the database)
                // ...

                // Remove the panel from the flowLayoutPanelTags
                flowLayoutPanelTags.Controls.Remove(panel);

                // Remove the tag text from the letterTags list
                letterTags.Remove(label.Text);
            };

            // Add label and remove button to the panel
            panel.Controls.Add(label);
            panel.Controls.Add(removeButton);
            panel.Width = label.Width + controlHeight;

            // Calculate the X position for the panel
            int xPosition = 0;
            foreach (var tagItem in tagItems)
            {
                xPosition += tagItem.Panel.Width + tagItem.Panel.Margin.Left + tagItem.Panel.Margin.Right;
            }

            // Set the location of the panel
            panel.Location = new Point(xPosition, 0);

            // Add the panel to the FlowLayoutPanel
            flowLayoutPanelTags.Controls.Add(panel);

            // Add the tag text to the letterTags list
            letterTags.Add(tagText);

            // Clear the text box
            txtBoxTags.Clear();

            return true;
        }

        private void txtBoxTags_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBoxTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            //setting the e.Handled to true removes the 'ding' sound
            e.Handled = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = RegisterTag(txtBoxTags.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (letterController.UpdateLetter(labelLetterId.Text, txtBoxTitle.Text, comboBoxType.Text,
                txtBoxDescription.Text, letterTags, txtBoxTo.Text, txtBoxFrom.Text, comboBoxAction.Text, imageDictionary, dateTimePicker1.Value.Date))
            {
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);
            }
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

                        // Check if the image is already in the imageDictionary.
                        if (!imageDictionary.ContainsKey(fileName))
                        {
                            // Load the image and add it to the ImageList with a unique key (use the file name as the key).
                            Image image = Image.FromFile(filePath);
                            imageList1.Images.Add(fileName, image);

                            // Add the file name and image to the dictionary.
                            imageDictionary.Add(fileName, image);

                            // Add the file name to the ListView along with the image key.
                            ListViewItem item = new ListViewItem(fileName);
                            item.ImageKey = fileName; // Set the ImageKey to associate the image.
                            listViewLetters.Items.Add(item);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }

        private void listViewLetters_DoubleClick(object sender, EventArgs e)
        {
            if (listViewLetters.SelectedItems.Count > 0)
            {
                string selectedImageKey = listViewLetters.SelectedItems[0].ImageKey;
                if (imageDictionary.ContainsKey(selectedImageKey))
                {
                    Image selectedImage = imageDictionary[selectedImageKey];

                    // Create and show the ImageDisplayForm.
                    using (var imageDisplayView = new ImageDisplayView(selectedImage))
                    {
                        imageDisplayView.ShowDialog();
                    }
                }
            }
        }
    }
}
