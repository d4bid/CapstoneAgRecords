using AgRecords.Controller;
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
    public partial class AnalyticsCropsHvcView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsHvcView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void AnalyticsCropsHvcView_Load(object sender, EventArgs e)
        {
            labelTotalHvcFarmers.Text = analyticsController.CountHvcFarmers();
            labelTotalHvcLandArea.Text = analyticsController.TotalHvcLandArea() + " ha";
            labelTotalHvcBarangay.Text = analyticsController.TotalBarangayHvc() + " ha";
            labelTotalAreaPlanted.Text = analyticsController.TotalHvcAreaPlanted() + " ha";


            DataTable data1 = analyticsController.PieCountHvcFarmerSex();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRice1(data1);

                // Set the pie chart model to the PlotView control
                hvcGraph1.Model = pieChart;
            }

            DataTable data2 = analyticsController.BarCountHvcFarmerBarangay();

            if (data2 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChartCorn1(data2);

                // Set the pie chart model to the PlotView control
                hvcGraph2.Model = barChart;
            }
        }
    }
}
