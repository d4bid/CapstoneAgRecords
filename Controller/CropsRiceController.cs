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

namespace AgRecords.Controller
{
    public class CropsRiceController
    {
        private CropsRiceView cropsRiceView;
        private RiceAddView riceAddView;
        private CropsRiceAddView cropsRiceAddView;

        private RiceModel riceModel;
        UserModel userModel = new UserModel();
        private Boolean isDone = false;

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;

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


        public DataTable LoadRiceReportView()
        {
            try
            {
                DataTable riceReportTable = riceModel.LoadRiceReportDataGrid();
                return riceReportTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Plant Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                else if (rsr.month == null)
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (rsr.week == null)
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsr.year == null)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsr.riceSrId != null && rsr.month!= null && rsr.week != null && rsr.year != null)
                {
                    if (riceModel.AddRiceStandingRep(rsr))
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
                MessageBox.Show(ex.Message, "Add Rice Standing Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                else if (rs.brgyId == null)
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
                else if (rs.riceSrId != null && rs.brgyId != null && rs.farmTypeId != null && rs.growthStageId != null && rs.seedTypeId != null)
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

        public bool UpdateRiceStandingLog(int riceStandingLogsId, string riceSrId, int brgyId, int farmTypeId, int growthStageId, int seedTypeId, float size, DateTime logDate)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceStandingLogsId = riceStandingLogsId,
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
                else if (rs.brgyId == null)
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
                else if (rs.riceSrId != null && rs.brgyId != null && rs.farmTypeId != null && rs.growthStageId != null && rs.seedTypeId != null)
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
                MessageBox.Show(ex.Message, "Add Rice Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
    }
}
