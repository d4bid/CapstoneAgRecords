
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
    }
}
