using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class HvcStanding
    {
        public int hvcStandingId { get; set; }

        public string hvcSrId { get; set; }
        public int cropStageId { get; set; }
        public int cropTypeId { get; set; }
        public float size { get; set; }
        public DateTime logDate { get; set; }
    }
}
