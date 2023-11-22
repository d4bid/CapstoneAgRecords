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
            riceGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            riceGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph1.ContextMenuStrip = new ContextMenuStrip();
            panelGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            panelGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph1));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            riceGraph2.ContextMenuStrip = new ContextMenuStrip();
            riceGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            riceGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph2));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph2.ContextMenuStrip = new ContextMenuStrip();
            panelGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            panelGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph2));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            riceGraph4.ContextMenuStrip = new ContextMenuStrip();
            riceGraph4.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph4));
            riceGraph4.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph4));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph4.ContextMenuStrip = new ContextMenuStrip();
            panelGraph4.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph4));
            panelGraph4.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph4));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            riceGraph5.ContextMenuStrip = new ContextMenuStrip();
            riceGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            riceGraph5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph5));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph5.ContextMenuStrip = new ContextMenuStrip();
            panelGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            panelGraph5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph5));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            riceGraph7.ContextMenuStrip = new ContextMenuStrip();
            riceGraph7.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph7));
            riceGraph7.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph7));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph7.ContextMenuStrip = new ContextMenuStrip();
            panelGraph7.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph7));
            panelGraph7.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(riceGraph7));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelDgv.ContextMenuStrip = new ContextMenuStrip();
            panelDgv.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelDgv));
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

        private void riceGraph1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
