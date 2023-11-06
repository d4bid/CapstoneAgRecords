using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.Controller
{
    public class CropsCornController
    {
        private CropsCornView cropsCornView;
        private CornAddView cornAddView;
        private CropsCornAddView cropsCornAddView;
        private CropsCornEditView cropsCornEditView;

        private CornModel cornModel;
        UserModel userModel = new UserModel();
        private Boolean isDone = false;

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public CropsCornController(CropsCornView cropsCornView)
        {
            this.cropsCornView = cropsCornView;
            cornModel = new CornModel();
        }

        public CropsCornController(CropsCornAddView cropsCornAddView)
        {
            this.cropsCornAddView = cropsCornAddView;
            cornModel = new CornModel();
        }

        public CropsCornController(CropsCornEditView cropsCornEditView)
        {
            this.cropsCornEditView = cropsCornEditView;
            cornModel = new CornModel();
        }

        public CropsCornController(CornAddView cornAddView)
        {
            this.cornAddView = cornAddView;
            cornModel = new CornModel();
        }


        // Get createdBy
        public string GetUserIdByFullName(string fullName)
        {
            try
            {
                return userModel.FindUserIDByFullName(fullName);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding User ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        // Generate ID
        public void GenerateNewCornID()
        {
            try
            {
                cornAddView.GenerateNewCornId(cornModel.GenerateNextCornId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // PLANTING ECO
        public bool AddCornPlantingEcoReport(string cornPrId, string season, string seasonYear, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                CornReport cr = new CornReport()
                {
                    cornPrId = cornPrId,
                    season = season,
                    seasonYear = seasonYear,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (cr.cornPrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.season == "")
                {
                    MessageBox.Show("Season is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.seasonYear == "")
                {
                    MessageBox.Show("Season Year is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.cornPrId != "" && cr.month != "" && cr.week != "" && cr.year != "")
                {
                    if (cornModel.AddCornPlantingEcoRep(cr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Standing Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userModel.InserActionLog(username, "Insert", "Crops Corn Report", $"{cornPrId} added successfully.");
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "Crops Corn Report", $"{cornPrId} adding failed.");
                return false;
            }
        }

        public CornReport GetCornPlantingEcoReportById(string cornPrId)
        {
            try
            {
                return cornModel.GetCornPlantingEcoReportById(cornPrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingEcoReportView(string column, string keyword)
        {
            try
            {
                DataTable cornPlantingTable = cornModel.LoadCornPlantingEcoReportDataGrid(column, keyword);
                return cornPlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        //public DataTable LoadCornPlantingEcoReportView()
        //{
        //    try
        //    {
        //        DataTable cornReportTable = cornModel.LoadCornPlantingEcoReportDataGrid();
        //        return cornReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Corn Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        public bool AddCornPlantingEco(string cornPrId, int brgyId, int landTypeId, int growthStageId, int seedTypeId, int colorTypeId, float size, DateTime logDate)
        {
            try
            {
                CornPlantingEco cpe = new CornPlantingEco()
                {
                    cornPrId = cornPrId,
                    brgyId = brgyId,
                    landTypeId = landTypeId,
                    growthStageId = growthStageId,
                    seedTypeId = seedTypeId,
                    colorTypeId = colorTypeId,
                    size = size,
                    logDate = logDate
                };

                if (cpe.cornPrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cpe.brgyId == 0)
                {
                    MessageBox.Show("Barangay is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cpe.landTypeId == 0)
                {
                    MessageBox.Show("Land type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.growthStageId == 0)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.seedTypeId == 0)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.colorTypeId == 0)
                {
                    MessageBox.Show("Color is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.size == 0.00f)
                {
                    MessageBox.Show("Size is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.cornPrId != "" && cpe.brgyId != 0 && cpe.landTypeId != 0 && cpe.growthStageId != 0 && cpe.seedTypeId != 0 && cpe.size != 0)
                {
                    if (cornModel.AddCornPlantingEco(cpe))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Corn Planting Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool UpdateCornPlantingEco(int cornPlantingEcoId, int brgyId, int landTypeId, int growthStageId, int seedTypeId, int colorTypeId, float size, DateTime logDate)
        {
            try
            {
                CornPlantingEco cpe = new CornPlantingEco()
                {
                    cornPlantingEcoId = cornPlantingEcoId,
                    brgyId = brgyId,
                    landTypeId = landTypeId,
                    growthStageId = growthStageId,
                    seedTypeId = seedTypeId,
                    colorTypeId = colorTypeId,
                    size = size,
                    logDate = logDate
                };

                if (cpe.cornPlantingEcoId == 0)
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cpe.brgyId == 0)
                {
                    MessageBox.Show("Barangay is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cpe.landTypeId == 0)
                {
                    MessageBox.Show("Land type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.growthStageId == 0)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.seedTypeId == 0)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.colorTypeId == 0)
                {
                    MessageBox.Show("Color is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.size == 0)
                {
                    MessageBox.Show("Size is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cpe.cornPlantingEcoId != 0 && cpe.brgyId != 0 && cpe.landTypeId != 0 && cpe.growthStageId != 0 && cpe.seedTypeId != 0 && cpe.colorTypeId != 0 && cpe.size != 0)
                {
                    if (cornModel.UpdateCornPlantingEco(cpe))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update Corn Planting Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool MoveNextCornPlantingEco(string cornPrId)
        {
            try
            {
                CornPlantingEco cpe = new CornPlantingEco()
                {
                    cornPrId = cornPrId,
                };

                if (cpe.cornPrId == "")
                {
                    MessageBox.Show("Corn Planting Record Id is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cpe.cornPrId != null)
                {
                    if (cornModel.MoveNextCornPlantingEco(cpe))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Move Corn Planting Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public CornPlantingEco GetCornPlantingEcoById(int cornPlantingEcoId)
        {
            try
            {
                return cornModel.GetCornPlantingEcoById(cornPlantingEcoId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingEcoView(string cornPrId, int colorId, int growthId, int seedId)
        {
            try
            {
                DataTable cornPlantingTable = cornModel.LoadCornPlantingEcoDataGrid(cornPrId, colorId, growthId, seedId);
                return cornPlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting By Ecological Zone Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // PLANTING
        public bool AddCornPlantingReport(string cornPrId, string season, string seasonYear, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                CornReport cr = new CornReport()
                {
                    cornPrId = cornPrId,
                    season = season,
                    seasonYear = seasonYear,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (cr.cornPrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.season == "")
                {
                    MessageBox.Show("Season is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.seasonYear == "")
                {
                    MessageBox.Show("Season Year is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.cornPrId != "" && cr.month != "" && cr.week != "" && cr.year != "")
                {
                    if (cornModel.AddCornPlantingRep(cr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Standing Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public CornReport GetCornPlantingReportById(string cornPrId)
        {
            try
            {
                return cornModel.GetCornPlantingReportById(cornPrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingReportView(string column, string keyword)
        {
            try
            {
                DataTable cornPlantingTable = cornModel.LoadCornPlantingReportDataGrid(column, keyword);
                return cornPlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingView(string cornPrId, int seedId, int colorId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingDataGrid(cornPrId, seedId, colorId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public CornPlanting GetCornPlantingById(int cornPlantingId)
        {
            try
            {
                return cornModel.GetCornPlantingById(cornPlantingId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }


        //public DataTable LoadCornPlantingReportView()
        //{
        //    try
        //    {
        //        DataTable cornReportTable = cornModel.LoadCornPlantingReportDataGrid();
        //        return cornReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Corn Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        // HARVESTING

        public bool AddCornHarvestingReport(string cornPrId, string season, string seasonYear, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                CornReport cr = new CornReport()
                {
                    cornPrId = cornPrId,
                    season = season,
                    seasonYear = seasonYear,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (cr.cornPrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.season == "")
                {
                    MessageBox.Show("Season is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.seasonYear == "")
                {
                    MessageBox.Show("Season Year is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (cr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cr.cornPrId != "" && cr.month != "" && cr.week != "" && cr.year != "")
                {
                    if (cornModel.AddCornHarvestingRep(cr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Standing Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public CornReport GetCornHarvestingReportById(string cornPrId)
        {
            try
            {
                return cornModel.GetCornHarvestingReportById(cornPrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public bool UpdateCornHarvesting(int cornHarvestingId, float yield)
        {
            try
            {
                CornHarvesting ch = new CornHarvesting()
                {
                    cornHarvestingId = cornHarvestingId,
                    yield = yield
                };

                if (ch.yield == 0)
                {
                    MessageBox.Show("Ave. Yield is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (ch.yield != 0)
                {
                    if (cornModel.UpdateCornHarvesting(ch))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public DataTable LoadCornHarvestingReportView(string column, string keyword)
        {
            try
            {
                DataTable cornPlantingTable = cornModel.LoadCornHarvestingReportDataGrid(column, keyword);
                return cornPlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        //public DataTable LoadCornHarvestingReportView()
        //{
        //    try
        //    {
        //        DataTable cornReportTable = cornModel.LoadCornHarvestingReportDataGrid();
        //        return cornReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Corn Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        public DataTable LoadCornHarvestingView(string cornPrId, int seedId, int colorId, int landId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingDataGrid(cornPrId, seedId, colorId, landId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public CornHarvesting GetCornHarvestingById(int cornHarvestingId)
        {
            try
            {
                return cornModel.GetCornHarvestingById(cornHarvestingId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // PRINTING REPORTS

        // Planting
        public DataTable LoadCornPlantingGmoHybridView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingGmoHybridDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingOpvGreenSweetView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingOpvGreenSweetDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingTraditionalGrandTotalView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingTraditionalGrandTotalDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // Planting Eco
        public DataTable LoadCornPlantingEcoYellowView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingEcoYellowDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting By Ecological Zone Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingEcoWhiteView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingEcoWhiteDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting By Ecological Zone Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornPlantingEcoTotalView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornPlantingEcoTotalDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Planting By Ecological Zone Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // Harvesting
        public DataTable LoadCornHarvestingGmoView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingGmoDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornHarvestingHybridView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingHybridDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornHarvestingOpvView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingOpvDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornHarvestingGreenSweetView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingGreenSweetDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornHarvestingTraditionalView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingTraditionalDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadCornHarvestingTotalView(string cornPrId)
        {
            try
            {
                DataTable cornTable = cornModel.LoadCornHarvestingTotalDataGrid(cornPrId);
                return cornTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Corn Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
