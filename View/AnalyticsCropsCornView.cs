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
    public partial class AnalyticsCropsCornView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsCornView(Control parentControl)
        {
            InitializeComponent();
            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            cornGraph1.ContextMenuStrip = new ContextMenuStrip();
            cornGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(cornGraph1));

            cornGraph2.ContextMenuStrip = new ContextMenuStrip();
            cornGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(cornGraph2));

            cornGraph3.ContextMenuStrip = new ContextMenuStrip();
            cornGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(cornGraph3));
        }

        private void AnalyticsCropsCornView_Load(object sender, EventArgs e)
        {
            labelTotalCornFarmers.Text = analyticsController.CountCornFarmers();
            labelTotalCornLandArea.Text = analyticsController.TotalCornLandArea() + " ha";
            labelTotalCornBarangay.Text = analyticsController.TotalBarangayCorn();
            labelTotalCornAreaPlanted.Text = analyticsController.TotalCornAreaPlanted() + " ha";
            labelTotalYellowCorn.Text = analyticsController.TotalCornAreaPlantedYellow() + " ha";
            labelTotalWhiteCorn.Text = analyticsController.TotalCornAreaPlantedWhite() + " ha";

            DataTable coopTable = analyticsController.ShowCornProduction();
            dgvCornProd.DataSource = coopTable;

            DataTable data2 = analyticsController.BarCountRiceFarmerBarangay();

            if (data2 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChartCorn1(data2);

                // Set the pie chart model to the PlotView control
                cornGraph1.Model = barChart;
            }

            DataTable data1 = analyticsController.PieCountRiceFarmerSex();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRice1(data1);

                // Set the pie chart model to the PlotView control
                cornGraph2.Model = pieChart;
            }

            ProductionData productionData = analyticsController.CornForecasting();
            cornGraph3.Model = analyticsController.CreateLineSeriesChartCornForecast(productionData.Years, productionData.ForecastedProduction);
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
    }
}
