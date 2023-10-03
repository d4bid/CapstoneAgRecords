using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RSBSAFarmParcel
    {
        public string rsbsaId { get; set; }
        public string? farmLocBrgy { get; set; }
        public string? farmLocMunicipality { get; set; }
        public string? withAncestralDomain { get; set; }
        public string? isAgrarianBeneficiary { get; set; }
        public string? ownershipNo { get; set; }
        public string? ownershipType { get; set; }
        public string? ownerName { get; set; }
        public string? farmCommodity { get; set; }
        public string? livestockPoultry { get; set; }
        public double? farmSize { get; set; }
        public int? headCount { get; set; }
        public string? farmType { get; set; }
        public string? isOrganicPractitioner { get; set; }
        public string? remarks { get; set; }


    }
}
