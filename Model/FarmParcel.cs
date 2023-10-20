using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class FarmParcel
    {
        public string rsbsaId { get; set; }
        public string farmParcelNo { get; set; }
        public string farmLocBrgy { get; set; }
        public string farmLocMunicipality { get; set; }
        public double? farmSize { get; set; }
        public string isAncestralDomain { get; set; }
        public string ownershipNo { get; set; }
        public string isAgrarianBeneficiary { get; set; }
        public string isRegisteredOwner { get; set; }
        public string ownershipType { get; set; }
        public string ownerName { get; set; }
        public string remarks { get; set; }
        public List<FarmParcelCrop> Crops { get; set; }
    }
}
