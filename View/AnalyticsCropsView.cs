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
    public partial class AnalyticsCropsView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void AnalyticsCropsView_Load(object sender, EventArgs e)
        {
            labelTotalRiceFarmers.Text = analyticsController.CountRiceFarmers();
            labelTotalRiceLandArea.Text = analyticsController.TotalRiceLandArea() + " ha";
            labelTotalRiceBarangay.Text = analyticsController.TotalBarangayRice() + " ha";
            labelTotalAreaPlanted.Text = analyticsController.TotalRiceAreaPlanted() + " ha";

            DataTable data1 = analyticsController.PieCountRiceFarmerSex();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRice1(data1);

                // Set the pie chart model to the PlotView control
                riceGraph1.Model = pieChart;
            }

            DataTable data2 = analyticsController.BarCountRiceFarmerBarangay();

            if (data2 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChartRice1(data2);

                // Set the pie chart model to the PlotView control
                riceGraph2.Model = barChart;
            }
        }

        private void riceGraph1_Click(object sender, EventArgs e)
        {

        }
    }
}
