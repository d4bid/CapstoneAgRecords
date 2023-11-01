using AgRecords.Controller;
using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;
using System.Globalization;

namespace AgRecords.View
{
    public partial class CertificationsAddView : Form
    {
        private CertificationsController certController;
        public event EventHandler FormClosed;
        private List<string> setCertDataList = new List<string>();

        public CertificationsAddView(Certifications cert, List<Certifications> certList)
        {
            InitializeComponent();

            labelRsbsaId.Text = cert.rsbsaId;
            txtReferenceNumber.Text = cert.rsbsaIdLGU;
            txtName.Text = cert.name;
            txtBarangay.Text = cert.barangay;
            lblTempParcelCount.Text = cert.farmParcelCount.ToString();

            if (certList != null)
            {
                for (int i = 0; i < cert.farmParcelCount; i++)
                {
                    CertificationsFarmControl certificationsFarmControl = new CertificationsFarmControl();
                    certificationsFarmControl.SetData(certList[i]);
                    certificationsFarmControl.RemoveButtonClick += CertificationsFarmControl_RemoveButtonClick;
                    flowLayoutPanel1.Controls.Add(certificationsFarmControl);
                }
            }

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

        public void GenerateNewCertId(string certId)
        {
            //labelCornPrId.Text = certId;
        }

        private void CertificationsAddView_Load(object sender, EventArgs e)
        {

        }

        private void CertificationsFarmControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (sender is CertificationsFarmControl certificationsFarmControl)
            {
                // Remove the documentControl from the flowLayoutPanelDocs
                flowLayoutPanel1.Controls.Remove(certificationsFarmControl);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Get the base directory of the project
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the relative path to your Word document
            string documentPath = System.IO.Path.Combine(baseDirectory, "Templates", "Certification.docx");

            // Load the Word document
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = wordApp.Documents.Open(documentPath);

            // Replace placeholders with form values
            string referenceNumber = txtReferenceNumber.Text;
            string orNumber = txtOrNo.Text;
            string farmerName = txtName.Text;
            string farmerAddress = txtBarangay.Text;

            // Split the address into words
            string[] words = farmerAddress.Split(' ');

            // Initialize a TextInfo object for the current culture
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            // Capitalize the first letter of each word, preserving acronyms
            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Contains(".") || words[i].Length == 1)
                {
                    words[i] = textInfo.ToTitleCase(words[i].ToLower());
                }
            }

            // Rejoin the words to form the updated address
            farmerAddress = string.Join(" ", words);

            // Initialize a list to store the farm info from each CertificationsFarmControl
            List<string> farmInfoList = new List<string>();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is CertificationsFarmControl certFarmControl)
                {
                    string farmInfo = certFarmControl.txtFarmInfo.Text;
                    string farmAddress = certFarmControl.txtFarmAddress.Text;
                    string farmBarangay = certFarmControl.labelParcelNo.Text;

                    // Check if specific words are present in farmInfo and set the prefix accordingly
                    string prefix = "actual farm tiller of";

                    if (farmInfo.Contains("corn") || farmInfo.Contains("rice") || farmInfo.Contains("HVC"))
                    {
                        prefix = "farm tiller of";
                    }
                    else if (farmInfo.Contains("fish grower"))
                    {
                        prefix = "actual";
                    }
                    else if (farmInfo.Contains("heads"))
                    {
                        prefix = "Livestock grower";
                    }

                    // Create a string with the desired format
                    string farmInfoText = $"{prefix} {farmInfo} located at {farmAddress}";

                    // Use regular expressions to replace the last comma with "and" if there are more than two commas
                    if (Regex.Matches(farmInfoText, ",").Count > 1)
                    {
                        int lastCommaIndex = farmInfoText.LastIndexOf(",");
                        farmInfoText = farmInfoText.Substring(0, lastCommaIndex) + " and" + farmInfoText.Substring(lastCommaIndex + 1);
                    }

                    // Add the farm info text to the list
                    farmInfoList.Add(farmInfoText);
                }
            }

            DateTime currentDate = DateTime.Now;

            // Format Month Year (e.g., October 2023)
            string monthYear = currentDate.ToString("MMMM yyyy");

            // Format Day with superscript (e.g., 2nd, 3rd)
            int dayValue = currentDate.Day;
            string day;
            if (dayValue >= 11 && dayValue <= 13)
            {
                day = dayValue + "ᵗʰ";
            }
            else
            {
                switch (dayValue % 10)
                {
                    case 1:
                        day = dayValue + "ˢᵗ";
                        break;
                    case 2:
                        day = dayValue + "nd";
                        break;
                    case 3:
                        day = dayValue + "rd";
                        break;
                    default:
                        day = dayValue + "th";
                        break;
                }
            }

            // Format Date (e.g., October 10, 2023)
            string date = currentDate.ToString("MMMM dd, yyyy");

            // Perform the replacements
            FindAndReplace(doc, "<<name>>", farmerName);
            FindAndReplace(doc, "<<barangay>>", farmerAddress);
            FindAndReplace(doc, "<<monthYear>>", monthYear);
            FindAndReplace(doc, "<<day>>", day);
            FindAndReplace(doc, "<<orNo>>", orNumber);
            FindAndReplace(doc, "<<referenceNumber>>", referenceNumber);
            FindAndReplace(doc, "<<date>>", date);

            foreach (string farmInfo in farmInfoList)
            {
                FindAndReplace(doc, "<<farmInfo>>", farmInfo);
            }

            // Clean up
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wordApp);
        }

        private void FindAndReplace(Document doc, string findText, string replaceText)
        {
            foreach (Microsoft.Office.Interop.Word.Range range in doc.StoryRanges)
            {
                range.Find.Execute(FindText: findText, ReplaceWith: replaceText, Replace: WdReplace.wdReplaceAll);
            }
        }
    }
}
