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
        private WeeklyActivitiesView weeklyActView;
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

        public AnalyticsController(WeeklyActivitiesView weeklyActView)
        {
            this.weeklyActView = weeklyActView;
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

        public AnalyticsController(AnalyticsCropsCornView analyticsCropsCornView)
        {
            this.analyticsCropsCornView = analyticsCropsCornView;
            analyticsModel = new AnalyticsModel();
        }

        public AnalyticsController(AnalyticsCropsHvcView analyticsCropsHvcView)
        {
            this.analyticsCropsHvcView = analyticsCropsHvcView;
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

        public string CountRsbsaFarmers()
        {
            try
            {
                return analyticsModel.CountRsbsaFarmers();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public DataTable BarCountDailyActivities()
        {
            try
            {
                DataTable lettersTable = analyticsModel.CountDailyActivities();
                return lettersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Daily Activities Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable BarCountActivitiesSection()
        {
            try
            {
                DataTable lettersTable = analyticsModel.CountActivitiesSection();
                return lettersTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Daily Activities Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
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

        public PlotModel CreateStackedBarChart1(DataTable data)
        {
            var model = new PlotModel();

            // Create a series for each day of the week
            var daysOfWeek = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            var seriesList = new List<BarSeries>();

            foreach (var day in daysOfWeek)
            {
                var daySeries = new BarSeries { Title = day };
                seriesList.Add(daySeries);
            }

            foreach (DataRow row in data.Rows)
            {
                string section = row["Section"].ToString();
                for (int i = 0; i < daysOfWeek.Length; i++)
                {
                    int progress = Convert.ToInt32(row[daysOfWeek[i]]);
                    if (progress > 0)
                    {
                        seriesList[i].Items.Add(new BarItem { Value = progress });
                    }
                }
            }

            // Add the sections as category labels
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                IsPanEnabled = false,
                IsZoomEnabled = false
            };

            foreach (DataRow row in data.Rows)
            {
                string section = row["Section"].ToString();
                categoryAxis.Labels.Add(section);
            }

            model.Axes.Add(categoryAxis);

            // Set series to the model
            foreach (var series in seriesList)
            {
                model.Series.Add(series);
            }

            return model;
        }

        public PlotModel CreateLineChart1(DataTable data)
        {
            var model = new PlotModel();

            // Create a series for each day of the week
            var daySeries = new LineSeries
            {
                Title = "Progress",
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.Black,
                MarkerFill = OxyColors.LightBlue
            };

            // Set the line color to RGB(43, 121, 223) using OxyColor
            daySeries.Color = OxyColor.FromRgb(43, 121, 223);

            // Days of the week
            var daysOfWeek = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Add data points to the series for each day
            for (int i = 1; i <= 7; i++)
            {
                // Convert the day's count from the data table
                int dayCount = Convert.ToInt32(data.Rows[0][daysOfWeek[i % 7]]);

                // Add a data point with X as the day's index (1-7) and Y as the count
                daySeries.Points.Add(new DataPoint(i, dayCount));
            }

            // Set axis titles
            // Create an X-axis for days of the week
            var dayAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Key = "DayAxis",
                //Title = "Day"
            };

            // Set the labels for the X-axis
            dayAxis.Labels.AddRange(daysOfWeek);

            model.Axes.Add(dayAxis);

            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Key = "CountAxis",
                //Title = "Progress"
            });

            // Add the day series to the model
            model.Series.Add(daySeries);

            return model;
        }

        public PlotModel CreateBarChart2(DataTable data)
        {
            var model = new PlotModel();
            var barSeries = new BarSeries
            {
                FillColor = OxyColor.FromRgb(43, 121, 223) // Set the bar color to RGB(43, 121, 223)
            };

            // Create an X-axis for sections
            var sectionAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Section"
            };

            model.Axes.Add(sectionAxis);

            foreach (DataRow row in data.Rows)
            {
                string section = row["Section"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                barSeries.Items.Add(new BarItem { Value = count });
                sectionAxis.Labels.Add(section);
            }

            model.Series.Add(barSeries);

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

        // ---------------- RSBSA --------------------
        public string CountRsbsaWeeklyReg()
        {
            try
            {
                return analyticsModel.CountRsbsaWeeklyReg();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public PlotModel CreatePieChartRsbsa1(DataTable data)
        {
            var model = new PlotModel();
            var pieSeries = new PieSeries();

            var greenColors = new[]
            {
                Color.FromArgb(1, 97, 94),
                Color.FromArgb(1, 108, 104), // Dark green
                Color.FromArgb(26, 123, 119), // Green
                Color.FromArgb(52, 137, 134),
            };

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];

                string barangay = row["Barangay"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                // Use a green color from the predefined set
                Color sliceColor = greenColors[i % greenColors.Length];

                var slice = new PieSlice(barangay, count)
                {
                    Fill = OxyColor.FromArgb(sliceColor.A, sliceColor.R, sliceColor.G, sliceColor.B),
                };

                pieSeries.Slices.Add(slice);
            }

            // Set the LabelField to display labels outside the pie chart
            pieSeries.LabelField = "Category";
            pieSeries.TickDistance = 0.3; // Adjust the distance of labels from the pie chart

            model.Series.Add(pieSeries);

            return model;
        }

        public PlotModel CreatePieChartRsbsa2(DataTable data)
        {
            var model = new PlotModel();
            var pieSeries = new PieSeries();

            var commodityColors = new Dictionary<string, OxyColor>
    {
        { "Rice", OxyColor.FromArgb(255, 1, 97, 94) },   // Green
        { "Corn", OxyColor.FromArgb(255, 1, 108, 104) },  // Dark Green
        { "HVC", OxyColor.FromArgb(255, 26, 123, 119) },  // Green
        { "Livestocks", OxyColor.FromArgb(255, 52, 137, 134) }, // Greenish Blue
        { "Poultry", OxyColor.FromArgb(255, 78, 151, 149) } // Light Green
    };

            foreach (DataRow row in data.Rows)
            {
                string barangay = row["addrBrgy"].ToString();

                for (int i = 1; i < data.Columns.Count; i++)
                {
                    string commodity = data.Columns[i].ColumnName;
                    int count = Convert.ToInt32(row[commodity]);

                    if (count > 0)
                    {
                        if (commodityColors.TryGetValue(commodity, out OxyColor sliceColor))
                        {
                            var slice = new PieSlice(commodity, count)
                            {
                                Fill = sliceColor
                            };

                            pieSeries.Slices.Add(slice);
                        }
                    }
                }
            }

            // Set the border color to transparent to remove the borders
            model.PlotAreaBorderColor = OxyColors.Transparent;

            model.Axes.Add(new CategoryAxis()); // Remove labels
            model.Axes.Add(new LinearAxis { Position = AxisPosition.None }); // Remove the Y-axis

            model.Series.Add(pieSeries);

            return model;
        }

        public DataTable PieCountCommodityBarangay(string brgy)
        {
            try
            {
                DataTable dataTable = analyticsModel.CountCommodityBarangay(brgy);
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Commodity Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateLineChartRsbsa1(DataTable data)
        {
            var model = new PlotModel();

            // Create the X-axis (category axis) for barangay labels
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Barangay"
            };

            // Create the Y-axis (linear axis) for the count values
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Count"
            };

            // Add the axes to the model
            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            // Create a line series to display the data points
            var lineSeries = new LineSeries
            {
                Title = "Weekly Counts",
                StrokeThickness = 2
            };

            // Populate the line series with data from the DataTable
            foreach (DataRow row in data.Rows)
            {
                string barangay = row["Barangay"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                // Add the barangay label to the category axis
                categoryAxis.Labels.Add(barangay);

                // Add the data point to the line series
                lineSeries.Points.Add(new DataPoint(categoryAxis.Labels.IndexOf(barangay), count));
            }

            // Add the line series to the model
            model.Series.Add(lineSeries);

            return model;
        }

        public DataTable LineCountRsbsaRegBrgy()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountRsbsaRegBrgy();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Weekly Registration Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateGroupedBarChartRsbsa1(DataTable data)
        {
            var model = new PlotModel();

            // Create the category axis for barangay labels on the Y-axis
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Barangay",
                IsTickCentered = true
            };

            // Create the value axis for the count values on the X-axis
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Count"
            };

            // Add the axes to the model
            model.Axes.Add(categoryAxis);
            model.Axes.Add(valueAxis);

            // Define the categories (e.g., 'Farmer', 'Laborer', 'Fisherfolk', 'AgriYouth')
            var categories = new string[] { "Farmer", "Laborer", "Fisherfolk", "AgriYouth" };

            // Define the custom ARGB colors
            var customColors = new OxyColor[]
            {
        OxyColor.FromArgb(255, 0, 35, 76), // ARGB format
        OxyColor.FromArgb(255, 255, 221, 100),
        OxyColor.FromArgb(255, 0, 109, 104),
        OxyColor.FromArgb(255, 43, 121, 223)
            };

            // Create a list to keep track of added barangays
            var addedBarangays = new List<string>();

            // Create a bar series for each category
            for (int i = 0; i < categories.Length; i++)
            {
                var category = categories[i];

                var barSeries = new BarSeries
                {
                    Title = category, // Set the legend title
                    FillColor = customColors[i % customColors.Length]
                };

                // Populate the bar series with data for each barangay
                foreach (DataRow row in data.Rows)
                {
                    string barangay = row["Barangay"].ToString();

                    // Ensure each barangay is added only once
                    if (!addedBarangays.Contains(barangay))
                    {
                        int count = Convert.ToInt32(row[category]);
                        barSeries.Items.Add(new BarItem { Value = count });
                        categoryAxis.Labels.Add(barangay);
                        addedBarangays.Add(barangay);
                    }
                }

                // Add the bar series to the model
                model.Series.Add(barSeries);
            }

            // Add a legend to the model
            model.Legends.Add(new Legend
            {
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.TopCenter
            });

            return model;
        }

        public DataTable BarCountLivelihoodBarangay()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountLivelihoodBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Livelihood Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateBarChartRsbsa1(DataTable data)
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
                barItem.Color = OxyColor.FromRgb(0, 109, 104);

                barSeries.Items.Add(barItem);
                categoryAxis.Labels.Add(label); // Add the category label
            }

            model.Series.Add(barSeries);

            return model;
        }

        public DataTable BarCountFarmerBrgy()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountFarmerBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Farmer Count Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public string TotalCornAreaPlantedYellow()
        {
            try
            {
                return analyticsModel.TotalCornAreaPlantedYellow();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public string TotalCornAreaPlantedWhite()
        {
            try
            {
                return analyticsModel.TotalCornAreaPlantedWhite();
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException("Error getting value: " + ex.Message, ex);
            }
        }

        public PlotModel CreateBarChartCorn1(DataTable data)
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

            OxyColor barColor = OxyColor.FromRgb(255, 221, 100);

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

        public DataTable BarCountCornFarmerBarangay()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountCornFarmerBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
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

        public DataTable BarCountHvcFarmerBarangay()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountHvcFarmerBarangay();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable PieCountHvcFarmerSex()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountHvcFarmerSex();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // ---------------- WEEKLY ACTIVITIES --------------------

        public DataTable LoadWeeklyActivities()
        {
            try
            {
                DataTable actsTable = analyticsModel.LoadWeeklyActivitiesDtaGrid();
                return actsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Weekly Activities Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
