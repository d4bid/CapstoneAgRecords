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
    public partial class CertificationsView : Form
    {
        private Panel parentPanel;
        private CertificationsController certController;

        public CertificationsView(Control parentControl)
        {
            InitializeComponent();
            certController = new CertificationsController(this);
            this.parentPanel = parentControl as Panel;
        }

        // Methods

        private void CertificationsAddView_FormClosed(object sender, EventArgs e)
        {
            CertificationsView certificationsView = new CertificationsView(parentPanel);
            certificationsView.TopLevel = false;
            certificationsView.FormBorderStyle = FormBorderStyle.None;
            certificationsView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(certificationsView);
            certificationsView.Show();
        }

        // Events

        private void CertificationsView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable certTable = certController.LoadFarmerView();
            dgvCert.DataSource = certTable;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //CertificationsAddView certificationsAddView = new CertificationsAddView();
            //certificationsAddView.FormClosed += CertificationsAddView_FormClosed;
            //certificationsAddView.TopLevel = false;
            //certificationsAddView.FormBorderStyle = FormBorderStyle.None;
            //certificationsAddView.Dock = DockStyle.Fill;

            //parentPanel.Controls.Clear();
            //parentPanel.Controls.Add(certificationsAddView);
            //certificationsAddView.Show();
        }

        private void dgvCert_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvCert.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string rsbsaId = row.Cells[0].Value.ToString();

                if (rsbsaId != null)
                {
                    Certifications cert = certController.GetFarmerInfoById(rsbsaId);

                    CertificationsAddView certificationsAddView = new CertificationsAddView(cert);
                    certificationsAddView.FormClosed += CertificationsAddView_FormClosed;
                    certificationsAddView.TopLevel = false;
                    certificationsAddView.FormBorderStyle = FormBorderStyle.None;
                    certificationsAddView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(certificationsAddView);
                    certificationsAddView.Show();
                }
            }
        }
    }
}
