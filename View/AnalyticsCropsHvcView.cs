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
    public partial class AnalyticsCropsHvcView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsHvcView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);

            //// Add a ContextMenuStrip to the PlotView to handle the right-click event
            //hvcGraph1.ContextMenuStrip = new ContextMenuStrip();
            //hvcGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph1));

            //hvcGraph2.ContextMenuStrip = new ContextMenuStrip();
            //hvcGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph2));

            //hvcGraph3.ContextMenuStrip = new ContextMenuStrip();
            //hvcGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph3));

            //hvcGraph5.ContextMenuStrip = new ContextMenuStrip();
            //hvcGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph5));

            //// Add a ContextMenuStrip to each panel to handle the right-click event
            //graph1panel.ContextMenuStrip = new ContextMenuStrip();
            //graph1panel.ContextMenuStrip.Items.Add("Save as Image", null, SaveAsImage_Click);

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            hvcGraph1.ContextMenuStrip = new ContextMenuStrip();
            hvcGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            hvcGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph1.ContextMenuStrip = new ContextMenuStrip();
            panelGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            panelGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph1));


            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            hvcGraph2.ContextMenuStrip = new ContextMenuStrip();
            hvcGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            hvcGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph2));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph2.ContextMenuStrip = new ContextMenuStrip();
            panelGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            panelGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph2));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            hvcGraph3.ContextMenuStrip = new ContextMenuStrip();
            hvcGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            hvcGraph3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph3));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph3.ContextMenuStrip = new ContextMenuStrip();
            panelGraph3.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph3));
            panelGraph3.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph3));

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            hvcGraph5.ContextMenuStrip = new ContextMenuStrip();
            hvcGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            hvcGraph5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph5));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph5.ContextMenuStrip = new ContextMenuStrip();
            panelGraph5.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph5));
            panelGraph5.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(hvcGraph5));
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

        //private void SaveAsImage_Click(object sender, EventArgs e)
        //{
        //    // Display a SaveFileDialog to get the file path
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
        //        saveFileDialog.Title = "Save as Image";
        //        saveFileDialog.ShowDialog();

        //        if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
        //        {
        //            // Create a bitmap to composite all controls in the selected panel
        //            using (Bitmap bmp = new Bitmap(graph1panel.Width, graph1panel.Height))
        //            {
        //                graph1panel.DrawToBitmap(bmp, new Rectangle(0, 0, graph1panel.Width, graph1panel.Height));

        //                // Save the bitmap as an image
        //                bmp.Save(saveFileDialog.FileName);
        //            }
        //        }
        //    }
        //}

        //private void SaveGraphAsImage_Click(PlotView plotView)
        //{
        //    // Display a SaveFileDialog to get the file path
        //    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //    {
        //        saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
        //        saveFileDialog.Title = "Save as Image";
        //        saveFileDialog.ShowDialog();

        //        if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
        //        {
        //            OxyPlot.WindowsForms.PngExporter.Export(plotView.Model, saveFileDialog.FileName, plotView.Width, plotView.Height);
        //        }
        //    }
        //}

        private void AnalyticsCropsHvcView_Load(object sender, EventArgs e)
        {
            // Get the current month
            string currentMonth = DateTime.Now.ToString("MMMM");

            // Find and set the index in the ComboBox
            int selectedIndex = cmbMonth.FindStringExact(currentMonth);

            if (selectedIndex != -1)
            {
                cmbMonth.SelectedIndex = selectedIndex;
            }

            cmbWeek.SelectedIndex = 0;

            labelTotalHvcFarmers.Text = analyticsController.CountHvcFarmers();
            labelTotalHvcLandArea.Text = analyticsController.TotalHvcLandArea() + " ha";
            labelTotalHvcBarangay.Text = analyticsController.TotalBarangayHvc();
            labelTotalAreaPlanted.Text = analyticsController.TotalHvcAreaPlanted() + " ha";

            DataTable coopTable = analyticsController.ListHvc();
            dgvHvc.DataSource = coopTable;

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

            DataTable data3 = analyticsController.BarTotalStandingHvc();

            if (data3 != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChartHvc1(data3);

                // Set the pie chart model to the PlotView control
                hvcGraph3.Model = barChart;
            }

            DataTable data5 = analyticsController.LineHvcProgression(cmbMonth.Text, cmbWeek.Text);

            if (data5 != null)
            {
                // Create the pie chart model
                PlotModel lineChart = analyticsController.CreateHvcProgressionChart(data5);

                // Set the pie chart model to the PlotView control
                hvcGraph5.Model = lineChart;
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = cmbMonth.SelectedItem.ToString();

            int daysInMonth;

            // Determine the number of days in the selected month
            switch (selectedMonth)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    daysInMonth = 31;
                    break;

                case "April":
                case "June":
                case "September":
                case "November":
                    daysInMonth = 30;
                    break;

                case "February":
                    // Handle leap years
                    int year = DateTime.Now.Year;
                    bool isLeapYear = DateTime.IsLeapYear(year);
                    daysInMonth = isLeapYear ? 29 : 28;
                    break;

                default:
                    daysInMonth = 0; // Invalid month
                    break;
            }

            if (daysInMonth == 30)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-30");
            }
            else if (daysInMonth == 31)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-31");
            }
            else if (daysInMonth == 29 || daysInMonth == 28)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-" + daysInMonth);
            }
            else
            {
                cmbWeek.Items.Clear();
            }

            cmbWeek.SelectedIndex = 0;

            DataTable data5 = analyticsController.LineHvcProgression(cmbMonth.Text, cmbWeek.Text);

            if (data5 != null)
            {
                // Create the pie chart model
                PlotModel lineChart = analyticsController.CreateHvcProgressionChart(data5);

                // Set the pie chart model to the PlotView control
                hvcGraph5.Model = lineChart;
            }
        }

        private void hvcGraph3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
