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
    public partial class CropsRiceAddView : Form
    {
        private CropsRiceController cropsRiceController;
        public CropsRiceAddView()
        {
            InitializeComponent();
            cropsRiceController = new CropsRiceController(this);
        }

        //Methods


        public void FormRefresh()
        {
            DataTable riceStandLogsTable = cropsRiceController.LoadRiceStandLogsView();
            dgvRiceStandLogs.DataSource = riceStandLogsTable;

            btnSave.Visible = false;

        }

        private void CropsRiceAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        private void dgvRiceStandLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Visible = true;

            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvRiceStandLogs.Rows[e.RowIndex];

                //string riceStandingLogsId = row.Cells[0].Value.ToString();

                //if (riceStandingLogsId != null)
                //{
                //    Letters letters = letterController.GetLetterInfoByLetterId(userId);
                //    LettersPages lettersPages = letterController.GetLetterPagesByLetterId(userId);
                //}
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
        }
    }
}
