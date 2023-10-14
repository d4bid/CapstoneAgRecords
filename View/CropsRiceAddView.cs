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

        }

        private void CropsRiceAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }
    }
}
