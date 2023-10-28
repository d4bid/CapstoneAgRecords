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
    public partial class AnalyticsCropsView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsCropsView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void AnalyticsCropsView_Load(object sender, EventArgs e)
        {
            DataTable data2 = analyticsController.PieCountFarmerSex();

            if (data2 != null)
            {
                // Create the pie chart model
                PlotModel pieChart = analyticsController.CreatePieChart2(data2);

                // Set the pie chart model to the PlotView control
                riceGraph1.Model = pieChart;
            }
        }
    }
}
