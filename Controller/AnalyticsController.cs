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

        public string CountTotalBarangay()
        {
            try
            {
                return analyticsModel.CountTotalBarangay();
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
                barItem.Color = OxyColor.FromRgb(0, 109, 104);

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

            if (data != null && data.Rows.Count > 0)
            {
                // Add data points to the series for each day
                for (int i = 1; i <= 7; i++)
                {
                    // Convert the day's count from the data table
                    int dayCount = Convert.ToInt32(data.Rows[0][daysOfWeek[i % 7]]);

                    // Add a data point with X as the day's index (1-7) and Y as the count
                    daySeries.Points.Add(new DataPoint(i, dayCount));
                }
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

            // Create a bar series
            var barSeries = new BarSeries
            {
                FillColor = OxyColor.FromRgb(0, 109, 104) // Set the bar color to a custom RGB color (green)
            };

            // Create a category axis for sections on the y-axis
            var sectionAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Section",
            };

            // Create a linear axis for count on the x-axis
            var countAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Count",
                TitleColor = OxyColors.Black, // Set the title color
                TextColor = OxyColors.Black,  // Set the axis label color
            };

            model.Axes.Add(sectionAxis);
            model.Axes.Add(countAxis);

            foreach (DataRow row in data.Rows)
            {
                string section = row["Section"].ToString();
                int count = Convert.ToInt32(row["Count"]);

                // Add data to the bar series
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
                { "Rice", OxyColor.FromRgb(6, 76, 76) },   // Green
                { "Corn", OxyColor.FromRgb(0, 109, 104) },  // Dark Green
                { "HVC", OxyColor.FromRgb(57, 137, 137) },  // Green
                { "Livestocks", OxyColor.FromRgb(107, 167, 167) }, // Greenish Blue
                { "Poultry", OxyColor.FromRgb(206, 226, 226) } // Light Green
            };

            foreach (DataRow row in data.Rows)
            {
                string barangay = row["addrBrgy"].ToString();

                for (int i = 1; i < data.Columns.Count; i++)
                {
                    string commodity = data.Columns[i].ColumnName;
                    int count = Convert.IsDBNull(row[commodity]) ? 0 : Convert.ToInt32(row[commodity]);

                    if (commodityColors.TryGetValue(commodity, out OxyColor sliceColor))
                    {
                        // Check if the count is greater than zero
                        if (count > 0)
                        {
                            var slice = new PieSlice(commodity, count)
                            {
                                Fill = sliceColor
                            };

                            pieSeries.Slices.Add(slice);
                        }
                        else
                        {
                            // If count is zero or negative, you can add an empty slice with a label
                            var slice = new PieSlice(commodity, 0)
                            {
                                Fill = OxyColor.FromRgb(200, 200, 200), // A color for zero count
                            };

                            pieSeries.Slices.Add(slice);
                        }
                    }
                }
            }

            pieSeries.InsideLabelFormat = string.Empty;

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
                Title = "Count",
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

        public DataTable LineCountRsbsaRegBrgy(string interval)
        {
            try
            {
                DataTable dataTable = analyticsModel.CountRsbsaRegBrgy(interval);
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
                //Title = "Barangay",
                IsTickCentered = true
            };

            // Create the value axis for the count values on the X-axis
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                //Title = "Count"
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

        public DataTable ShowRiceProduction()
        {
            try
            {
                DataTable dataTable = analyticsModel.GetRiceProduction();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Data Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
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

        public PlotModel CreateCircularProgressChartRice1(DataTable data)
        {
            var model = new PlotModel();

            double areaPlanted = 0;
            double areaHarvested = 0;

            if (data != null && data.Rows.Count > 0)
            {
                if (data.Columns.Contains("Area Planted") && data.Rows[0]["Area Planted"] != DBNull.Value)
                {
                    areaPlanted = Convert.ToDouble(data.Rows[0]["Area Planted"]);
                }

                if (data.Columns.Contains("Area Harvested") && data.Rows[0]["Area Harvested"] != DBNull.Value)
                {
                    areaHarvested = Convert.ToDouble(data.Rows[0]["Area Harvested"]);
                }
            }

            // Calculate percentages
            var harvestedPercentage = areaPlanted > 0 ? (areaHarvested / areaPlanted) * 100 : 0;
            var remainingPercentage = areaPlanted > 0 ? 100 - harvestedPercentage : 0;

            var pieSeries = new PieSeries
            {
                StartAngle = 0,
                Diameter = 0.8,
                InnerDiameter = 0.6,
                ExplodedDistance = 0.0 // Set to 0 for a donut-like appearance
            };

            // Add the harvested slice
            pieSeries.Slices.Add(new PieSlice(null, harvestedPercentage)
            {
                Fill = OxyColor.FromRgb(0, 109, 104) // Color for harvested
            });

            // Add the remaining slice
            pieSeries.Slices.Add(new PieSlice(null, remainingPercentage)
            {
                Fill = areaPlanted == 0 ? OxyColor.FromRgb(43, 121, 223) : OxyColor.FromRgb(255, 221, 100) // Color for remaining
            });

            // Add the legend
            var legend = new Legend();
            legend.LegendPosition = LegendPosition.BottomCenter;
            legend.LegendOrientation = LegendOrientation.Horizontal;
            legend.LegendPlacement = LegendPlacement.Outside;

            model.Legends.Add(legend);
            model.Series.Add(pieSeries);

            return model;
        }

        public DataTable PieCountHarvestedOutOfPlanted()
        {
            try
            {
                DataTable dataTable = analyticsModel.CountHarvestedOutOfPlanted();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateBarChartRiceLandArea(DataTable data)
        {
            var model = new PlotModel();

            var barSeries = new BarSeries();
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };

            // Define custom colors for each bar
            OxyColor irrigatedColor = OxyColor.FromRgb(43, 121, 223);   // Green
            OxyColor uplandColor = OxyColor.FromRgb(255, 221, 100);     // Yellow
            OxyColor lowlandColor = OxyColor.FromRgb(0, 109, 104);    // Blue

            foreach (DataRow row in data.Rows)
            {
                double irrigated = Convert.ToDouble(row["Irrigated"]);
                double rainfedUpland = Convert.ToDouble(row["Rainfed Upland"]);
                double rainfedLowland = Convert.ToDouble(row["Rainfed Lowland"]);

                // Adding data to the bar series with custom colors
                barSeries.Items.Add(new BarItem { Value = irrigated, Color = irrigatedColor });
                barSeries.Items.Add(new BarItem { Value = rainfedUpland, Color = uplandColor });
                barSeries.Items.Add(new BarItem { Value = rainfedLowland, Color = lowlandColor });

                // Adding category labels
                categoryAxis.Labels.Add("Irrigated");
                categoryAxis.Labels.Add("Rainfed Upland");
                categoryAxis.Labels.Add("Rainfed Lowland");
            }

            model.Axes.Add(categoryAxis);

            // Adding the bar series to the model
            model.Series.Add(barSeries);

            return model;
        }

        public DataTable BarTotalRiceLandAreaPerFarmType()
        {
            try
            {
                DataTable dataTable = analyticsModel.TotalRiceLandAreaPerFarmType();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // FORECASTING

        public PlotModel CreateLineSeriesChartRiceForecast(List<int> years, List<double> forecastedProduction)
        {
            // Create a new PlotModel
            var model = new PlotModel();

            // Create a LineSeries for forecasted production
            var forecastedProductionSeries = new LineSeries
            {
                Title = "Forecasted Production",
                MarkerType = MarkerType.Circle, // Set the point marker as circles
                MarkerSize = 4,
                MarkerStroke = OxyColor.FromRgb(0, 109, 104),
                MarkerFill = OxyColor.FromRgb(43, 121, 223),
                LineStyle = LineStyle.Solid // Set the line style to Solid for a continuous line
            };

            // Add forecasted data points to the series
            for (int i = 0; i < forecastedProduction.Count; i++)
            {
                forecastedProductionSeries.Points.Add(new DataPoint(i, forecastedProduction[i]));
            }

            // Add the series to the model
            model.Series.Add(forecastedProductionSeries);

            // Create a StringAxis for the x-axis to display whole years
            var xAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Year"
            };

            // Add the years as labels to the x-axis
            foreach (int year in years)
            {
                xAxis.Labels.Add(year.ToString());
            }

            model.Axes.Add(xAxis);

            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Production" });

            return model;
        }

        public ProductionData Forecasting()
        {
            // Initialize with the current year
            int currentYear = DateTime.Now.Year;

            // Define initial historical data for the years 2019 to 2021 as a basis for forecasting
            List<int> historicalYears = new List<int> { 2019, 2020, 2021 };
            List<double> historicalProduction = new List<double> { 46977.84, 42632.51, 49218.22 };

            // Create lists to store forecasted data
            List<int> forecastedYears = new List<int>();
            List<double> forecastedProduction = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                // Get the past year as the actual data from the database
                int pastYear = currentYear - 1;
                double actualPastYear = GetRiceProductionActual(pastYear);

                // Calculate the weighted moving average forecast for the current year
                double forecastCurrentYear = CalculateWeightedMovingAverage(historicalYears, historicalProduction, currentYear);

                // Update the dataset with the forecasted production for the current year
                historicalYears.Add(currentYear);
                historicalProduction.Add(forecastCurrentYear);

                // Store the forecasted year and production
                forecastedYears.Add(currentYear);
                forecastedProduction.Add(forecastCurrentYear);

                // Move to the next year and update the historical data for the next iteration
                currentYear++;
                historicalYears.RemoveAt(0);
                historicalProduction.RemoveAt(0);
            }

            // Return historical and forecasted data
            return new ProductionData
            {
                Years = forecastedYears,
                ForecastedProduction = forecastedProduction
            };
        }

        // Database actual data retrieval
        public double GetRiceProductionActual(int year)
        {
           return analyticsModel.RiceProductionActual(year);
        }

        // Weighted Moving Average calculation
        static double CalculateWeightedMovingAverage(List<int> years, List<double> production, int yearToForecast)
        {
            int n = years.Count;
            int windowSize = 3;  // Adjust the window size as needed
            double forecast = 0;

            if (n >= windowSize)
            {
                double weightedSum = 0;
                double weightSum = 0;

                for (int i = n - windowSize; i < n; i++)
                {
                    double weight = (i - (n - windowSize) + 1);
                    weightedSum += production[i] * weight;
                    weightSum += weight;
                }

                forecast = weightedSum / weightSum;
            }

            return forecast;
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

        public DataTable ShowCornProduction()
        {
            try
            {
                DataTable dataTable = analyticsModel.GetCornProduction();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Data Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
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

        public PlotModel CreateLineSeriesChartCornForecast(List<int> years, List<double> forecastedProduction)
        {
            // Create a new PlotModel
            var model = new PlotModel();

            // Create a LineSeries for forecasted production
            var forecastedProductionSeries = new LineSeries
            {
                Title = "Forecasted Production",
                MarkerType = MarkerType.Circle, // Set the point marker as circles
                MarkerSize = 4,
                MarkerStroke = OxyColor.FromRgb(0, 109, 104),
                MarkerFill = OxyColor.FromRgb(43, 121, 223),
                LineStyle = LineStyle.Solid // Set the line style to Solid for a continuous line
            };

            // Add forecasted data points to the series
            for (int i = 0; i < forecastedProduction.Count; i++)
            {
                forecastedProductionSeries.Points.Add(new DataPoint(i, forecastedProduction[i]));
            }

            // Add the series to the model
            model.Series.Add(forecastedProductionSeries);

            // Create a StringAxis for the x-axis to display whole years
            var xAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Year"
            };

            // Add the years as labels to the x-axis
            foreach (int year in years)
            {
                xAxis.Labels.Add(year.ToString());
            }

            model.Axes.Add(xAxis);

            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Production" });

            return model;
        }

        public ProductionData CornForecasting()
        {
            // Initialize with the current year
            int currentYear = DateTime.Now.Year;

            // Define initial historical data for the years 2019 to 2021 as a basis for forecasting
            List<int> historicalYears = new List<int> { 2019, 2020, 2021 };
            List<double> historicalProduction = new List<double> { 30234.84, 36030.51, 35039.22 };

            // Create lists to store forecasted data
            List<int> forecastedYears = new List<int>();
            List<double> forecastedProduction = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                // Get the past year as the actual data from the database
                int pastYear = currentYear - 1;
                double actualPastYear = GetCornProductionActual(pastYear);

                // Calculate the weighted moving average forecast for the current year
                double forecastCurrentYear = CalculateWeightedMovingAverage(historicalYears, historicalProduction, currentYear);

                // Update the dataset with the forecasted production for the current year
                historicalYears.Add(currentYear);
                historicalProduction.Add(forecastCurrentYear);

                // Store the forecasted year and production
                forecastedYears.Add(currentYear);
                forecastedProduction.Add(forecastCurrentYear);

                // Move to the next year and update the historical data for the next iteration
                currentYear++;
                historicalYears.RemoveAt(0);
                historicalProduction.RemoveAt(0);
            }

            // Return historical and forecasted data
            return new ProductionData
            {
                Years = forecastedYears,
                ForecastedProduction = forecastedProduction
            };
        }

        // Database actual data retrieval
        public double GetCornProductionActual(int year)
        {
            return analyticsModel.CornProductionActual(year);
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

        public DataTable ListHvc()
        {
            try
            {
                DataTable dataTable = analyticsModel.GetHvcList();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
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

        public PlotModel CreateBarChartHvc1(DataTable data)
        {
            var model = new PlotModel();
            var barSeries = new BarSeries
            {
                Title = "Total Size",
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1,
                FillColor = OxyColor.FromRgb(0, 109, 104)
            };

            // Create a Y-axis for crop types
            var cropAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Crop Type"
            };

            // Create an X-axis for the total size
            var sizeAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Total Size (ha)"
            };

            model.Axes.Add(cropAxis);
            model.Axes.Add(sizeAxis);

            foreach (DataRow row in data.Rows)
            {
                string crop = row["Crop"].ToString();
                double totalSize = Convert.ToDouble(row["TotalSize"]);

                barSeries.Items.Add(new BarItem { Value = totalSize });
                cropAxis.Labels.Add(crop);
            }

            model.Series.Add(barSeries);

            return model;
        }

        public DataTable BarTotalStandingHvc()
        {
            try
            {
                DataTable dataTable = analyticsModel.TotalStandingHvc();
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Graph Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public PlotModel CreateHvcProgressionChart(DataTable data)
        {
            var model = new PlotModel();

            // Define a dictionary to map stage IDs to their corresponding names
            var stageNames = new Dictionary<string, string>
            {
                { "1", "Newly Transplanted" },
                { "2", "Vegetative" },
                { "3", "Reproductive" },
                { "4", "Maturity/Harvestable" }
            };

            // Create a category axis for stages on the X-axis
            var stageAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Stage"
            };

            // Map stage IDs to their corresponding names for the X-axis labels
            stageAxis.Labels.AddRange(stageNames.Values);

            model.Axes.Add(stageAxis);

            // Create a linear axis for the Y-axis to show the crop names
            var cropAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Crop"
            };

            // Retrieve the list of unique crop names from the data
            var cropNames = data.AsEnumerable().Select(row => row.Field<string>("Crop")).Distinct().ToList();

            // Map crop names to the Y-axis labels
            cropAxis.Labels.AddRange(cropNames);

            model.Axes.Add(cropAxis);

            // Create line series for each crop
            foreach (string cropName in cropNames)
            {
                var lineSeries = new LineSeries
                {
                    Title = cropName,
                    Color = OxyColor.FromRgb(0, 109, 104), // Set the line color to red (255, 0, 0)
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 4,
                    MarkerStroke = OxyColor.FromRgb(0, 109, 104),
                    MarkerFill = OxyColor.FromRgb(0, 109, 104)
                };

                string previousStage = "1"; // Initialize with the first stage

                // Iterate through stages to add points and connect with lines
                for (int stageIndex = 1; stageIndex <= 4; stageIndex++)
                {
                    string stageId = stageIndex.ToString();
                    var row = data.Select($"Crop = '{cropName}' AND Stage = '{stageId}'").FirstOrDefault();

                    if (row != null)
                    {
                        // Add the point for the current stage
                        lineSeries.Points.Add(new DataPoint(stageAxis.Labels.IndexOf(stageNames[stageId]), cropAxis.Labels.IndexOf(cropName)));

                        // Add a line connecting the previous stage to the current stage
                        if (stageIndex > 1)
                        {
                            lineSeries.Points.Add(new DataPoint(stageAxis.Labels.IndexOf(stageNames[previousStage]), cropAxis.Labels.IndexOf(cropName)));
                        }

                        previousStage = stageId;
                    }
                }

                model.Series.Add(lineSeries);
            }

            return model;
        }

        public DataTable LineHvcProgression(string month, string week)
        {
            try
            {
                DataTable dataTable = analyticsModel.HvcStageProgression(month, week);
                return dataTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Progression Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        // ---------------- WEEKLY ACTIVITIES --------------------

        public DataTable LoadWeeklyActivities(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable actsTable = analyticsModel.LoadWeeklyActivitiesDtaGrid(fromDate, toDate);
                return actsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Weekly Activities Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadActivitiesSummary(DateTime fromDate, DateTime toDate)
        {
            try
            {
                DataTable actsTable = analyticsModel.LoadActivitiesSummaryDtaGrid(fromDate, toDate);
                return actsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Summary Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
