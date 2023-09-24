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
        public string userId { get; set; }
        public string letterTitle { get; set; }
        public string letterType { get; set; }
        public string letterDescription { get; set; }
        public string letterTags { get; set; }
        public string letterTo { get; set; }
        public string letterFrom { get; set; }
        public DateTime letterDate { get; set; }
    }
}
