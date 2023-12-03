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

        private string role = HomeView.Instance.role.Text;

        public RsbsaView(Control parentControl)
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);
            this.parentPanel = parentControl as Panel;

            comboBoxFilterBrgy.SelectedIndex = 0;
            comboBoxFilterCommodity.SelectedIndex = 0;
        }

        private void RsbsaView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            if (role == "Enumerator" || role == "Admin")
            {
                btnAdd.Visible = true;
                dgvRsbsa.CellDoubleClick += dgvRsbsa_CellDoubleClick;
            }
            else
            {
                btnAdd.Visible = false;
                dgvRsbsa.CellDoubleClick -= dgvRsbsa_CellDoubleClick;
            }
        }

        public void FormRefresh()
        {
            comboBoxSearchCategory.SelectedIndex = 0;
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

        private void RSBSAEditView_FormClosed(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(parentPanel);
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaView);
            rsbsaView.Show();
        }

        private void RSBSAImportExcelView_FormClosed(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(parentPanel);
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaView);
            rsbsaView.Show();
        }

        private void RSBSAExportView_FormClosed(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(parentPanel);
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaView);
            rsbsaView.Show();
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
                    rsbsaEditView.FormClosed += RSBSAEditView_FormClosed;

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

        private void LoadData()
        {
            getBarangay(comboBoxFilterBrgy);
            getCommType(comboBoxFilterCommodity);

            // Set a limit for the number of rows to fetch/display
            int limit = 18; // You can adjust this value based on your preference

            // Fetch all rows
            var queryResult = rsbsaController.SearchRSBSA(txtBoxSearch.Text, comboBoxSearchCategory.Text, brgy, commType).AsEnumerable();

            // Check if there are any rows in the result
            if (queryResult.Any())
            {
                // Check if the number of rows is less than the limit
                if (queryResult.Count() < limit)
                {
                    // If fewer rows than the limit, take all rows
                    limit = queryResult.Count();
                }

                // Fetch only the required subset of data
                DataTable dt = queryResult.Skip(0)  // You can adjust the starting index based on the current page
                                         .Take(limit)
                                         .CopyToDataTable();

                dgvRsbsa.DataSource = dt;
            }
            else
            {
                // Handle the case when there are no rows in the result
                // For example, display a message or clear the DataGridView
                dgvRsbsa.DataSource = null;
            }
        }



        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxFilterBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBoxFilterCommodity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            RSBSAImportExcelView importExcelView = new RSBSAImportExcelView();
            importExcelView.FormClosed += RSBSAImportExcelView_FormClosed;

            importExcelView.TopLevel = false;
            importExcelView.FormBorderStyle = FormBorderStyle.None;
            importExcelView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(importExcelView);
            importExcelView.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            RSBSAExportView exportView = new RSBSAExportView();
            exportView.FormClosed += RSBSAExportView_FormClosed;

            exportView.TopLevel = false;
            exportView.FormBorderStyle = FormBorderStyle.None;
            exportView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(exportView);
            exportView.Show();
        }
    }
}
