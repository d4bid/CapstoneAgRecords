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

        private System.Windows.Forms.Timer dgvRefreshTimer;

        public AnalyticsCropsCornView(Control parentControl)
        {
            InitializeComponent();
            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);

            this.FormClosing += AnalyticsCropsCornView_FormClosing;

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            cornGraph1.ContextMenuStrip = new ContextMenuStrip();
            cornGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            cornGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph1.ContextMenuStrip = new ContextMenuStrip();
            panelGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            panelGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph1));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            cornGraph2.ContextMenuStrip = new ContextMenuStrip();
            cornGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            cornGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph2));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph2.ContextMenuStrip = new ContextMenuStrip();
            panelGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            panelGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph2));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            cornGraph3.ContextMenuStrip = new ContextMenuStrip();
            cornGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            cornGraph3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph3));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph3.ContextMenuStrip = new ContextMenuStrip();
            panelGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            panelGraph3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(cornGraph3));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelDgv.ContextMenuStrip = new ContextMenuStrip();
            panelDgv.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelDgv));

            // Initialize and configure the timer
            dgvRefreshTimer = new System.Windows.Forms.Timer();
            dgvRefreshTimer.Interval = 1000; // Set the interval to 1000 milliseconds (1 second)
            dgvRefreshTimer.Tick += DgvRefreshTimer_Tick;

            // Start the timer
            dgvRefreshTimer.Start();
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

        private void SaveAsImage_Click(Control control)
        {
            // Display a SaveFileDialog to get the file path
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
                saveFileDialog.Title = "Save as Image";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    // Create a bitmap to composite all controls in the selected panel
                    using (Bitmap bmp = new Bitmap(control.Width, control.Height))
                    {
                        control.DrawToBitmap(bmp, new Rectangle(0, 0, control.Width, control.Height));

                        // Save the bitmap as an image
                        bmp.Save(saveFileDialog.FileName);
                    }
                }
            }
        }

        private void SaveGraphAsImage_Click(PlotView plotView)
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

        // Event handler for the timer tick
        private void DgvRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Call the method to refresh your DataGridView here
            FormRefresh();
        }

        private void FormRefresh()
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

        private void AnalyticsCropsCornView_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvRefreshTimer.Stop();
        }
    }
}
