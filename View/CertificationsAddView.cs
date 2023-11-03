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
        //to get the username of the current user
        private string username = HomeView.Instance.username.Text;

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
            certController = new CertificationsController(this);
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

                    // Create a string with the desired format for farmInfo
                    string farmInfoText = $"{prefix} {farmInfo}";

                    // Use regular expressions to replace the last comma with "and" if there are more than two commas
                    if (Regex.Matches(farmInfoText, ",").Count > 1)
                    {
                        int lastCommaIndex = farmInfoText.LastIndexOf(",");
                        farmInfoText = farmInfoText.Substring(0, lastCommaIndex) + " and" + farmInfoText.Substring(lastCommaIndex + 1);
                    }

                    // Split the address into words
                    string[] words2 = farmAddress.Split(' ');

                    // Initialize a TextInfo object for the current culture
                    TextInfo textInfo2 = CultureInfo.CurrentCulture.TextInfo;

                    // Capitalize the first letter of each word, preserving acronyms
                    for (int i = 0; i < words2.Length; i++)
                    {
                        if (!words2[i].Contains(".") || words2[i].Length == 1)
                        {
                            words2[i] = textInfo.ToTitleCase(words2[i].ToLower());
                        }
                    }

                    // Rejoin the words to form the updated address
                    farmAddress = string.Join(" ", words2);

                    // Add farmAddress to the formatted farmInfo
                    farmInfoText += $" located at Barangay {farmAddress}";


                    // Add the farm info text to the list
                    farmInfoList.Add(farmInfoText);
                }
            }

            string combinedFarmInfo = string.Empty;

            if (farmInfoList.Count > 0)
            {
                if (farmInfoList.Count == 1)
                {
                    combinedFarmInfo = farmInfoList[0];
                }
                else if (farmInfoList.Count == 2)
                {
                    combinedFarmInfo = string.Join(" and ", farmInfoList);
                }
                else
                {
                    combinedFarmInfo = string.Join(", ", farmInfoList.Take(farmInfoList.Count - 1)) + ", and " + farmInfoList.Last();
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
                        day = dayValue + "ⁿᵈ";
                        break;
                    case 3:
                        day = dayValue + "ʳᵈ";
                        break;
                    default:
                        day = dayValue + "ᵗʰ";
                        break;
                }
            }

            // Format Date (e.g., October 10, 2023)
            string date = currentDate.ToString("MMMM dd, yyyy");


            Certifications cert = certController.GetEmployeeInfoByUsername(username);
            string empName = cert.employeeName;
            string empPosition = cert.employeePosition;
            string head = cert.headName;

            // Perform the replacements
            FindAndReplace(doc, "<<name>>", farmerName);
            FindAndReplace(doc, "<<barangay>>", farmerAddress);
            FindAndReplace(doc, "<<monthYear>>", monthYear);
            FindAndReplace(doc, "<<day>>", day);
            FindAndReplace(doc, "<<orNo>>", orNumber);
            FindAndReplace(doc, "<<referenceNumber>>", referenceNumber);
            FindAndReplace(doc, "<<date>>", date);
            FindAndReplace(doc, "<<employeePosition>>", empPosition);
            FindAndReplace(doc, "<<employeeName>>", empName);
            FindAndReplace(doc, "<<headName>>", head);
            FindAndReplace(doc, "<<date>>", date);

            //foreach (string farmInfo in farmInfoList)
            //{
            //    FindAndReplace(doc, "<<farmInfo>>", farmInfo);
            //}

            FindAndReplace(doc, "<<farmInfo>>", combinedFarmInfo);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
