using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class CornReport
    {
        
        public string cornPrId { get; set; }
        public string season { get; set; }
        public string seasonYear { get; set; }
        public string month { get; set; }
        public string week { get; set; }
        public string year { get; set; }
        public string createdBy { get; set; }
        public Timestamp dateCreated { get; set; }
    }
}
