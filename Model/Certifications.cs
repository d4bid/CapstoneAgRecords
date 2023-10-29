using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class Certifications
    {
        //farmer
        public string? rsbsaId { get; set; }
        public string? rsbsaIdLGU { get; set; }
        public string? name { get; set; }
        public string? barangay { get; set; }
        public int? farmParcelCount { get; set; }

        //parcel
        public string? farmParcelNo { get; set; }
        public string? farmLocBrgy { get; set; }
        public string? commodityType { get; set; }
        public string? landSize { get; set; }
        public string? headCount { get; set; }

        //concatenated / formatted string (commodityType + landSize)
        public string? commodityInfo { get; set; }
    }
}
