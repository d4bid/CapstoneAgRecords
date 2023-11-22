using AgRecords.Controller;
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
    public partial class AnalyticsRsbsaView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsRsbsaView(Control parentControl)
        {
            InitializeComponent();


            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            rsbsa1.ContextMenuStrip = new ContextMenuStrip();
            rsbsa1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            rsbsa1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph1.ContextMenuStrip = new ContextMenuStrip();
            panelGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            panelGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa1));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            rsbsa3.ContextMenuStrip = new ContextMenuStrip();
            rsbsa3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            rsbsa3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa3));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph3.ContextMenuStrip = new ContextMenuStrip();
            panelGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            panelGraph3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa3));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            rsbsa4.ContextMenuStrip = new ContextMenuStrip();
            rsbsa4.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph4));
            rsbsa4.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa4));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph4.ContextMenuStrip = new ContextMenuStrip();
            panelGraph4.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph4));
            panelGraph4.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa4));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            rsbsa5.ContextMenuStrip = new ContextMenuStrip();
            rsbsa5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            rsbsa5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa5));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph5.ContextMenuStrip = new ContextMenuStrip();
            panelGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            panelGraph5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(rsbsa5));

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

        private void SaveAsImage_ClickHandler1(object sender, EventArgs e)
        {
            SaveAsImage_Click(rsbsa1);
        }

        private void SaveAsImage_ClickHandler4(object sender, EventArgs e)
        {
            SaveAsImage_Click(rsbsa4);
        }

        private void SaveAsImage_ClickHandler3(object sender, EventArgs e)
        {
            SaveAsImage_Click(rsbsa3);
        }

        private void SaveAsImage_ClickHandler5(object sender, EventArgs e)
        {
            SaveAsImage_Click(rsbsa5);
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
