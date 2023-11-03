using AgRecords.Controller;
using AgRecords.Model;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class WeeklyActivitiesView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public WeeklyActivitiesView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void WeeklyActivitiesView_Load(object sender, EventArgs e)
        {
            DataTable actsTable = analyticsController.LoadWeeklyActivities();
            dgvActivities.DataSource = actsTable;


            DataTable data1 = analyticsController.BarCountDailyActivities();

            if (data1 != null)
            {
                // Create the pie chart model
                //PlotModel barChart = analyticsController.CreateStackedBarChart1(data1);
                PlotModel barChart = analyticsController.CreateLineChart1(data1);

                // Set the pie chart model to the PlotView control
                weekGraph2.Model = barChart;
            }

            DataTable data2 = analyticsController.BarCountActivitiesSection();

            if (data2 != null)
            {
                // Create the pie chart model
                //PlotModel barChart = analyticsController.CreateStackedBarChart1(data1);
                PlotModel barChart = analyticsController.CreateBarChart2(data2);

                // Set the pie chart model to the PlotView control
                weekGraph1.Model = barChart;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            // Create a PrintPreviewDialog.
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;

            // Display the print preview dialog.
            printPreviewDialog.ShowDialog();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the page settings (letter size paper and normal margins).
            PageSettings ps = new PageSettings();
            ps.PaperSize = new PaperSize("Letter", 850, 1100);
            ps.Margins = new Margins(50, 50, 50, 50);

            // Set the page settings for the print document.
            ((PrintDocument)sender).DefaultPageSettings = ps;

            // Get the current date and time.
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

            // Define the title and date string to be printed at the top.
            string title = "Weekly Activities Report";
            string dateStr = currentDate;

            // Define the font and brushes for text.
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font dateFont = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Define the position for the title and date.
            int titleX = e.MarginBounds.Left;
            int titleY = e.MarginBounds.Top;
            int dateX = e.MarginBounds.Left;
            int dateY = e.MarginBounds.Top + 40;

            // Draw the title and date.
            e.Graphics.DrawString(title, titleFont, brush, titleX, titleY);
            e.Graphics.DrawString(dateStr, dateFont, brush, dateX, dateY);

            // Define the custom table layout.
            int tableX = e.MarginBounds.Left;
            int tableY = e.MarginBounds.Top + 80;
            int cellWidth = 150; // Adjust the cell width as needed
            int cellHeight = 20; // Adjust the cell height as needed

            // Define headers for your custom table.
            string[] headers = { "Column 1", "Column 2", "Column 3", "Column 4" };

            // Define the data rows for your custom table.
            List<string[]> data = new List<string[]>
    {
        new string[] { "Data 1", "Data 2", "Data 3", "Data 4" },
        // Add more data rows as needed
    };

            // Define fonts for table headers and data.
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font dataFont = new Font("Arial", 12);

            // Draw the custom table headers.
            int headerX = tableX;
            int headerY = tableY;
            foreach (string header in headers)
            {
                e.Graphics.DrawString(header, headerFont, brush, headerX, headerY);
                headerX += cellWidth;
            }

            // Draw the custom table data rows.
            int dataY = tableY + cellHeight;
            foreach (string[] row in data)
            {
                int dataX = tableX;
                foreach (string cell in row)
                {
                    e.Graphics.DrawString(cell, dataFont, brush, dataX, dataY);
                    dataX += cellWidth;
                }
                dataY += cellHeight;
            }

            // Check if there are more pages to print.
            e.HasMorePages = false;
        }

    }
}
