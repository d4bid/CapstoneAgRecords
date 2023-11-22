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

        public void changeDateTable()
        {
            DataTable actsTable = analyticsController.LoadWeeklyActivities(dtpFrom.Value.Date, dtpTo.Value.Date);
            dgvActivities.DataSource = actsTable;
        }

        public void changeSummaryTable()
        {
            DataTable actsTable = analyticsController.LoadActivitiesSummary(dtpFrom1.Value.Date, dtpTo1.Value.Date);
            dgvSummary.DataSource = actsTable;
        }

        private void WeeklyActivitiesView_Load(object sender, EventArgs e)
        {
            // Calculate the date one week ago from the current date
            DateTime oneWeekAgo = DateTime.Now.AddDays(-7);

            // Set the value of your DateTimePicker control to the calculated date
            dtpFrom.Value = oneWeekAgo;
            dtpFrom1.Value = oneWeekAgo;

            dtpTo.MaxDate = DateTime.Today;
            dtpTo1.MaxDate = DateTime.Today;

            dtpTo.Value = DateTime.Today;
            dtpTo1.Value = DateTime.Today;

            changeDateTable();
            changeSummaryTable();

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
            int tableWidth = e.MarginBounds.Width; // Width between the left and right margins

            // Calculate the cell width for even distribution.
            int numColumns = dgvActivities.Columns.Count;
            int cellWidth = tableWidth / numColumns;

            // Define fonts for table headers and data.
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font dataFont = new Font("Arial", 12);

            // Draw the custom table headers.
            int headerX = tableX;
            int headerY = tableY;
            foreach (DataGridViewColumn column in dgvActivities.Columns)
            {
                string header = column.HeaderText;
                e.Graphics.DrawString(header, headerFont, brush, headerX, headerY);
                headerX += cellWidth;
            }

            // Draw the custom table data rows.
            int dataY = tableY + 20; // Adjust the starting Y position for data rows
            foreach (DataGridViewRow row in dgvActivities.Rows)
            {
                int dataX = tableX;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    string cellText = cell.Value.ToString();

                    // Scale the font size to fit the content within the cell.
                    float fontSize = 12;
                    Font scaledFont = new Font(dataFont.FontFamily, fontSize);
                    SizeF cellSize = e.Graphics.MeasureString(cellText, scaledFont);

                    while (cellSize.Width > cellWidth)
                    {
                        fontSize -= 1;
                        scaledFont = new Font(dataFont.FontFamily, fontSize);
                        cellSize = e.Graphics.MeasureString(cellText, scaledFont);
                    }

                    // Word-wrap the cell content.
                    StringFormat sf = new StringFormat();
                    sf.Trimming = StringTrimming.Word;
                    sf.FormatFlags = StringFormatFlags.NoWrap;

                    RectangleF cellRect = new RectangleF(dataX, dataY, cellWidth, 20); // 20 is the cell height
                    e.Graphics.DrawString(cellText, scaledFont, brush, cellRect, sf);
                    dataX += cellWidth;
                }
                dataY += 20; // Adjust the row height
            }

            // Check if there are more pages to print.
            e.HasMorePages = false;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            changeDateTable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            changeDateTable();
        }

        private void dtpFrom1_ValueChanged(object sender, EventArgs e)
        {
            changeSummaryTable();
        }

        private void dtpTo1_ValueChanged(object sender, EventArgs e)
        {
            changeSummaryTable();
        }
    }
}
