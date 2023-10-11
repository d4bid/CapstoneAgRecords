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
    public class CropsRiceController
    {
        private CropsRiceAddView cropsRiceAddView;

        private RiceModel riceModel;

        public CropsRiceController(CropsRiceAddView cropsRiceAddView)
        {
            this.cropsRiceAddView = cropsRiceAddView;
            riceModel = new RiceModel();
        }

        //public DataTable LoadRicePlantLogView()
        //{
        //    try
        //    {
        //        DataTable ricePlantLogsTable = riceModel.LoadRicePlantLogsDataGrid();
        //        return ricePlantLogsTable;
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        MessageBox.Show(ex.Message, "Rice Plant Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        return null;
        //    }

        //}
    }
}
