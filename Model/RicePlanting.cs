using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RicePlanting
    {
        // tbl_rice_planting
        public int ricePlantingId { get; set; }
        public string ricePrId { get; set; }
        public int brgyId { get; set; }
        public int farmTypeId { get; set; }
        public int seedTypeId { get; set; }
        public float size { get; set; }
    }
}
