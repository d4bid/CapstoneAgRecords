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
using OxyPlot;
using MySqlX.XDevAPI.Relational;
using AgRecords.Utilities;
using Org.BouncyCastle.Asn1.X509;

namespace AgRecords.View
{
    public partial class CertificationsAddView : Form
    {
        private CertificationsController certController;
        public event EventHandler FormClosed;
        private List<string> setCertDataList = new List<string>();
        //to get the username of the current user
        private string username = HomeView.Instance.username.Text;

        private int click;

        public CertificationsAddView(Certifications cert, List<Certifications> certList)
        {
            InitializeComponent();

            labelRsbsaId.Text = cert.rsbsaId;
            txtReferenceNumber.Text = cert.rsbsaIdLGU;
            txtName.Text = cert.name;
            lblSex.Text = cert.sex;
            txtBarangay.Text = cert.barangay;
            lblTempParcelCount.Text = cert.farmParcelCount.ToString();

            if (certList != null)
            {
                for (int i = 0; i < certList.Count; i++)
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
            HomeView.Instance.title.Text = "Certifications \u23F5 Add Certification";

            // Call the GetEmployees method from your controller
            System.Data.DataTable employeeTable = certController.GetEmployees();

            if (employeeTable != null && employeeTable.Rows.Count > 0)
            {
                // Data is available, populate the ComboBox
                cmbEmployee.DataSource = employeeTable;
                cmbEmployee.DisplayMember = "Employee";
                cmbEmployee.ValueMember = "Employee"; // You can set this to another column if needed
            }
            else
            {
                // Handle the case when there is no data
                cmbEmployee.Items.Add("");
            }

            System.Data.DataTable certTable = certController.LoadCertificatesByRsbsaNumberView(txtReferenceNumber.Text);
            dgvCert.DataSource = certTable;

            cmbPosition.SelectedIndex = 0;
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
            if (txtOrNo.Text == "" || cmbEmployee.Text == "" || cmbPosition.Text == "")
            {
                if (txtOrNo.Text == "")
                {
                    boxOrNo.Visible = false;
                }
                else
                {
                    boxOrNo.Visible = true;
                }

                if (cmbEmployee.Text == "")
                {
                    boxEmployee.Visible = false;
                }
                else
                {
                    boxEmployee.Visible = true;
                }

                if (cmbPosition.Text == "")
                {
                    boxEmployeePosition.Visible = false;
                }
                else
                {
                    boxEmployeePosition.Visible = true;
                }
            }
            else
            {
                click = 1;

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
                        string farmParcel = certFarmControl.labelParcelNo.Text;

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

                        string farmInfoText = $"{prefix} {farmInfo}";

                        // Use regular expressions to replace the last comma with "and" if there are more than two commas
                        MatchCollection commaMatches = Regex.Matches(farmInfoText, ",");
                        if (commaMatches.Count > 1)
                        {
                            int lastCommaIndex = farmInfoText.LastIndexOf(",");
                            farmInfoText = farmInfoText.Substring(0, lastCommaIndex) + " and" + farmInfoText.Substring(lastCommaIndex + 1);
                        }
                        else if (commaMatches.Count == 1)
                        {
                            // If there's only one comma, replace it with "and"
                            farmInfoText = farmInfoText.Replace(",", " and");
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
                //string empName = cert.employeeName;
                //string empPosition = cert.employeePosition;
                string head = cert.headName;

                string empName = cmbEmployee.Text;
                string empPosition = cmbPosition.Text;

                if (float.TryParse(txtAmount.Text, out float amount))
                {
                    txtAmount.Text = amount.ToString("0.00");
                }
                else
                {
                    txtAmount.Text = "0.00"; // Set the default value of "0.00" when the input is not a valid float.
                }

                string amountPaid = txtAmount.Text;

                string sex = "";

                if (lblSex.Text == "FEMALE" || lblSex.Text == "F" || lblSex.Text == "Female")
                {
                    sex = "her";
                }
                else
                {
                    sex = "him";
                }

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
                FindAndReplace(doc, "<<amountPaid>>", amountPaid);
                FindAndReplace(doc, "<<pronoun>>", sex);

                //foreach (string farmInfo in farmInfoList)
                //{
                //    FindAndReplace(doc, "<<farmInfo>>", farmInfo);
                //}

                FindAndReplace(doc, "<<farmInfo>>", combinedFarmInfo);

                // Clean up
                Marshal.ReleaseComObject(doc);
                Marshal.ReleaseComObject(wordApp);

                DialogResult result = MessageBox.Show("Do you want to continue generating certificate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    // Collect data from CertificationsFarmControl instances into a list
                    List<Certifications> farmDataList = new List<Certifications>();

                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if (control is CertificationsFarmControl certFarmControl)
                        {
                            string farmInfo = certFarmControl.txtFarmInfo.Text;
                            string farmAddress = certFarmControl.txtFarmAddress.Text;
                            string farmParcel = certFarmControl.labelParcelNo.Text;

                            Certifications cert2 = new Certifications
                            {
                                orderNumber = orNumber, // Assign the same orderNumber as the main certificate
                                farmParcelNo = farmParcel,
                                farmInfo = farmInfo,
                                farmLocBrgy = farmAddress,
                            };

                            farmDataList.Add(cert2);
                        }
                    }

                    // Call the AddCertificate method in the controller
                    if (certController.AddCertificate(orNumber, referenceNumber, farmerName, farmerAddress, DateTime.Now, empName, head, empPosition))
                    {
                        // Call the AddFarmInfo method in the controller
                        if (certController.AddFarmInfo(farmDataList))
                        {
                            this.Close();
                            FormClosed?.Invoke(this, EventArgs.Empty);
                        }
                    }
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }
            }
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

        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlphaOnly(sender, e);
        }

        private void AllCaps(object sender, EventArgs e)
        {
            TextboxValidation.TextBox_AllCaps(sender, e);
        }

        private void CertificationsAddView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //// Replace placeholders with form values
            //string referenceNumber = txtReferenceNumber.Text;
            //string orNumber = txtOrNo.Text;
            //string farmerName = txtName.Text;
            //string farmerAddress = txtBarangay.Text;

            //Certifications cert = certController.GetEmployeeInfoByUsername(username);
            ////string empName = cert.employeeName;
            ////string empPosition = cert.employeePosition;
            //string head = cert.headName;

            //string empName = cmbEmployee.Text;
            //string empPosition = cmbPosition.Text;

            //// Collect data from CertificationsFarmControl instances into a list
            //List<Certifications> farmDataList = new List<Certifications>();

            //foreach (Control control in flowLayoutPanel1.Controls)
            //{
            //    if (control is CertificationsFarmControl certFarmControl)
            //    {
            //        string farmInfo = certFarmControl.txtFarmInfo.Text;
            //        string farmAddress = certFarmControl.txtFarmAddress.Text;
            //        string farmParcel = certFarmControl.labelParcelNo.Text;

            //        Certifications cert2 = new Certifications
            //        {
            //            orderNumber = orNumber, // Assign the same orderNumber as the main certificate
            //            farmParcelNo = farmParcel,
            //            farmInfo = farmInfo,
            //            farmLocBrgy = farmAddress,
            //        };

            //        farmDataList.Add(cert2);
            //    }
            //}

            //// Call the AddCertificate method in the controller
            //if (certController.AddCertificate(orNumber, referenceNumber, farmerName, farmerAddress, DateTime.Now, empName, head, empPosition))
            //{
            //    // Call the AddFarmInfo method in the controller
            //    if (certController.AddFarmInfo(farmDataList))
            //    {
            //        this.Close();
            //        FormClosed?.Invoke(this, EventArgs.Empty);
            //    }
            //}
        }
    }
}
