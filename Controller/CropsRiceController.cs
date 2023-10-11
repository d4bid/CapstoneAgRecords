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
        private CropsRiceAddView cropsRiceAddView;

        private RiceModel riceModel;

        private Boolean isDone = false;

        public CropsRiceController(CropsRiceAddView cropsRiceAddView)
        {
            this.cropsRiceAddView = cropsRiceAddView;
            riceModel = new RiceModel();
        }

        // STANDING
        //public DataTable LoadRiceReportView()
        //{
        //    try
        //    {
        //        DataTable riceReportTable = riceModel.LoadRicePlantLogsDataGrid();
        //        return riceReportTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Rice Plant Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }
        //}

        public bool AddRiceStandingLogs(string riceSrId, int brgyId, int farmTypeId, int growthStageId, float size)
        {
            try
            {
                RiceStanding rs = new RiceStanding()
                {
                    riceSrId = riceSrId,
                    brgyId = brgyId,
                    farmTypeId = farmTypeId,
                    growthStageId = growthStageId,
                    size = size
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
                else if (rs.riceSrId != null && rs.brgyId != null && rs.farmTypeId != null && rs.growthStageId != null)
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

        public DataTable LoadRiceStandLogsView()
        {
            try
            {
                DataTable riceStandLogsTable = riceModel.LoadRiceStandLogsDataGrid();
                return riceStandLogsTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Rice Standing Record Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }
    }
}
