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

        private void DashboardView_Load(object sender, EventArgs e)
        {
            DataTable data = analyticsController.PieCountFarmerBarangay();

            if (data != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChart(data);

                // Set the pie chart model to the PlotView control
                pieChart1.Model = pieChart;
            }
        }
    }
}
