using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RSBSA
    {
        //RSBSA Info
        public string? rsbsaId { get; set; }
        public string? rsbsaIdLGU { get; set; }
        public string? rsbsaIdRegion { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime? dateModified{ get; set; }
        public string? lastModifier { get; set; }

        public string? userId { get; set; }

        //Farmer Personal Info
        public Image? farmerImg { get; set; }
        public string? surname { get; set; }
        public string? firstname { get; set; }
        public string? middlename { get; set; }
        public string? extname { get; set; }
        public string? sex { get; set; }
        public string? addrPurok { get; set; }
        public string? addrStreet { get; set; }
        public string? addrBrgy { get; set; }
        public string? addrMunicipality { get; set; }
        public string? addrProvince { get; set; }
        public string? addrRegion { get; set; }
        public string? educAttainment { get; set; }
        public string? contactNo { get; set; }
        public string? landlineNo { get; set; }
        public string? withGovId { get; set; }
        public string? govIdType { get; set; }
        public string? govIdNo { get; set; }
        public DateTime birthDate { get; set; }
        public string? birthMunicipality { get; set; }
        public string? birthProvince { get; set; }
        public string? birthCountry { get; set; }
        public string? religion { get; set; }
        public string? civilStatus { get; set; }
        public string? spouseName { get; set; }
        public string? maidenName { get; set; }
        public string? isHouseHead { get; set; }
        public string? houseHeadName { get; set; }
        public string? houseHeadRs { get; set; }
        public int? houseLivingMemCount { get; set; }
        public int? houseMaleCount { get; set; }
        public int? houseFemCount { get; set; }
        public string? isPWD { get; set; }
        public string? is4Ps { get; set; }
        public string? isIp { get; set; }
        public string? ipGroupName { get; set; }
        public string? isCoopMember { get; set; }
        public string? coopName { get; set; }
        public string? emergContactName { get; set; }
        public string? emergContactNo { get; set; }

        //Farm Profile
        public string? isFarmer { get; set; }
        public string? isRiceFarmer { get; set; }
        public string? isCornFarmer { get; set; }
        public string? otherCrops { get; set; }
        public string? hasLivestocks { get; set; }
        public string? hasPoultry { get; set; }
        public string? isLaborer { get; set; }
        public string? isPreparingLand { get; set; }
        public string? isPlanting { get; set; }
        public string? isCultivating { get; set; }
        public string? isHarvesting { get; set; }
        public string? otherLaborWork { get; set; }
        public string? isFisherfolk { get; set; }
        public string? isFishCapturing { get; set; }
        public string? isAquaculture { get; set; }
        public string? isGleaning { get; set; }
        public string? isFishProcessing { get; set; }
        public string? isFishVending { get; set; }
        public string? otherFishingAct { get; set; }
        public string? isAgriYouth { get; set; }
        public string? isPartOfFarmingHousehold { get; set; }
        public string? isAttendAgrifishery { get; set; }
        public string? isParticipantAgriProgram { get; set; }
        public string? otherAgriYouthAct { get; set; }
        public double? annualIncomeFarming { get; set; }
        public double? annualIncomeNonFarming { get; set; }

        //farmland table
        public string? rotatingFarmers { get; set; }
        public int? farmParcelCount { get; set; }

        //farmland parcel table
        public List<FarmParcel>? farmParcels { get; set; }
        public List<FarmParcelCrop>? farmParcelCrops { get; set; }

        //RSBSA Docs
        public List<RSBSADocuments>? rsbsaDocuments { get; set; }



    }
}
