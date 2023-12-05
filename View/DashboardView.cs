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
using MySqlX.XDevAPI.Relational;

namespace AgRecords.View
{
    public partial class DashboardView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        private System.Windows.Forms.Timer dgvRefreshTimer;

        public DashboardView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);

            this.FormClosing += DashboardView_FormClosing;

            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            barChart1.ContextMenuStrip = new ContextMenuStrip();
            barChart1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            barChart1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(barChart1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph1.ContextMenuStrip = new ContextMenuStrip();
            panelGraph1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph1));
            panelGraph1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(barChart1));


            // Add a ContextMenuStrip to the PlotView to handle the right-click event
            pieChart1.ContextMenuStrip = new ContextMenuStrip();
            pieChart1.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            pieChart1.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(pieChart1));

            // Add a ContextMenuStrip to each panel to handle the right-click event
            panelGraph2.ContextMenuStrip = new ContextMenuStrip();
            panelGraph2.ContextMenuStrip.Items.Add("Save as Image", null, (sender, e) => SaveAsImage_Click(panelGraph2));
            panelGraph2.ContextMenuStrip.Items.Add("Save Graph As Image", null, (sender, e) => SaveGraphAsImage_Click(pieChart1));

            // Initialize and configure the timer
            dgvRefreshTimer = new System.Windows.Forms.Timer();
            dgvRefreshTimer.Interval = 1000; // Set the interval to 1000 milliseconds (1 second)
            dgvRefreshTimer.Tick += DgvRefreshTimer_Tick;

            // Start the timer
            dgvRefreshTimer.Start();
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

        public void AvgGaiFarming(float avgGaiFarming)
        {
            labelGaiFarming.Text = "₱" + avgGaiFarming.ToString();
        }

        public void AvgGaiNonFarming(float avgGaiNonFarming)
        {
            labelGaiNonFarming.Text = "₱" + avgGaiNonFarming.ToString();
        }

        public void FormRefresh()
        {
            analyticsController.AvgGaiFarming();
            analyticsController.AvgGaiNonFarming();
            labelTotalFarmers.Text = analyticsController.CountRsbsaFarmers();
            labelNoBarangay.Text = analyticsController.CountTotalBarangay();

            // A
            DataTable coopTable = analyticsController.CountCoopFarmerBarangay();
            dgvAss.DataSource = coopTable;

            // B
            DataTable lettersTable = analyticsController.LoadRecentLetters();
            dgvLetters.DataSource = lettersTable;

            // 1
            DataTable data = analyticsController.BarCountFarmerBarangay();

            if (data != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChart1(data);

                // Set the pie chart model to the PlotView control
                barChart1.Model = barChart;
            }

            // 2
            DataTable data1 = analyticsController.PieCountFarmerCommodity();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChart1(data1);

                // Set the pie chart model to the PlotView control
                pieChart1.Model = pieChart;
            }
        }

        // Triggers

        private void DashboardView_Load(object sender, EventArgs e)
        {

            analyticsController.AvgGaiFarming();
            analyticsController.AvgGaiNonFarming();
            labelTotalFarmers.Text = analyticsController.CountRsbsaFarmers();
            labelNoBarangay.Text = analyticsController.CountTotalBarangay();

            // A
            DataTable coopTable = analyticsController.CountCoopFarmerBarangay();
            dgvAss.DataSource = coopTable;

            // B
            DataTable lettersTable = analyticsController.LoadRecentLetters();
            dgvLetters.DataSource = lettersTable;

            // 1
            DataTable data = analyticsController.BarCountFarmerBarangay();

            if (data != null)
            {
                // Create the pie chart model
                PlotModel barChart = analyticsController.CreateBarChart1(data);

                // Set the pie chart model to the PlotView control
                barChart1.Model = barChart;
            }

            // 2
            DataTable data1 = analyticsController.PieCountFarmerCommodity();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChart1(data1);

                // Set the pie chart model to the PlotView control
                pieChart1.Model = pieChart;
            }

            // 3
        }

        private void barChart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void DashboardView_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvRefreshTimer.Stop();
        }

        // Event handler for the timer tick
        private void DgvRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Call the method to refresh your DataGridView here
            FormRefresh();
        }
    }
}
