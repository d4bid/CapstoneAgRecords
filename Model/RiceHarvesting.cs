using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RiceHarvesting
    {
        // tbl_rice_harvesting
        public int riceHarvestingId { get; set; }
        public string riceSrId { get; set; }
        public int brgyId { get; set; }
        public int farmTypeId { get; set; }
        public int seedTypeId { get; set; }
        public float yield { get; set; }
        public float size { get; set; }
    }
}
