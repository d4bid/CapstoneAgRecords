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
    public partial class RsbsaView : Form
    {
        private Panel parentPanel;
        private RSBSAController rsbsaController;


        public RsbsaView(Control parentControl)
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);
            this.parentPanel = parentControl as Panel;
        }

        private void RsbsaView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable rsbasaTable = rsbsaController.LoadRSBSAView();
            dgvRsbsa.DataSource = rsbasaTable;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RsbsaAddView rsbsaAddView = new RsbsaAddView();
            rsbsaAddView.FormClosed += RsbsaAddView_FormClosed;

            rsbsaAddView.TopLevel = false;
            rsbsaAddView.FormBorderStyle = FormBorderStyle.None;
            rsbsaAddView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaAddView);
            rsbsaAddView.Show();
        }

        // Methods

        private void RsbsaAddView_FormClosed(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(parentPanel);
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaView);
            rsbsaView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSBSAtry rsbsaTry = new RSBSAtry();
            //rsbsaTry.FormClosed += RSBSATry_FormClosed;

            rsbsaTry.TopLevel = false;
            rsbsaTry.FormBorderStyle = FormBorderStyle.None;
            rsbsaTry.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaTry);
            rsbsaTry.Show();
        }
    }
}
