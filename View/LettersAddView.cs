using AgRecords.Controller;
using AgRecords.Model;
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
        private List<TagItem> tagItems = new List<TagItem>();

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
                            listViewLetters.Items.Add(item);

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
            foreach (ListViewItem item in listViewLetters.SelectedItems)
            {
                // Get the file name of the removed item.
                string fileName = item.Text;

                // Remove the item from the ListView.
                listViewLetters.Items.Remove(item);

                // Remove the corresponding entry from addedImages.
                addedImages.Remove(fileName);

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

                    // Remove the corresponding entry from addedImages.
                    addedImages.Remove(fileName);

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

        private Boolean registerTag()
        {
            string tagText = txtBoxTags.Text.Trim();
            int controlHeight = 20;

            if (!string.IsNullOrEmpty(tagText))
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
                label.TextAlign = ContentAlignment.MiddleCenter;

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

    }
}
