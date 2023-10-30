using AgRecords.Controller;
using AgRecords.Model;
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
    }
}
