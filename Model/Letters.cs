using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class Letters
    {
        //Letters Table
        public string letterId { get; set; }
        public string letterTitle { get; set; }
        public string letterType { get; set; }
        public string userId { get; set; }

        //Pages Table
        public string pageId { get; set; }
        public string tagId { get; set; }
        public string recentTagId { get; set; }
        public string pageNumber { get; set; }
        public byte[] pageImage { get; set; }

        //Tags Table
        public string tagName { get; set; }
    }
}
