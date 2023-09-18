using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class LettersPages
    {
        //Pages Table
        public string letterId { get; set; }

        public string pageId { get; set; }
        public string pageNumber { get; set; }

        public Dictionary<string, Image> imageDictionary = new Dictionary<string, Image>();

    }
}
