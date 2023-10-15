using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RSBSADocuments
    {
        public string rsbsaId { get; set; }

        public string docType { get; set; }
        public string docFilename { get; set; }

        public Dictionary<string, Image> docPhotoDictionary = new Dictionary<string, Image>();

        public Dictionary<string, byte[]> docPhotoDictionaryByte = new Dictionary<string, byte[]>();

    }
}
