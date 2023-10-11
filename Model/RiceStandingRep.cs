﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RiceStandingRep
    {
        // tbl_rice_standing_report
        public string riceSrId { get; set; }
        public string month { get; set; }
        public string week { get; set; }
        public int year { get; set; }
        public string createdBy { get; set; }
        public Timestamp dateCreated { get; set; }
    }
}
