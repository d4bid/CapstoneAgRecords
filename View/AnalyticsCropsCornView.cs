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
    public partial class AnalyticsCropsCornView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsCornView(Control parentControl)
        {
            InitializeComponent();
            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void AnalyticsCropsCornView_Load(object sender, EventArgs e)
        {
            labelTotalCornFarmers.Text = analyticsController.CountCornFarmers();
            labelTotalCornLandArea.Text = analyticsController.TotalCornLandArea() + " ha";
            labelTotalCornBarangay.Text = analyticsController.TotalBarangayCorn() + " ha";
            labelTotalCornAreaPlanted.Text = analyticsController.TotalCornAreaPlanted() + " ha";

            DataTable data1 = analyticsController.PieCountRiceFarmerSex();

            if (data1 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChartRice1(data1);

                // Set the pie chart model to the PlotView control
                cornGraph1.Model = pieChart;
            }
        }
    }
}
