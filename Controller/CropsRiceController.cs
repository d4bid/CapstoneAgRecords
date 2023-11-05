using AgRecords.Model;
using AgRecords.View;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgRecords.Controller
{
    public class CropsRiceController
    {
        private CropsRiceView cropsRiceView;
        private RiceAddView riceAddView;
        private CropsRiceAddView cropsRiceAddView;
        private CropsRiceEditView cropsRiceEditView;

        private RiceModel riceModel;
        UserModel userModel = new UserModel();
        private Boolean isDone = false;

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public CropsRiceController(CropsRiceView cropsRiceView)
        {
            this.cropsRiceView = cropsRiceView;
            riceModel = new RiceModel();
        }

        public CropsRiceController(CropsRiceAddView cropsRiceAddView)
        {
            this.cropsRiceAddView = cropsRiceAddView;
            riceModel = new RiceModel();
        }

        public CropsRiceController(RiceAddView riceAddView)
        {
            this.riceAddView = riceAddView;
            riceModel = new RiceModel();
        }

        public CropsRiceController(CropsRiceEditView cropsRiceEditView)
        {
            this.cropsRiceEditView = cropsRiceEditView;
            riceModel = new RiceModel();
        }


        //public DataTable LoadRicePlantingReportView()
        //{
        //    try
        //    {
        //        DataTable riceReportTable = riceModel.LoadRicePlantingReportDataGrid();
        //        return riceReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Rice Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        //public DataTable LoadRiceStandingReportView()
        //{
        //    try
        //    {
        //        DataTable riceReportTable = riceModel.LoadRiceStandingReportDataGrid();
        //        return riceReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Rice Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        //public DataTable LoadRiceHarvestingReportView()
        //{
        //    try
        //    {
        //        DataTable riceReportTable = riceModel.LoadRiceHarvestingReportDataGrid();
        //        return riceReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Rice Report Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        public DataTable LoadRicePlantingReportView(string column, string keyword)
        {
            try
            {
                DataTable ricePlantingTable = riceModel.LoadRicePlantingReportDataGrid(column, keyword);
                return ricePlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceStandingReportView(string column, string keyword)
        {
            try
            {
                DataTable ricePlantingTable = riceModel.LoadRiceStandingReportDataGrid(column, keyword);
                return ricePlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceHarvestingReportView(string column, string keyword)
        {
            try
            {
                DataTable ricePlantingTable = riceModel.LoadRiceHarvestingReportDataGrid(column, keyword);
                return ricePlantingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public RicePlantingRep GetRicePlantReportById(string riceSrId)
        {
            try
            {
                return riceModel.GetRicePlantReportById(riceSrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public RiceHarvestingRep GetRiceHarvestReportById(string riceSrId)
        {
            try
            {
                return riceModel.GetRiceHarvestReportById(riceSrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // STANDING

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

        // Get riceSrId
        public RiceStandingRep GetRiceStandReportById(string riceSrId)
        {
            try
            {
                return riceModel.GetRiceStandReportById(riceSrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public int GetMaxRiceStandingLogId(string riceSrId)
        {
            try
            {
                return riceModel.GetMaxRiceStandingLogId(riceSrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error getting log ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }


        public void GenerateNewRiceStandID()
        {
            try
            {
                riceAddView.GenerateNewRiceStandId(riceModel.GenerateNextStandId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Add Rice Standing Report
        public bool AddRiceStandingReport(string riceSrId, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                RiceStandingRep rsr = new RiceStandingRep()
                {
                    riceSrId = riceSrId,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (rsr.riceSrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rsr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rsr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsr.riceSrId != "" && rsr.month!= "" && rsr.week != "" && rsr.year != "")
                {
                    if (riceModel.AddRiceStandingRep(rsr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Standing Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        userModel.InserActionLog(username, "Insert", "Crops Rice Report", $"{riceSrId} added successfully.");
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Rice Standing Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "Crops Rice Report", $"{riceSrId} adding failed.");
                return false;
            }
        }

        public bool AddRiceStandingLogs(string riceSrId, int brgyId, int farmTypeId, int growthStageId, int seedTypeId, float size, DateTime logDate)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                    brgyId = brgyId,
                    farmTypeId = farmTypeId,
                    growthStageId = growthStageId,
                    seedTypeId = seedTypeId,
                    size = size,
                    logDate = logDate
                };

                if (rs.riceSrId == "")
                {
                    MessageBox.Show("Rice Standing Record Id is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rs.brgyId == 0)
                {
                    MessageBox.Show("Barangay is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rs.farmTypeId == 0)
                {
                    MessageBox.Show("Farm type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.growthStageId == 0)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.seedTypeId == 0)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.size == 0.00f)
                {
                    MessageBox.Show("Size is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.riceSrId != null && rs.brgyId != 0 && rs.farmTypeId != 0 && rs.growthStageId != 0 && rs.seedTypeId != 0 && rs.size != 0)
                {
                    if (riceModel.AddRiceStandingLogs(rs))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Rice Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool MoveNextStandingLogs(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                if (rs.riceSrId == "")
                {
                    MessageBox.Show("Rice Standing Record Id is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rs.riceSrId != null)
                {
                    if (riceModel.MoveNextRiceStandingLogs(rs))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Move Rice Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool UpdateRiceStandingLog(int riceStandingLogsId,int brgyId, int farmTypeId, int growthStageId, int seedTypeId, float size, DateTime logDate)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceStandingLogsId = riceStandingLogsId,
                    brgyId = brgyId,
                    farmTypeId = farmTypeId,
                    growthStageId = growthStageId,
                    seedTypeId = seedTypeId,
                    size = size,
                    logDate = logDate
                };

                if (rs.brgyId == null)
                {
                    MessageBox.Show("Barangay is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rs.farmTypeId == null)
                {
                    MessageBox.Show("Farm type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.growthStageId == null)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.seedTypeId == null)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rs.brgyId != null && rs.farmTypeId != null && rs.growthStageId != null && rs.seedTypeId != null)
                {
                    if (riceModel.UpdateRiceStandingLog(rs))
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

        public DataTable LoadRiceStandLogsView(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                DataTable riceStandLogsTable = riceModel.LoadRiceStandLogsDataGrid(rs);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable LoadIrrigatedRiceStandLogsView(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                DataTable riceStandLogsTable = riceModel.LoadIrrigatedRiceStandLogsDataGrid(rs);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable LoadLowlandRiceStandLogsView(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                DataTable riceStandLogsTable = riceModel.LoadLowlandRiceStandLogsDataGrid(rs);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable LoadUplandRiceStandLogsView(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                DataTable riceStandLogsTable = riceModel.LoadUplandRiceStandLogsDataGrid(rs);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable LoadLowlandUplandRiceStandLogsView(string riceSrId)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                };

                DataTable riceStandLogsTable = riceModel.LoadLowlandUplandRiceStandLogsDataGrid(rs);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable LoadRiceStandingView(string riceSrId, int farmId, int seedId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceStandingDataGrid(riceSrId, farmId, seedId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceStandingTotalView(string riceSrId, int farmId, int seedId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceStandingTotalDataGrid(riceSrId, farmId, seedId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceStandingGrandTotalView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceStandingGrandTotalDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Grand Total Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }


        // Get riceStandingLogsId
        public RiceStanding GetRiceStandingLogsById(int riceStandingLogsId)
        {
            try
            {
                return riceModel.GetRiceStandingLogsById(riceStandingLogsId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // PLANTING

        // Add Rice Planting Report
        public bool AddRicePlantingReport(string riceSrId, string season, string seasonYear, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                RicePlantingRep rpr = new RicePlantingRep()
                {
                    riceSrId = riceSrId,
                    season = season,
                    seasonYear = seasonYear,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (rpr.riceSrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rpr.season == null)
                {
                    MessageBox.Show("Season is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rpr.seasonYear == null)
                {
                    MessageBox.Show("Season Year is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rpr.month == null)
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rpr.week == null)
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rpr.year == null)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rpr.riceSrId != null && rpr.month != null && rpr.week != null && rpr.year != null)
                {
                    if (riceModel.AddRicePlantingRep(rpr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Planting Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Rice Planting Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public RicePlanting GetRicePlantingById(int ricePlantingId)
        {
            try
            {
                return riceModel.GetRicePlantingById(ricePlantingId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRicePlantingView(string riceSrId, int farmId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRicePlantingDataGrid(riceSrId, farmId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // HARVESTING

        public bool AddRiceHarvestingReport(string riceSrId, string season, string seasonYear, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                RiceHarvestingRep rhr = new RiceHarvestingRep()
                {
                    riceSrId = riceSrId,
                    season = season,
                    seasonYear = seasonYear,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (rhr.riceSrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rhr.season == "")
                {
                    MessageBox.Show("Season is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rhr.seasonYear == "")
                {
                    MessageBox.Show("Season Year is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rhr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rhr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rhr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rhr.riceSrId != "" && rhr.month != "" && rhr.week != "" && rhr.year != "" )
                {
                    if (riceModel.AddRiceHarvestingRep(rhr))
                    {
                        isDone = true;
                        //MessageBox.Show("Rice Planting Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Rice Harvesting Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool UpdateRiceHarvesting(int riceHarvestingId, float yield)
        {
            try
            {
                RiceHarvesting rh = new RiceHarvesting()
                {
                    riceHarvestingId = riceHarvestingId,
                    yield = yield
                };

                if (rh.yield == null)
                {
                    MessageBox.Show("Ave. Yield is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rh.yield != null)
                {
                    if (riceModel.UpdateRiceHarvesting(rh))
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

        public RiceHarvesting GetRiceHarvestingById(int riceHarvestingId)
        {
            try
            {
                return riceModel.GetRiceHarvestingById(riceHarvestingId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceHarvestinglView(string riceSrId, int farmId, int seedId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceHarvestingDataGrid(riceSrId, farmId, seedId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // PRINTING REPORTS

        public DataTable LoadRicePlantingView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRicePlantingDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Planting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceStandingView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceStandingDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceIrrigatedHarvestingView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceIrrigatedHarvestingDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceLowlandHarvestingView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceLowlandHarvestingDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadRiceUplandHarvestingView(string riceSrId)
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceUplandHarvestingDataGrid(riceSrId);
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Harvesting Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
