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
        public string? sex { get; set; }
        public string? barangay { get; set; }
        public int? farmParcelCount { get; set; }
        public string? employeeName { get; set; }
        public string? employeePosition { get; set; }
        public string? headName { get; set; }
        public string? username { get; set; }

        public string? orderNumber { get; set; }
        public DateTime date { get; set; }
        public string? farmInfo { get; set; }

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
