using AgRecords.Model;
using AgRecords.View;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Legends;
using OxyPlot.Utilities;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace AgRecords.Controller
{
    public class AnalyticsController
    {
        private DashboardView dashboardView;
        private MainView mainView;
        private AnalyticsRsbsaView analyticsRsbsaView;
        private AnalyticsCropsView analyticsCropsView;
        private AnalyticsCropsCornView analyticsCropsCornView;
        private AnalyticsCropsHvcView analyticsCropsHvcView;
        private AnalyticsModel analyticsModel;

        public AnalyticsController(DashboardView dashboardView)
        {
            this.dashboardView = dashboardView;
            analyticsModel = new AnalyticsModel();
        }

        public AnalyticsController(MainView mainView)
        {
            this.mainView = mainView;
            analyticsModel = new AnalyticsModel();
        }

        public AnalyticsController(AnalyticsRsbsaView analyticsRsbsaView)
        {
            this.analyticsRsbsaView = analyticsRsbsaView;
            analyticsModel = new AnalyticsModel();
        }

        public AnalyticsController(AnalyticsCropsView analyticsCropsView)
        {
            this.analyticsCropsView = analyticsCropsView;
            analyticsModel = new AnalyticsModel();
        }

        public AnalyticsController(AnalyticsCropsCornView analyticsCornCropsView)
        {
            this.analyticsCropsCornView = analyticsCropsCornView;
            analyticsModel = new AnalyticsModel();
        }

        // DATA
        public void AvgGaiFarming()
        {
            try
            {
                dashboardView.AvgGaiFarming(analyticsModel.AvgGaiFarming());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Getting Value Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AvgGaiNonFarming()
        {
            try
            {
                dashboardView.AvgGaiNonFarming(analyticsModel.AvgGaiNonFarming());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Getting Value Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataTable CountCoopFarmerBarangay()
        {
            try
            {
                DataTable coopTable = analyticsModel.CountCoopBarangay();
                return coopTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Farmers Association Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRecentLetters()
        {
            try
            {
                DataTable lettersTable = analyticsModel.LoadRecentLetters();
                return lettersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Letters Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadLetterNotif()
        {
            try
            {
                DataTable lettersTable = analyticsModel.LoadLetterNotif();
                return lettersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Notification Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public void CountFarmer()
        {
            try
            {
                analyticsRsbsaView.CountFarmer(analyticsModel.CountFarmer());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Getting Value Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CountFisherfolk()
        {
            try
            {
                analyticsRsbsaView.CountFisherfolk(analyticsModel.CountFisherfolk());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Getting Value Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // CHARTS

        public PlotModel CreateBarChart1(DataTable data)
        {
            var model = new PlotModel();
            var barSeries = new BarSeries();

            // Create an X-axis for category labels
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };

            // Create a Y-axis for values
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                MinimumPadding = 0.1,
                MaximumPadding = 0.1,
                IsAxisVisible = false  // Hide the Y-axis
            };

            //// Remove all border-like lines for the entire plot model
            //model.PlotAreaBorderColor = OxyColors.Transparent;

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            foreach (DataRow row in data.Rows)
            {
                string label = row["addrBrgy"].ToString();
                double value = Convert.ToDouble(row["FarmerCount"]);

                // Create a bar item with a specific color (43, 121, 223)
                var barItem = new BarItem { Value = value };
                barItem.Color = OxyColor.FromRgb(43, 121, 223);

                barSeries.Items.Add(barItem);
                categoryAxis.Labels.Add(label); // Add the category label
            }

            model.Series.Add(barSeries);

            return model;
        }

        public PlotModel CreatePieChart1(DataTable data)
        {
            var model = new PlotModel();
            var pieSeries = new PieSeries();

            // Define the fixed colors for each category
            var colors = new List<OxyColor>
            {
                OxyColor.FromRgb(0, 109, 104),    // Green for "Rice"
                OxyColor.FromRgb(255, 221, 100),  // Yellow for "Corn"
                OxyColor.FromRgb(43, 121, 223)   // Blue for "Vegetables"
            };

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                // Assuming that the column names match the data in your stored procedure result
                double isRiceFarmerYes = Convert.ToDouble(row["Count_isRiceFarmerYes"]);
                double isCornFarmerYes = Convert.ToDouble(row["Count_isCornFarmerYes"]);
                double otherCropsNotNo = Convert.ToDouble(row["Count_otherCropsNotNo"]);

                if (isRiceFarmerYes > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Rice", isRiceFarmerYes)
                    {
                        Fill = colors[0] // Green
                    });
                }

                if (isCornFarmerYes > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Corn", isCornFarmerYes)
                    {
                        Fill = colors[1] // Yellow
                    });
                }

                if (otherCropsNotNo > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Vegetables", otherCropsNotNo)
                    {
                        Fill = colors[2] // Blue
                    });
                }
            }

            model.Series.Add(pieSeries);

            return model;
        }

        public PlotModel CreatePieChart2(DataTable data)
        {
            var model = new PlotModel();
            var pieSeries = new PieSeries();

            var colors = new List<OxyColor>
            {
                OxyColor.FromRgb(0, 109, 104),    // Green for "Rice"
                OxyColor.FromRgb(255, 221, 100),  // Yellow for "Corn"
                OxyColor.FromRgb(43, 121, 223)   // Blue for "Vegetables"
            };

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                // Assuming that the column names match the data in your stored procedure result
                double maleCount = Convert.ToDouble(row["male_count"]);
                double femaleCount = Convert.ToDouble(row["female_count"]);

                if (maleCount > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Male", maleCount)
                    {
                        Fill = colors[0]
                    });
                }

                if (femaleCount > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Female", femaleCount)
                    {
                        Fill = colors[1]
                    });
                }
            }

            model.Series.Add(pieSeries);

            return model;
        }

        // DATATABLE

        public DataTable BarCountFarmerBarangay()
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

        public DataTable PieCountFarmerCommodity()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountFarmerCommodity();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Commodity Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable PieCountFarmerSex()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountFarmerSex();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Sex Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // ---------------- RICE --------------------
        public string CountRiceFarmers()
        {
            try
            {
                return analyticsModel.CountRiceFarmers();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalRiceLandArea()
        {
            try
            {
                return analyticsModel.TotalRiceLandArea();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayRice()
        {
            try
            {
                return analyticsModel.TotalBarangayRice();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalRiceAreaPlanted()
        {
            try
            {
                return analyticsModel.TotalRiceAreaPlanted();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public PlotModel CreatePieChartRice1(DataTable data)
        {
            var model = new PlotModel();
            var pieSeries = new PieSeries();

            var colors = new List<OxyColor>
            {
                OxyColor.FromRgb(0, 109, 104),
                OxyColor.FromRgb(255, 221, 100),
                OxyColor.FromRgb(43, 121, 223)
            };

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                // Assuming that the column names match the data in your stored procedure result
                double maleCount = Convert.ToDouble(row["male_count"]);
                double femaleCount = Convert.ToDouble(row["female_count"]);

                if (maleCount > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Male", maleCount)
                    {
                        Fill = colors[0]
                    });
                }

                if (femaleCount > 0)
                {
                    pieSeries.Slices.Add(new PieSlice("Female", femaleCount)
                    {
                        Fill = colors[1]
                    });
                }
            }

            model.Series.Add(pieSeries);

            return model;
        }

        public DataTable PieCountRiceFarmerSex()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountRiceFarmerSex();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateBarChartRice1(DataTable data)
        {
            var model = new PlotModel();
            var barSeries = new BarSeries();

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Count"
            };

            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            OxyColor barColor = OxyColor.FromRgb(0, 109, 104);

            foreach (DataRow row in data.Rows)
            {
                string barangay = row["Barangay"].ToString();
                int count = Convert.ToInt32(row["FarmerCount"]);

                // Create a bar item with the specific color
                var barItem = new BarItem { Value = count, Color = barColor };

                barSeries.Items.Add(barItem);
                categoryAxis.Labels.Add(barangay);
            }

            model.Series.Add(barSeries);

            return model;
        }

        public DataTable BarCountRiceFarmerBarangay()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountRiceFarmerBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }




        // ---------------- CORN --------------------
        public string CountCornFarmers()
        {
            try
            {
                return analyticsModel.CountCornFarmers();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornLandArea()
        {
            try
            {
                return analyticsModel.TotalCornLandArea();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayCorn()
        {
            try
            {
                return analyticsModel.TotalBarangayCorn();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornAreaPlanted()
        {
            try
            {
                return analyticsModel.TotalCornAreaPlanted();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable PieCountCornFarmerSex()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountCornFarmerSex();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // ---------------- HVC --------------------
        public string CountHvcFarmers()
        {
            try
            {
                return analyticsModel.CountHvcFarmers();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalHvcLandArea()
        {
            try
            {
                return analyticsModel.TotalHvcLandArea();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalBarangayHvc()
        {
            try
            {
                return analyticsModel.TotalBarangayHvc();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalHvcAreaPlanted()
        {
            try
            {
                return analyticsModel.TotalHvcAreaPlanted();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }
    }
}
