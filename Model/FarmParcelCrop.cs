using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class FarmParcelCrop
    {
        public string farmParcelNo { get; set; }
        public string commodityType { get; set; }
        public double landSize { get; set; }
        public int headCount { get; set; }
        public string farmType { get; set; }
        public string isOrganic { get; set; }
    }
}
