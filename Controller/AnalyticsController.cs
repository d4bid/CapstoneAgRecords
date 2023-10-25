using AgRecords.Model;
using AgRecords.View;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    public class AnalyticsController
    {
        private DashboardView dashboardView;
        private AnalyticsModel analyticsModel;

        public AnalyticsController(DashboardView dashboardView)
        {
            this.dashboardView = dashboardView;
            analyticsModel = new AnalyticsModel();
        }

        public PlotModel CreatePieChart(DataTable data)
        {
            var model = new PlotModel();
            var series = new PieSeries();

            foreach (DataRow row in data.Rows)
            {
                string label = row["addrBrgy"].ToString();
                double value = Convert.ToDouble(row["FarmerCount"]);

                series.Slices.Add(new PieSlice(label, value));
            }

            model.Series.Add(series);
            return model;
        }

        public DataTable PieCountFarmerBarangay()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountFarmerBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Barangay Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
