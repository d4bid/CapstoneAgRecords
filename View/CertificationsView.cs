using AgRecords.Controller;
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
        private RSBSAController rsbsaController;

        public CertificationsView(Control parentControl)
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);
            this.parentPanel = parentControl as Panel;
        }

        private void CertificationsView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable rsbasaTable = rsbsaController.LoadRSBSAView();
            dgvCert.DataSource = rsbasaTable;

        }
    }
}
