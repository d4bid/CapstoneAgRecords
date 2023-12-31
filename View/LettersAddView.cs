﻿using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AgRecords.View
{
    public partial class LettersAddView : Form
    {
        private LetterController letterController;
        private List<TagItem> tagItems = new List<TagItem>();
        private Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>();
        public event EventHandler FormClosed;

        private int imageCounter = 1;

        public LettersAddView()
        {
            InitializeComponent();
            letterController = new LetterController(this);

        }

        private void LettersAddView_Load(object sender, EventArgs e)
        {
            formRefresh();

            HomeView.Instance.title.Text = "Letters \u23F5 Edit Letter";

            comboBoxAction.SelectedIndex = 0;
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
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

        private Boolean registerTag()
        {
            string tagText = txtBoxTags.Text.Trim();
            int controlHeight = 25;

            if (!string.IsNullOrEmpty(tagText))
            {
                // Create a panel to hold the label and remove button
                Panel panel = new Panel();
                panel.BackColor = Color.FromArgb(239, 239, 239);
                panel.Margin = new Padding(10);
                panel.Height = controlHeight; // Adjust the height as needed

                // Create a label for the tag text
                Label label = new Label();
                label.Text = tagText;
                label.AutoSize = true;
                label.Dock = DockStyle.Left;
                label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
                //label.TextAlign = ContentAlignment.MiddleLeft;

                // Create a button for removing the tag
                Button removeButton = new Button();
                removeButton.Text = "X";
                removeButton.BackColor = Color.FromArgb(207, 92, 96);
                removeButton.ForeColor = Color.White;
                removeButton.FlatStyle = FlatStyle.Flat;
                removeButton.Dock = DockStyle.Right;
                removeButton.Font = new Font(removeButton.Font.FontFamily, 6, FontStyle.Regular); // Adjust font size
                removeButton.Width = 20; // Adjust the width as needed
                removeButton.Height = controlHeight + 2;

                // Define the click event for the remove button
                removeButton.Click += (s, args) =>
                {
                    // Find the TagItem associated with the panel and remove it
                    TagItem itemToRemove = tagItems.FirstOrDefault(item => item.Panel == panel);
                    if (itemToRemove != null)
                    {
                        tagItems.Remove(itemToRemove);
                        flowLayoutPanelTags.Controls.Remove(panel);
                    }
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

                // Create a TagItem instance and add it to the list
                TagItem newTagItem = new TagItem
                {
                    Text = tagText,
                    Panel = panel
                };
                tagItems.Add(newTagItem);

                // Add the panel to the FlowLayoutPanel
                flowLayoutPanelTags.Controls.Add(panel);

                // Clear the text box
                txtBoxTags.Clear();
            }
            return true;
        }

        public void formRefresh()
        {
            //set initial value of combobox
            comboBoxType.SelectedIndex = 0;

            //generate new letterId
            letterController.GenerateNewLetterID();

            dtpDateReceived.Value = DateTime.Today;

        }

        public void GenerateNewLetterId(string letterId)
        {
            labelLetterId.Text = letterId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (letterController.AddLetter(labelLetterId.Text, txtBoxTitle.Text, comboBoxType.Text,
                txtBoxDescription.Text, tagItems, txtBoxTo.Text, txtBoxFrom.Text, comboBoxAction.Text, imageDictionary, dtpDateReceived.Value.Date))
            {
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);
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

        private void txtBoxTags_KeyPress(object sender, KeyPressEventArgs e)
        {
            //setting the e.Handled to true removes the 'ding' sound
            e.Handled = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = registerTag();
            }
        }

        //restrict accepted textbox input
        private void AlphaNum(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlpaNumeric(sender, e);
        }
        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlphaOnly(sender, e);
        }
        //convert all Alpabets to Uppercase in textbox
        private void AllCaps(object sender, EventArgs e)
        {
            TextboxValidation.TextBox_AllCaps(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<ListViewItem> removedItems = new List<ListViewItem>();

            // Find and remove the selected items from the ListView and imageDictionary.
            foreach (ListViewItem item in listViewLetters.SelectedItems)
            {
                // Get the file name of the removed item.
                string fileName = item.Text;

                // Remove the item from the ListView.
                removedItems.Add(item);

                // Remove the corresponding image from imageDictionary.
                if (imageDictionary.ContainsKey(fileName))
                {
                    Image removedImage = imageDictionary[fileName];
                    removedImage.Dispose(); // Dispose of the image to free up resources.
                    imageDictionary.Remove(fileName);
                }
            }

            // Remove the selected items from the ListView.
            foreach (var removedItem in removedItems)
            {
                listViewLetters.Items.Remove(removedItem);
            }

            // Renumber the remaining images in the ListView based on their current order.
            int imageCounter = 1;
            foreach (ListViewItem item in listViewLetters.Items)
            {
                string currentFileName = item.Text;
                string[] parts = currentFileName.Split('-');
                string newFileName = $"{labelLetterId.Text}-{imageCounter}";

                if (currentFileName != newFileName)
                {
                    // Update the file name in the ListView and imageDictionary.
                    item.Text = newFileName;
                    item.ImageKey = newFileName;
                    imageDictionary[newFileName] = imageDictionary[currentFileName];

                    // Remove the old file name from the imageDictionary.
                    imageDictionary.Remove(currentFileName);
                }

                imageCounter++;
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

                    // Get the current image file names in the ListView.
                    List<string> existingImageFileNames = listViewLetters.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();

                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Generate a new file name with the format "[existingID]-XX" where XX is the next available number.
                        string newFileName = $"{labelLetterId.Text}-{GetNextImageNumber(existingImageFileNames)}";

                        // Check if the image is already in the imageDictionary.
                        if (!imageDictionary.ContainsKey(newFileName))
                        {
                            // Load the image and add it to the ImageList with the new file name as the key.
                            Image image = Image.FromFile(filePath);
                            imageList1.Images.Add(newFileName, image);

                            // Add the new file name and image to the dictionary.
                            imageDictionary.Add(newFileName, image);

                            // Add the new file name to the ListView along with the new image key.
                            ListViewItem item = new ListViewItem(newFileName);
                            item.ImageKey = newFileName; // Set the ImageKey to associate the image.
                            listViewLetters.Items.Add(item);

                            // Add the new file name to the list of existing image file names.
                            existingImageFileNames.Add(newFileName);
                        }
                        else
                        {
                            // Add potential duplicate file name to the list.
                            potentialDuplicates.Add(newFileName);
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

        private int GetNextImageNumber(List<string> existingImageFileNames)
        {
            int nextNumber = 1;

            // Find the next available image number.
            while (existingImageFileNames.Contains($"{labelLetterId.Text}-{nextNumber}"))
            {
                nextNumber++;
            }

            return nextNumber;
        }
    }
}