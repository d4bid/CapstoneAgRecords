using AgRecords.Controller;
using AgRecords.Model;
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
        private CertificationsController certController;
        public event EventHandler FormClosed;

        public CertificationsAddView(Certifications cert)
        {
            InitializeComponent();

            labelRsbsaId.Text = cert.rsbsaId;
            txtReferenceNumber.Text = cert.refNumber;
            txtName.Text = cert.name;
            txtBarangay.Text = cert.barangay;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void txtFarmBarangay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void rectangleRound5_Load(object sender, EventArgs e)
        {
        }
    }
}
