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
    public partial class RsbsaView : Form
    {
        private Panel parentPanel;
        private RSBSAController rsbsaController;
        private string brgy = "";
        private string commType = "";

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
            comboBoxSearchCategory.SelectedIndex = 0;
            comboBoxFilterBrgy.SelectedIndex = 0;
            comboBoxFilterCommodity.SelectedIndex = 0;

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

        private void dgvRsbsa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRsbsa.Rows[e.RowIndex];

                string rsbsaId = row.Cells[0].Value.ToString();

                if (rsbsaId != null)
                {
                    RSBSA rsbsaInfo = rsbsaController.GetRSBSAInfoByRSBSAId(rsbsaId);
                    RSBSA farmerInfo = rsbsaController.GetFarmerInfoByRSBSAId(rsbsaId);
                    RSBSA farmProfile = rsbsaController.GetFarmProfileByRSBSAId(rsbsaId);
                    RSBSA farmland = rsbsaController.GetFarmlandByRSBSAId(rsbsaId);
                    RSBSA farmlandParcel = rsbsaController.GetFarmlandParcelsByRSBSAId(rsbsaId);
                    RSBSA farmlandParcelCrops = rsbsaController.GetFarmlandParcelCropsByRSBSAId(rsbsaId);
                    RSBSA rsbsaDocs = rsbsaController.GetDocsByRSBSAId(rsbsaId);

                    RSBSAEditView rsbsaEditView = new RSBSAEditView(rsbsaInfo, farmerInfo, farmProfile, farmland, farmlandParcel, farmlandParcelCrops, rsbsaDocs);
                    //rsbsaEditView.FormClosed += RSBSAEditView_FormClosed;

                    rsbsaEditView.TopLevel = false;
                    rsbsaEditView.FormBorderStyle = FormBorderStyle.None;
                    rsbsaEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(rsbsaEditView);
                    rsbsaEditView.Show();
                }
                else
                {
                    MessageBox.Show("Null RSBSA ID", "RSBSA is null.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            getBarangay(comboBoxFilterBrgy);
            getCommType(comboBoxFilterCommodity);
            DataTable dt = rsbsaController.SearchRSBSA(txtBoxSearch.Text, comboBoxSearchCategory.Text, brgy, commType);
            dgvRsbsa.DataSource = dt;


        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBarangay(comboBoxFilterBrgy);
            getCommType(comboBoxFilterCommodity);
            DataTable dt = rsbsaController.SearchRSBSA(txtBoxSearch.Text, comboBoxSearchCategory.Text, brgy, commType);
            dgvRsbsa.DataSource = dt;


        }

        private void comboBoxFilterBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBarangay(comboBoxFilterBrgy);
            getCommType(comboBoxFilterCommodity);
            DataTable dt = rsbsaController.SearchRSBSA(txtBoxSearch.Text, comboBoxSearchCategory.Text, brgy, commType);
            dgvRsbsa.DataSource = dt;


        }

        private void comboBoxFilterCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBarangay(comboBoxFilterBrgy);
            getCommType(comboBoxFilterCommodity);
            DataTable dt = rsbsaController.SearchRSBSA(txtBoxSearch.Text, comboBoxSearchCategory.Text, brgy, commType);
            dgvRsbsa.DataSource = dt;

        }

        public string getBarangay(ComboBox comboBox)
        {
            brgy = comboBox.Text;
            if (brgy == "ALL")
            {
                return brgy = "";
            }
            else
            {
                return brgy;
            }
        }
        public string getCommType(ComboBox comboBox)
        {
            commType = comboBox.Text;
            if (commType == "ALL")
            {
                return commType = "";
            }
            else
            {
                return commType;
            }
        }
    }
}
