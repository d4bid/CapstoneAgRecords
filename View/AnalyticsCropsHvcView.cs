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
    public partial class AnalyticsCropsHvcView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsHvcView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

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
    }
}
