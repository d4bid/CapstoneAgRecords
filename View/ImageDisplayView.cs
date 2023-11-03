using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class ImageDisplayView : Form
    {
        private Image displayedImage;

        public ImageDisplayView(Image selectedImage)
        {
            InitializeComponent();
            displayedImage = selectedImage;
            pictureBox1.Image = displayedImage;

        }

        private void ImageDisplayView_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Show a PrintDialog to allow the user to choose a printer
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected printer and start printing
                printDocument1.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Show a PrintDialog to allow the user to choose a printer
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected printer and start printing
                printDocument1.PrinterSettings = printDialog.PrinterSettings;
                printDocument1.Print();
            }
        }
    }
}