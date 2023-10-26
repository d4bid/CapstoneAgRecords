using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class CornHarvesting
    {
        public int cornHarvestingId { get; set; }
        public string cornPrId { get; set; }
        public int brgyId { get; set; }
        public int landTypeId { get; set; }
        public int seedTypeId { get; set; }
        public int colorTypeId { get; set; }
        public float size { get; set; }
        public float yield { get; set; }
    }
}
