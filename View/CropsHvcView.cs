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
    public partial class CropsHvcView : Form
    {
        private Panel parentPanel;
        private CropsHvcController cropsHvcController;

        public CropsHvcView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            cropsHvcController = new CropsHvcController(this);
        }

        // Methods
        private void CropsHvcAddView_FormClosed(object sender, EventArgs e)
        {
            CropsHvcView cropsHvcView = new CropsHvcView(parentPanel);
            cropsHvcView.TopLevel = false;
            cropsHvcView.FormBorderStyle = FormBorderStyle.None;
            cropsHvcView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsHvcView);
            cropsHvcView.Show();
        }

        private void CropsHvcEditView_FormClosed(object sender, EventArgs e)
        {
            CropsHvcView cropsHvcView = new CropsHvcView(parentPanel);
            cropsHvcView.TopLevel = false;
            cropsHvcView.FormBorderStyle = FormBorderStyle.None;
            cropsHvcView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsHvcView);
            cropsHvcView.Show();
        }

        public void DisplayDataTableFilter()
        {
            string column = cmbColumn.Text;
            string keyword = txtBoxSearch.Text;

            DataTable hvcStandingTable = cropsHvcController.LoadHvcStandingReportView(column, keyword);
            dgvHvc.DataSource = hvcStandingTable;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HvcAddView hvcAddView = new HvcAddView();
            hvcAddView.SaveButtonClicked += (s, args) =>
            {
                // Get the RiceAddView's labelRiceSrId value
                string hvcSrId = hvcAddView.HvcSrIdValue;

                // Handle the event when the Save button is clicked in RiceAddView
                this.Close(); // Close the current form (CropsRiceView)

                CropsHvcAddView cropsHvcAddView = new CropsHvcAddView();
                cropsHvcAddView.FormClosed += CropsHvcAddView_FormClosed;
                cropsHvcAddView.TopLevel = false;
                cropsHvcAddView.FormBorderStyle = FormBorderStyle.None;
                cropsHvcAddView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(cropsHvcAddView);


                // Set the labelRiceSrId in CropsRiceAddView
                cropsHvcAddView.HvcSrIdValue = hvcSrId;

                // Call the MoveNextStandingLogs method from cropsRiceController
                bool success = cropsHvcController.MoveNextHvcStanding(hvcSrId);

                cropsHvcAddView.Show();
            };
            hvcAddView.Show();
        }

        private void CropsHvcView_Load(object sender, EventArgs e)
        {
            cmbColumn.Text = "All";

            DisplayDataTableFilter();
        }

        private void dgvHvc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvHvc.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string hvcSrId = row.Cells[0].Value.ToString();

                if (hvcSrId != null)
                {
                    HvcReport hr = cropsHvcController.GetHvcStandingReportById(hvcSrId);

                    CropsHvcEditView cropsHvcEditView = new CropsHvcEditView(hr);
                    cropsHvcEditView.FormClosed += CropsHvcEditView_FormClosed;

                    cropsHvcEditView.TopLevel = false;
                    cropsHvcEditView.FormBorderStyle = FormBorderStyle.None;
                    cropsHvcEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(cropsHvcEditView);
                    cropsHvcEditView.Show();
                }
            }
        }
    }
}
