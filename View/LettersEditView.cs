﻿using AgRecords.Controller;
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
        private Dictionary<string, Image> pagesDictionary = new Dictionary<string, Image>();
        private List<TagItem> tagItems = new List<TagItem>();
        private List<string> letterTags = new List<string>();
        private int controlHeight = 20;



        public LettersEditView(Letters letters, LettersPages lettersPages)
        {
            letterController = new LetterController(this);
            InitializeComponent();

            labelLetterId.Text = letters.letterId;
            txtBoxTitle.Text = letters.letterTitle;
            comboBoxType.Text = letters.letterType;
            txtBoxDescription.Text = letters.letterDescription;
            txtBoxFrom.Text = letters.letterFrom;
            txtBoxTo.Text = letters.letterTo;

            //to restore tags
            string[] tagsArray = letters.letterTags.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string tagText in tagsArray)
            {
                RegisterTag(tagText);
            }

            //to restore photos
            foreach (var kvp in lettersPages.imageDictionary)
            {
                string fileName = kvp.Key;
                Image image = kvp.Value;

                // Check if the image is already in the imageList1
                if (!imageList1.Images.ContainsKey(fileName))
                {
                    imageList1.Images.Add(fileName, image);
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

                // Store the key-value pair in your pagesDictionary
                if (!pagesDictionary.ContainsKey(fileName))
                {
                    pagesDictionary.Add(fileName, image);
                }
                else
                {
                    // If the key already exists, update the value (image)
                    pagesDictionary[fileName] = image;
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
                if (pagesDictionary.ContainsKey(fileName))
                {
                    Image removedImage = pagesDictionary[fileName];
                    removedImage.Dispose(); // Dispose of the image to free up resources.
                    pagesDictionary.Remove(fileName);
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
                    if (pagesDictionary.ContainsKey(fileName))
                    {
                        Image removedImage = pagesDictionary[fileName];
                        removedImage.Dispose(); // Dispose of the image to free up resources.
                        pagesDictionary.Remove(fileName);
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
                e.Handled = RegisterTag(txtBoxTags.Text.Trim());
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
    }
}