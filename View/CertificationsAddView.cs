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
    public partial class CertificationsAddView : Form
    {
        public CertificationsAddView()
        {
            InitializeComponent();
        }

        private string GetSuperscript(int day)
        {
            if (day >= 11 && day <= 13)
            {
                return "ᵗʰ";
            }
            switch (day % 10)
            {
                case 1:
                    return "ˢᵗ";
                case 2:
                    return "ⁿᵈ";
                case 3:
                    return "ʳᵈ";
                default:
                    return "ᵗʰ";
            }
        }

        //private string GenerateCertificationText()
        //{
        //    int day = DateTime.Now.Day;
        //    int currentMonth = DateTime.Now.Month;
        //    int currentYear = DateTime.Now.Year;
        //    DateTime currentDate = DateTime.Now;
        //    string formattedDate = currentDate.ToString("MMMM dd, yyyy");

        //    string dayWithSuperscript = day.ToString() + GetSuperscript(day);

        //    // Replace placeholders with values from TextBox controls
        //    string certificationText = "CERTIFICATION\n\n" +
        //        "TO WHOM IT MAY CONCERN:\n\n" +
        //        "     THIS IS TO CERTIFY that " + txtName.Text + " of Barangay " + txtBarangay.Text + ", Solano, Nueva Vizcaya is a bonafide farmer as per masterlist filed in this office.\n\n" +
        //        "Certified further that " + txtName.Text + " is the actual farmer tiller of an area of " + txtFarmInfo.Text + " more or less located at Barangay " + txtBarangay.Text + ", Solano Nueva Vizcaya and was registered in the Registry System for Basic Sector in Agriculture (RSBSA), REFERENCE Code Number: " + txtReferenceNumber.Text + "\n\n" +
        //        "     This certification is issued upon the request of " + txtName.Text + " for whatever legal purpose it may serve him best.\n\n" +
        //        "Issued this " + dayWithSuperscript + " day of " + currentMonth + " " + currentYear + " at Solano, Nueva Vizcaya.\n" +
        //        "                                                              " + new string(' ', 3) + new string('\t', 3) + new string(' ', 5) + "*EMPLOYEE NAME*\n" +
        //        "                                                                                      " + "*Position*\n" +
        //        "Noted:\n\n" +
        //        "   " + new string(' ', 2) + "SHIRLEY S. LUMICAO\n" +
        //        "   " + new string(' ', 2) + "Municipal Agriculturist\n\n" +
        //        "O.R. No. " + txtOrNo.Text + "\n" +
        //        "Date: " + formattedDate + "\n" +
        //        "Amount Paid: 50.00";

        //    // Return the generated certification text
        //    return certificationText;
        //}

        private string GenerateCertificationText()
        {
            // Create a rich text formatted string with placeholders
            string certificationText = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033
            {\fonttbl{\f0\fnil\fcharset0 Arial;}}
            {\colortbl ;\red0\green0\blue0;}
            \viewkind4\uc1\pard\cf1\b\f1\fs24\qc CERTIFICATION\par
            \par
            \b0\fs12\ql TO WHOM IT MAY CONCERN:\par
            \par
            \ql THIS IS TO CERTIFY that \ul\b *NAME* \ulnone\b0 of Barangay *BARANGAY*, Solano, Nueva Vizcaya is a bonafide farmer as per masterlist filed in this office.\par
            \par
            \ql Certified further that \ul\b *NAME* \ulnone\b0 is the actual farmer tiller of an area of *hectare* hectares *field* more or less located at Barangay *BARANGAY*, Solano Nueva Vizcaya and was registered in the Registry System for Basic Sector in Agriculture (RSBSA), REFERENCE Code Number: \b *REFERENCE NUMBER* \b0\par
            \par
            \ql This certification is issued upon the request of \ul\b *NAME* \ulnone\b0 for whatever legal purpose it may serve him best.\par
            \par
            \ql Issued this *DAY* day of *MONTH YEAR* at Solano, Nueva Vizcaya.\par
            \ql \tab \tab \tab \tab *EMPLOYEE NAME*\par
            \ql \tab \tab \tab \tab *Position*\par
            \par
            \ql Noted:\par
            \par
            \ql \tab SHIRLEY S. LUMICAO\par
            \ql \tab Municipal Agriculturist\par
            \par
            O.R. No. \b *ORNO* \b0\par
            Date: \b *DATE* \b0\par
            Amount Paid: \b 50.00 \b0\par
            }";

            // Replace placeholders with actual data
            certificationText = certificationText.Replace("*NAME*", txtName.Text);
            certificationText = certificationText.Replace("*BARANGAY*", txtBarangay.Text);
            certificationText = certificationText.Replace("*REFERENCE NUMBER*", txtReferenceNumber.Text);
            certificationText = certificationText.Replace("*ORNO*", txtOrNo.Text);

            return certificationText;
        }

        private void CertificationsAddView_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a RichTextBox to format the certification text
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Rtf = GenerateCertificationText();

            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Set print settings (page size and margins)
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Letter", 850, 1100);
            printDocument.DefaultPageSettings.Margins = new Margins(100, 100, 100, 100);

            // Set the PrintPreviewDialog to use the PrintDocument
            printPreviewDialog.Document = printDocument;

            // Display the print preview
            printPreviewDialog.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Font font = new Font("Arial", 12))
            using (SolidBrush brush = new SolidBrush(Color.Black))
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                float lineHeight = font.GetHeight();
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                // Generate and draw the certification text
                string certificationText = GenerateCertificationText();

                // Create a rich text box to handle formatting
                using (RichTextBox richTextBox = new RichTextBox())
                {
                    richTextBox.Rtf = certificationText;
                    string plainText = richTextBox.Text;

                    g.DrawString(plainText, font, brush, e.MarginBounds, format);
                }
            }
        }
    }
}
