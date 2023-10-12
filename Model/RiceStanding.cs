using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RiceStanding
    {
        // tbl_rice_standing
        public int riceStandingId { get; set; }
        public string riceSrId { get; set; }
        public int brgyId { get; set; }
        public int farmTypeId { get; set; }
        public int growthStageId { get; set; }
        public float size { get; set; }
    }
}
