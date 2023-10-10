using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RicePlantingRep
    {
        // tbl_rice_planting_report
        public string ricePrId { get; set; }
        public string season { get; set; }
        public string seasonYear { get; set; }
        public string month { get; set; }
        public string week { get; set; }
        public int year { get; set; }
        public string createdBy { get; set; }
        public Timestamp dateCreated { get; set; }
    }
}
