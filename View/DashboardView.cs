using AgRecords.Controller;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace AgRecords.View
{
    public partial class DashboardView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public DashboardView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        // Methods
        private void DashboardView_FormClosed(object sender, EventArgs e)
        {
            DashboardView dashboardView = new DashboardView(parentPanel);
            dashboardView.TopLevel = false;
            dashboardView.FormBorderStyle = FormBorderStyle.None;
            dashboardView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(dashboardView);
            dashboardView.Show();
        }

        public void AvgGaiFarming(float avgGaiFarming)
        {
            labelGaiFarming.Text = "₱" + avgGaiFarming.ToString();
        }

        public void AvgGaiNonFarming(float avgGaiNonFarming)
        {
            labelGaiNonFarming.Text = "₱" + avgGaiNonFarming.ToString();
        }

        // Triggers

        private void DashboardView_Load(object sender, EventArgs e)
        {

            analyticsController.AvgGaiFarming();
            analyticsController.AvgGaiNonFarming();

            // A
            DataTable coopTable = analyticsController.CountCoopFarmerBarangay();
            dgvAss.DataSource = coopTable;

            // B
            DataTable lettersTable = analyticsController.LoadRecentLetters();
            dgvLetters.DataSource = lettersTable;

            // 1
            DataTable data = analyticsController.BarCountFarmerBarangay();

            if (data != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChart1(data);

                // Set the pie chart model to the PlotView control
                barChart1.Model = barChart;
            }

            // 2
            DataTable data1 = analyticsController.PieCountFarmerCommodity();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChart1(data1);

                // Set the pie chart model to the PlotView control
                pieChart1.Model = pieChart;
            }

            // 3
        }
    }
}
