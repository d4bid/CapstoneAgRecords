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
    public partial class CropsRiceView : Form
    {
        private Panel parentPanel;
        private CropsRiceController cropsRiceController;

        public CropsRiceView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            cropsRiceController = new CropsRiceController(this);
        }

        // Methods

        private void FormRefresh()
        {
            
        }

        private void CropsRiceAddView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        private void CropsRiceEditView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        // Trigger Events

        private void CropsRiceView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            cbStanding.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RiceAddView riceAddView = new RiceAddView();
            riceAddView.SaveButtonClicked += (s, args) =>
            {
                // Get the RiceAddView's labelRiceSrId value
                string riceSrId = riceAddView.RiceSrIdValue;

                // Handle the event when the Save button is clicked in RiceAddView
                this.Close(); // Close the current form (CropsRiceView)

                CropsRiceAddView cropsRiceAddView = new CropsRiceAddView();
                cropsRiceAddView.TopLevel = false;
                cropsRiceAddView.FormBorderStyle = FormBorderStyle.None;
                cropsRiceAddView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(cropsRiceAddView);


                // Set the labelRiceSrId in CropsRiceAddView
                cropsRiceAddView.RiceSrIdValue = riceSrId;

                // Call the MoveNextStandingLogs method from cropsRiceController
                bool success = cropsRiceController.MoveNextStandingLogs(riceSrId);

                cropsRiceAddView.Show();
            };
            riceAddView.Show();
        }

        private void dgvRice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRice.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string riceSrId = row.Cells[0].Value.ToString();

                if (riceSrId != null)
                {
                    RicePlantingRep rpr = null;
                    RiceStandingRep rsr = null;
                    RiceHarvestingRep rhr = null;

                    // Check if the cbPlanting checkbox is checked
                    if (cbPlanting.Checked)
                    {
                        rpr = cropsRiceController.GetRicePlantReportById(riceSrId);
                    }
                    else if (cbStanding.Checked)
                    {
                        rsr = cropsRiceController.GetRiceStandReportById(riceSrId);
                    }
                    else if (cbHarvesting.Checked)
                    {
                        rhr = cropsRiceController.GetRiceHarvestReportById(riceSrId);
                    }

                    CropsRiceEditView cropsRiceEditView = new CropsRiceEditView(rpr, rsr, rhr);
                    cropsRiceEditView.FormClosed += CropsRiceEditView_FormClosed;

                    cropsRiceEditView.TopLevel = false;
                    cropsRiceEditView.FormBorderStyle = FormBorderStyle.None;
                    cropsRiceEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(cropsRiceEditView);
                    cropsRiceEditView.Show();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbPlanting_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlanting.Checked)
            {
                cbHarvesting.Checked = false;
                cbStanding.Checked = false;
                DataTable riceTable = cropsRiceController.LoadRicePlantingReportView();
                dgvRice.DataSource = riceTable;
            }
        }

        private void cbStanding_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStanding.Checked)
            {
                cbHarvesting.Checked = false;
                cbPlanting.Checked = false;
                DataTable riceTable = cropsRiceController.LoadRiceStandingReportView();
                dgvRice.DataSource = riceTable;
            }
        }

        private void cbHarvesting_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHarvesting.Checked)
            {
                cbPlanting.Checked = false;
                cbStanding.Checked = false;
                DataTable riceTable = cropsRiceController.LoadRiceHarvestingReportView();
                dgvRice.DataSource = riceTable;
            }
        }
    }
}
