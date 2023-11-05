
using AgRecords.Model;
using AgRecords.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.Controller
{
    public class CertificationsController
    {
        private CertificationsAddView certAddView;
        private CertificationsView certView;

        private CertificationsModel certModel;

        UserModel userModel = new UserModel();
        private Boolean isDone = false;

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public CertificationsController(CertificationsAddView certAddView)
        {
            this.certAddView = certAddView;
            certModel = new CertificationsModel();
        }

        public CertificationsController(CertificationsView certView)
        {
            this.certView = certView;
            certModel = new CertificationsModel();
        }

        public Certifications GetEmployeeInfoByUsername(string username)
        {
            try
            {
                return certModel.GetEmployeeInfoByUsername(username);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Username Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        // Get createdBy
        public string GetUserIdByFullName(string fullName)
        {
            try
            {
                return userModel.FindUserIDByFullName(fullName);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding User ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        // Generate ID
        public void GenerateNewCertID()
        {
            try
            {
                certAddView.GenerateNewCertId(certModel.GenerateNextCertId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable LoadFarmerView()
        {
            try
            {
                DataTable certTable = certModel.GetFarmerInfo();
                return certTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Farmers Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public Certifications GetFarmerInfoById(string rsbsaId)
        {
            try
            {
                return certModel.GetFarmerInfoById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public List<Certifications> GetCertCommodities(string rsbsaId)
        {
            try
            {
                return certModel.GetCertCommodities(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Certificate Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable GetEmployees()
        {
            try
            {
                return certModel.GetEmployees();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Employees Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public bool AddCertificate(string orNo, string referenceNumber, string name, string farmerAddress, DateTime date, string employeeName, string headName, string position)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                Certifications cert = new Certifications()
                {
                    orderNumber = orNo,
                    rsbsaIdLGU = referenceNumber,
                    name = name,
                    barangay = farmerAddress,
                    date = date,
                    employeeName = employeeName,
                    headName = headName
                };

                if (cert.rsbsaIdLGU == "")
                {
                    MessageBox.Show("Reference Number is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cert.orderNumber == "")
                {
                    MessageBox.Show("O.R. No. is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cert.name == "")
                {
                    MessageBox.Show("Farmer's name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cert.barangay == "")
                {
                    MessageBox.Show("Farmer's Address is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cert.employeeName == "")
                {
                    MessageBox.Show("Agricultural Technologist/Agriculturist's name is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (position == "")
                {
                    MessageBox.Show("Employee's Position is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cert.rsbsaIdLGU != "" && cert.orderNumber != "" && cert.name != "" && cert.barangay != "" && cert.employeeName != "" && cert.farmLocBrgy != "" && position != "")
                {
                    if (certModel.AddCertificate(cert))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Standing Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userModel.InserActionLog(username, "Generate", "Certificate", $"{referenceNumber} with O.R. No. {orNo} generated successfully.");
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Adding Certification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Generate", "Certificate", $"{referenceNumber} with O.R. No. {orNo} generation failed.");
                return false;
            }
        }

        public bool AddCertFarmInfo(Certifications cert)
        {
            try
            {
                bool isDone = false;

                if (string.IsNullOrEmpty(cert.farmParcelNo))
                {
                    MessageBox.Show("Farm Parcel Number is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(cert.orderNumber))
                {
                    MessageBox.Show("O.R. No. is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(cert.farmInfo))
                {
                    MessageBox.Show("Farm Info is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(cert.farmLocBrgy))
                {
                    MessageBox.Show("Farm Location Brgy is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // All required fields are filled, so attempt to add farm data
                    if (certModel.AddFarmInfo(new List<Certifications> { cert }))
                    {
                        isDone = true;
                        // You can perform further actions if the addition is successful
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Generating Certification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool AddFarmInfo(List<Certifications> farmDataList)
        {
            try
            {
                bool isDone = false;

                // Perform validation on the farmDataList here, if necessary

                // Call the AddFarmInfo method in the model
                if (certModel.AddFarmInfo(farmDataList))
                {
                    isDone = true;
                    // You can perform further actions if the addition is successful
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Adding Certification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public DataTable LoadCertificatesByRsbsaNumberView(string refNumber)
        {
            try
            {
                DataTable certTable = certModel.LoadCertificationsByRsbsaNumberDataGrid(refNumber);
                return certTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Certificate Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
