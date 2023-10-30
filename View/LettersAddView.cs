using AgRecords.Controller;
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
            DateTime minDate = new DateTime(1900, 1, 1);
            dtpDateReceived.MaxDate = DateTime.Today;
            dtpDateReceived.MinDate = minDate;
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
                        // Get the file name without extension.
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);

                        // Generate a new file name with the format "[existingID]-XX" where XX is the imageCounter.
                        string newFileName = $"{labelLetterId.Text}-{imageCounter:D2}";
                        imageCounter++; // Increment the counter for the next image.

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
            int controlHeight = 20;

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
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlpaNumeric(sender, e);
        }
        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlphaOnly(sender, e);
        }
        //convert all Alpabets to Uppercase in textbox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextboxValidation.TextBox_AllCaps(sender, e);
        }
    }
}