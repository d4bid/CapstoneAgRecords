using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RSBSAFarmProfile
    {
        public string rsbsaId { get; set; }
        public string? livelihoodType { get; set; }
        public string? farmingAct { get; set; }
        public string? workKind { get; set; }
        public string? fishingAct { get; set; }
        public string? involveType { get; set; }
        public string? gaiFarming { get; set; }
        public string? gaiNonFarming { get; set; }
    }
}
