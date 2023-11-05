using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    public class CropsHvcController
    {
        private CropsHvcView cropsHvcView;
        private HvcAddView hvcAddView;
        private CropsHvcAddView cropsHvcAddView;
        private CropsHvcEditView cropsHvcEditView;

        private HvcModel hvcModel;
        UserModel userModel = new UserModel();
        private Boolean isDone = false;

        //to get the username of the current user
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public CropsHvcController(CropsHvcView cropsHvcView)
        {
            this.cropsHvcView = cropsHvcView;
            hvcModel = new HvcModel();
        }

        public CropsHvcController(CropsHvcAddView cropsHvcAddView)
        {
            this.cropsHvcAddView = cropsHvcAddView;
            hvcModel = new HvcModel();
        }

        public CropsHvcController(CropsHvcEditView cropsHvcEditView)
        {
            this.cropsHvcEditView = cropsHvcEditView;
            hvcModel = new HvcModel();
        }

        public CropsHvcController(HvcAddView hvcAddView)
        {
            this.hvcAddView = hvcAddView;
            hvcModel = new HvcModel();
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

        public void GenerateNewHvcID()
        {
            try
            {
                hvcAddView.GenerateNewHvcId(hvcModel.GenerateNextHvcId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // STANDING

        public bool AddHvcStandingReport(string hvcSrId, string month, string week, string year)
        {
            try
            {
                string createdBy = GetUserIdByFullName(fullName);

                HvcReport hr = new HvcReport()
                {
                    hvcSrId = hvcSrId,
                    month = month,
                    week = week,
                    year = year,
                    createdBy = createdBy
                };

                if (hr.hvcSrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (hr.month == "")
                {
                    MessageBox.Show("Month is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (hr.week == "")
                {
                    MessageBox.Show("Week is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hr.year == "")
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hr.hvcSrId != "" && hr.month != "" && hr.week != "" && hr.year != "")
                {
                    if (hvcModel.AddHvcStandingRep(hr))
                    {
                        isDone = true;
                        userModel.InserActionLog(username, "Insert", "Crops HVC Report", $"{hvcSrId} added successfully.");
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add Accomplishment Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "Crops HVC Report", $"{hvcSrId} adding failed.");
                return false;
            }
        }

        public HvcReport GetHvcStandingReportById(string hvcSrId)
        {
            try
            {
                return hvcModel.GetHvcStandingReportById(hvcSrId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public bool AddHvcStanding(string hvcSrId, int cropStageId, int cropTypeId, float size, DateTime logDate)
        {
            try
            {
                HvcStanding hs = new HvcStanding()
                {
                    hvcSrId = hvcSrId,
                    cropStageId = cropStageId,
                    cropTypeId = cropTypeId,
                    size = size,
                    logDate = logDate
                };

                if (hs.hvcSrId == "")
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (hs.cropStageId == 0)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.cropTypeId == 0)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.size == 0)
                {
                    MessageBox.Show("Size is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.hvcSrId != "" && hs.cropStageId != 0 && hs.cropTypeId != 0 && hs.size != 0)
                {
                    if (hvcModel.AddHvcStanding(hs))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add HVC Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool UpdateHvcStanding(int hvcStandingId, int cropStageId, int cropTypeId, float size, DateTime logDate)
        {
            try
            {
                HvcStanding hs = new HvcStanding()
                {
                    hvcStandingId = hvcStandingId,
                    cropStageId = cropStageId,
                    cropTypeId = cropTypeId,
                    size = size,
                    logDate = logDate
                };

                if (hs.hvcStandingId == 0)
                {
                    MessageBox.Show("ID is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (hs.cropStageId == 0)
                {
                    MessageBox.Show("Growth Stage is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.cropTypeId == 0)
                {
                    MessageBox.Show("Seed Type is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.size == 0)
                {
                    MessageBox.Show("Size is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (hs.hvcStandingId != 0 && hs.cropStageId != 0 && hs.cropTypeId != 0 && hs.size != 0)
                {
                    if (hvcModel.UpdateHvcStanding(hs))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Update HVC Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool MoveNextHvcStanding(string hvcSrId)
        {
            try
            {
                HvcStanding hs = new HvcStanding()
                {
                    hvcSrId = hvcSrId,
                };

                if (hs.hvcSrId == "")
                {
                    MessageBox.Show("HVC Standing Record Id is required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (hs.hvcSrId != null)
                {
                    if (hvcModel.MoveNextHvcStanding(hs))
                    {
                        isDone = true;
                    }
                }

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Move HVC Standing Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public HvcStanding GetHvcStandingById(int hvcStandingId)
        {
            try
            {
                return hvcModel.GetHvcStandingById(hvcStandingId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadHvcStandingReportView(string column, string keyword)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadHvcStandingReportDataGrid(column, keyword);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadHvcStandingView(string hvcSrId)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadHvcStandingDataGrid(hvcSrId);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadHvcStandingTotalView(string hvcSrId)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadHvcStandingTotalDataGrid(hvcSrId);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // PRINTING
        public DataTable LoadStandingHvcPinakbetView(string hvcSrId)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadStandingHvcPinakbetDataGrid(hvcSrId);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadStandingHvcRootcropsView(string hvcSrId)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadStandingHvcRootcropsDataGrid(hvcSrId);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public DataTable LoadStandingHvcPlantationView(string hvcSrId)
        {
            try
            {
                DataTable hvcStandingTable = hvcModel.LoadStandingHvcPlantationDataGrid(hvcSrId);
                return hvcStandingTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "HVC Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
