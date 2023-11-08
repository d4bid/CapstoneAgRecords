using AgRecords.Controller;
using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class RSBSADocumentControl : UserControl
    {
        // Declare the event
        private RSBSAController rsbsaController;
        public event EventHandler RemoveButtonClick;
        private string rsbsaId = "";
        private string filename = "";
        private Image selectedImage = null;

        public RSBSADocumentControl()
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

            // Wire up the remove button click event
            cbDocType.SelectedIndex = 0;
            //btnRemove.Click += btnRemove_Click;
            pbDocPhoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void RSBSADocumentControl_Load(object sender, EventArgs e)
        {

        }

        public void SetData(RSBSADocuments docs)
        {
            cbDocType.Text = docs.docType;

            foreach (var kvp in docs.docPhotoDictionary)
            {
                if (docs.docFilename.Equals(kvp.Key))
                {
                    filename = kvp.Key;
                    selectedImage = kvp.Value;

                    pbDocPhoto.Image = selectedImage;
                }
                break;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Raise the custom event when the remove button is clicked
            RemoveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = Path.GetFileName(openFileDialog.FileName);
                    selectedImage = Image.FromFile(openFileDialog.FileName);

                    // Display the selected image in pbDocPhoto
                    pbDocPhoto.Image = selectedImage;
                }
            }
        }

        public RSBSADocuments GetDocumentData(string rsbsaId)
        {
            RSBSADocuments document = new RSBSADocuments
            {
                rsbsaId = rsbsaId, // Set rsbsaId as per your logic
                docType = cbDocType.Text,
                docPhotoDictionary = new Dictionary<string, Image>()
            };

            if (selectedImage != null && !string.IsNullOrEmpty(filename))
            {
                // Add the image to the dictionary with the filename as the key
                document.docPhotoDictionary.Add(filename, selectedImage);
            }

            return document;
        }

        private void pbDocPhoto_Click(object sender, EventArgs e)
        {

        }

        private void pbDocPhoto_DoubleClick(object sender, EventArgs e)
        {
            if (pbDocPhoto.Image != null)
            {
                // Create and show the ImageDisplayForm.
                using (var imageDisplayView = new ImageDisplayView(pbDocPhoto.Image))
                {
                    imageDisplayView.ShowDialog();
                }
            }
        }
    }
}
