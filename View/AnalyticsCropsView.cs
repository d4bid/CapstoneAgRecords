using AgRecords.Controller;
using AgRecords.Model;
using OxyPlot;
using OxyPlot.WindowsForms;
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

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            riceGraph1.ContextMenuStrip = new ContextMenuStrip();
            riceGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(riceGraph1));

            riceGraph2.ContextMenuStrip = new ContextMenuStrip();
            riceGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(riceGraph2));

            riceGraph4.ContextMenuStrip = new ContextMenuStrip();
            riceGraph4.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(riceGraph4));

            riceGraph5.ContextMenuStrip = new ContextMenuStrip();
            riceGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(riceGraph5));

            riceGraph7.ContextMenuStrip = new ContextMenuStrip();
            riceGraph7.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(riceGraph7));
        }

        private void AnalyticsCropsView_Load(object sender, EventArgs e)
        {
            labelTotalRiceFarmers.Text = analyticsController.CountRiceFarmers();
            labelTotalRiceLandArea.Text = analyticsController.TotalRiceLandArea() + " ha";
            labelTotalRiceBarangay.Text = analyticsController.TotalBarangayRice();
            labelTotalAreaPlanted.Text = analyticsController.TotalRiceAreaPlanted() + " ha";

            DataTable coopTable = analyticsController.ShowRiceProduction();
            dgvRiceProd.DataSource = coopTable;

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

            DataTable data4 = analyticsController.PieCountHarvestedOutOfPlanted();

            if (data4 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreateCircularProgressChartRice1(data4);

                // Set the pie chart model to the PlotView control
                riceGraph4.Model = pieChart;
            }

            DataTable data5 = analyticsController.BarTotalRiceLandAreaPerFarmType();

            if (data5 != null)
            {
                // Create the pie chart model
                PlotModel lineChart = analyticsController.CreateBarChartRiceLandArea(data5);

                // Set the pie chart model to the PlotView control
                riceGraph5.Model = lineChart;
            }

            ProductionData productionData = analyticsController.Forecasting();
            riceGraph7.Model = analyticsController.CreateLineSeriesChartRiceForecast(productionData.Years, productionData.ForecastedProduction);

        }

        private void SaveAsImage_Click(PlotView plotView)
        {
            // Display a SaveFileDialog to get the file path
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
                saveFileDialog.Title = "Save as Image";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    OxyPlot.WindowsForms.PngExporter.Export(plotView.Model, saveFileDialog.FileName, plotView.Width, plotView.Height);
                }
            }
        }

        private void riceGraph1_Click(object sender, EventArgs e)
        {

        }
    }
}
