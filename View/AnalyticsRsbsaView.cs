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
    public partial class AnalyticsRsbsaView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsRsbsaView(Control parentControl)
        {
            InitializeComponent();


            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        public void CountFarmer(string countFarmer)
        {
            labelFarmers.Text = countFarmer.ToString();
        }

        public void CountFisherfolk(string countFisherfolk)
        {
            //labelFisherfolks.Text = countFisherfolk.ToString();
        }

        private void AnalyticsRsbsaView_Load(object sender, EventArgs e)
        {
            analyticsController.CountFarmer();
            analyticsController.CountFisherfolk();

            labelTotalFarmers.Text = analyticsController.CountRsbsaFarmers();
            //labelTotalWeeklyReg.Text = analyticsController.CountRsbsaWeeklyReg();

            cmbBrgy1.SelectedIndex = 0;
            string brgy = cmbBrgy1.Text;
            cmbRegInterval.SelectedIndex = 2;
            string interval = cmbRegInterval.Text;

            DataTable data1 = analyticsController.PieCountCommodityBarangay(brgy);

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRsbsa2(data1);

                // Set the pie chart model to the PlotView control
                rsbsa1.Model = pieChart;
            }

            DataTable data2 = analyticsController.BarCountFarmerBrgy();

            if (data2 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChartRsbsa1(data2);

                // Set the pie chart model to the PlotView control
                rsbsa4.Model = barChart;
            }

            DataTable data3 = analyticsController.LineCountRsbsaRegBrgy(interval);

            if (data3 != null)
            {
                // Create the pie chart model
                PlotModel lineChart = analyticsController.CreateLineChartRsbsa1(data3);

                // Set the pie chart model to the PlotView control
                rsbsa3.Model = lineChart;
            }

            DataTable data5 = analyticsController.BarCountLivelihoodBarangay();

            if (data5 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateGroupedBarChartRsbsa1(data5);

                // Set the pie chart model to the PlotView control
                rsbsa5.Model = barChart;
            }
        }

        private void cmbBrgy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brgy = cmbBrgy1.Text;

            DataTable data1 = analyticsController.PieCountCommodityBarangay(brgy);

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRsbsa2(data1);

                // Set the pie chart model to the PlotView control
                rsbsa1.Model = pieChart;
            }
        }

        private void cmbRegInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            string interval = cmbRegInterval.Text;

            DataTable data3 = analyticsController.LineCountRsbsaRegBrgy(interval);

            if (data3 != null)
            {
                // Create the pie chart model
                PlotModel lineChart = analyticsController.CreateLineChartRsbsa1(data3);

                // Set the pie chart model to the PlotView control
                rsbsa3.Model = lineChart;
            }
        }
    }
}
