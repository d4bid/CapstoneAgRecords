using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace AgRecords.Controller
{
    internal class RSBSAController
    {
        private RsbsaAddView rsbsaAddView;
        private RSBSAEditView rsbsaEditView;
        private RsbsaView rsbsaView;
        private RSBSAExportView rsbsaExportView;
        private CertificationsView certificationsView;
        private FarmLandControl farmLandControl;
        private RSBSADocumentControl rsbsaDocumentControl;
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;
        private RSBSAModel rsbsaModel;
        UserModel userModel = new UserModel();

        public RSBSAController(RsbsaAddView rsbsaAddView)
        {
            this.rsbsaAddView = rsbsaAddView;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(RsbsaView rsbsaView)
        {
            this.rsbsaView = rsbsaView;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(RSBSAEditView rsbsaEditView)
        {
            this.rsbsaEditView = rsbsaEditView;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(RSBSAExportView rsbsaExportView)
        {
            this.rsbsaExportView = rsbsaExportView;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(FarmLandControl farmLandControl)
        {
            this.farmLandControl = farmLandControl;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(RSBSADocumentControl rsbsaDocumentControl)
        {
            this.rsbsaDocumentControl = rsbsaDocumentControl;
            rsbsaModel = new RSBSAModel();
        }

        public RSBSAController(CertificationsView certificationsView)
        {
            this.certificationsView = certificationsView;
            rsbsaModel = new RSBSAModel();
        }

        public void GenerateNewRSBSAId()
        {
            try
            {
                rsbsaAddView.GenerateNewRSBSAId(rsbsaModel.GenerateRSBSAId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string RSBSAIdForUserControl()
        {
            try
            {
                return rsbsaModel.GenerateRSBSAId();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;

            }
        }

        public DataTable LoadRSBSAView()
        {
            try
            {
                DataTable rsbsaTable = rsbsaModel.LoadRSBSADataGrid();
                return rsbsaTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "RSBSA Records Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

        }

        public DataTable LoadRSBSAExportView()
        {
            try
            {
                DataTable rsbsaTable = rsbsaModel.LoadRSBSAExportDataGrid();
                return rsbsaTable;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "RSBSA Records Loading Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

        }

        public string GetUserIdByFullName(string fullName)
        {
            try
            {
                return userModel.FindUserIDByFullName(fullName);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding User ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public bool ImportRSBSA(
            string rsbsaId,
            string? rsbsaIdLGU,
            string? rsbsaIdRegion,
            DateTime dateCreated,

            // Farmer Personal Info
            string? surname,
            string? firstname,
            string? middlename,
            string? extname,
            string? sex,
            string? addrPurok,
            string? addrStreet,
            string? addrBrgy,
            string? addrMunicipality,
            string? addrProvince,
            string? addrRegion,
            string? educAttainment,
            string? contactNo,
            string? landlineNo,
            string? withGovId,
            string? govIdType,
            string? govIdNo,
            DateTime birthDate,
            string? birthMunicipality,
            string? birthProvince,
            string? birthCountry,
            string? religion,
            string? civilStatus,
            string? spouseName,
            string? maidenName,
            string? isHouseHead,
            string? houseHeadName,
            string? houseHeadRs,
            int? houseLivingMemCount,
            int? houseMaleCount,
            int? houseFemCount,
            string? isPWD,
            string? is4Ps,
            string? isIp,
            string? ipGroupName,
            string? isCoopMember,
            string? coopName,
            string? emergContactName,
            string? emergContactNo,

            // Farm Profile
            string? isFarmer,
            string? isRiceFarmer,
            string? isCornFarmer,
            string? otherCrops,
            string? hasLivestocks,
            string? hasPoultry,
            string? isLaborer,
            string? isPreparingLand,
            string? isPlanting,
            string? isCultivating,
            string? isHarvesting,
            string? otherLaborWork,
            string? isFisherfolk,
            string? isFishCapturing,
            string? isAquaculture,
            string? isGleaning,
            string? isFishProcessing,
            string? isFishVending,
            string? otherFishingAct,
            string? isAgriYouth,
            string? isPartOfFarmingHousehold,
            string? isAttendAgrifishery,
            string? isParticipantAgriProgram,
            string? otherAgriYouthAct,
            double? annualIncomeFarming,
            double? annualIncomeNonFarming,

            //Farmland
            string? rotatingFarmers,
            int farmParcelCount,

            //Farmland Parcel
            List<FarmParcel>? farmParcels,


            //Docs
            List<RSBSADocuments>? rsbsaDocuments

            )
        {
            try
            {
                Boolean isDone = false;




                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Importing RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public async Task<bool> AddRSBSA(
            string rsbsaId,
            string? rsbsaIdLGU,
            string? rsbsaIdRegion,
            DateTime dateCreated,

            // Farmer Personal Info
            Image? farmerImg,
            string? surname,
            string? firstname,
            string? middlename,
            string? extname,
            string? sex,
            string? addrPurok,
            string? addrStreet,
            string? addrBrgy,
            string? addrMunicipality,
            string? addrProvince,
            string? addrRegion,
            string? educAttainment,
            string? contactNo,
            string? landlineNo,
            string? withGovId,
            string? govIdType,
            string? govIdNo,
            DateTime birthDate,
            string? birthMunicipality,
            string? birthProvince,
            string? birthCountry,
            string? religion,
            string? civilStatus,
            string? spouseName,
            string? maidenName,
            string? isHouseHead,
            string? houseHeadName,
            string? houseHeadRs,
            int? houseLivingMemCount,
            int? houseMaleCount,
            int? houseFemCount,
            string? isPWD,
            string? is4Ps,
            string? isIp,
            string? ipGroupName,
            string? isCoopMember,
            string? coopName,
            string? emergContactName,
            string? emergContactNo,

            // Farm Profile
            string? isFarmer,
            string? isRiceFarmer,
            string? isCornFarmer,
            string? otherCrops,
            string? hasLivestocks,
            string? hasPoultry,
            string? isLaborer,
            string? isPreparingLand,
            string? isPlanting,
            string? isCultivating,
            string? isHarvesting,
            string? otherLaborWork,
            string? isFisherfolk,
            string? isFishCapturing,
            string? isAquaculture,
            string? isGleaning,
            string? isFishProcessing,
            string? isFishVending,
            string? otherFishingAct,
            string? isAgriYouth,
            string? isPartOfFarmingHousehold,
            string? isAttendAgrifishery,
            string? isParticipantAgriProgram,
            string? otherAgriYouthAct,
            double? annualIncomeFarming,
            double? annualIncomeNonFarming,

            //Farmland
            string? rotatingFarmers,
            int farmParcelCount,

            //Farmland Parcel
            List<FarmParcel>? farmParcels,


            //Docs
            List<RSBSADocuments>? rsbsaDocuments

            )
        {

            try
            {
                string userId = GetUserIdByFullName(fullName);
                Boolean isDone = false;
                Boolean isFarmParcelValidated = false;
                Boolean isDocsValidated = false;

                // Create an instance of RSBSA and set its properties
                RSBSA rsbsa = new RSBSA
                {
                    rsbsaId = rsbsaId,
                    rsbsaIdLGU = rsbsaIdLGU,
                    rsbsaIdRegion = rsbsaIdRegion,
                    dateCreated = dateCreated,
                    userId = userId,

                    // Farmer Personal Info
                    farmerImg = farmerImg,
                    surname = surname,
                    firstname = firstname,
                    middlename = middlename,
                    extname = extname,
                    sex = sex,
                    addrPurok = addrPurok,
                    addrStreet = addrStreet,
                    addrBrgy = addrBrgy,
                    addrMunicipality = addrMunicipality,
                    addrProvince = addrProvince,
                    addrRegion = addrRegion,
                    educAttainment = educAttainment,
                    contactNo = contactNo,
                    landlineNo = landlineNo,
                    withGovId = withGovId,
                    govIdType = govIdType,
                    govIdNo = govIdNo,
                    birthDate = birthDate,
                    birthMunicipality = birthMunicipality,
                    birthProvince = birthProvince,
                    birthCountry = birthCountry,
                    religion = religion,
                    civilStatus = civilStatus,
                    spouseName = spouseName,
                    maidenName = maidenName,
                    isHouseHead = isHouseHead,
                    houseHeadName = houseHeadName,
                    houseHeadRs = houseHeadRs,
                    houseLivingMemCount = houseLivingMemCount,
                    houseMaleCount = houseMaleCount,
                    houseFemCount = houseFemCount,
                    isPWD = isPWD,
                    is4Ps = is4Ps,
                    isIp = isIp,
                    ipGroupName = ipGroupName,
                    isCoopMember = isCoopMember,
                    coopName = coopName,
                    emergContactName = emergContactName,
                    emergContactNo = emergContactNo,

                    // Farm Profile
                    isFarmer = isFarmer,
                    isRiceFarmer = isRiceFarmer,
                    isCornFarmer = isCornFarmer,
                    otherCrops = otherCrops,
                    hasLivestocks = hasLivestocks,
                    hasPoultry = hasPoultry,

                    isLaborer = isLaborer,
                    isPreparingLand = isPreparingLand,
                    isPlanting = isPlanting,
                    isCultivating = isCultivating,
                    isHarvesting = isHarvesting,
                    otherLaborWork = otherLaborWork,

                    isFisherfolk = isFisherfolk,
                    isFishCapturing = isFishCapturing,
                    isAquaculture = isAquaculture,
                    isGleaning = isGleaning,
                    isFishProcessing = isFishProcessing,
                    isFishVending = isFishVending,
                    otherFishingAct = otherFishingAct,

                    isAgriYouth = isAgriYouth,
                    isPartOfFarmingHousehold = isPartOfFarmingHousehold,
                    isAttendAgrifishery = isAttendAgrifishery,
                    isParticipantAgriProgram = isParticipantAgriProgram,
                    otherAgriYouthAct = otherAgriYouthAct,

                    annualIncomeFarming = annualIncomeFarming,
                    annualIncomeNonFarming = annualIncomeNonFarming,

                    // Farmland
                    rotatingFarmers = rotatingFarmers,
                    farmParcelCount = farmParcelCount,

                    // Farmland Parcel
                    farmParcels = farmParcels,

                    // RSBSA Docs
                    rsbsaDocuments = rsbsaDocuments,
                };



                //personal info
                if (string.IsNullOrEmpty(rsbsa.surname) || string.IsNullOrEmpty(rsbsa.firstname) || string.IsNullOrEmpty(rsbsa.sex) ||
                    string.IsNullOrEmpty(rsbsa.addrBrgy) || string.IsNullOrEmpty(rsbsa.addrMunicipality) || string.IsNullOrEmpty(rsbsa.addrProvince) ||
                    string.IsNullOrEmpty(rsbsa.addrRegion) || rsbsa.birthDate == DateTime.Today || string.IsNullOrEmpty(rsbsa.birthMunicipality) ||
                    string.IsNullOrEmpty(rsbsa.birthProvince) || string.IsNullOrEmpty(rsbsa.birthCountry) || string.IsNullOrEmpty(rsbsa.religion) ||
                    string.IsNullOrEmpty(rsbsa.civilStatus) || string.IsNullOrEmpty(rsbsa.spouseName) && rsbsa.civilStatus != "Single" ||
                    string.IsNullOrEmpty(rsbsa.isHouseHead) || string.IsNullOrEmpty(houseHeadName) && rsbsa.isHouseHead == "No" ||
                    string.IsNullOrEmpty(houseHeadRs) && rsbsa.isHouseHead == "No" || rsbsa.houseLivingMemCount == 0 ||
                    string.IsNullOrEmpty(rsbsa.ipGroupName) && rsbsa.isIp == "Yes" || string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes" ||
                    string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes" || string.IsNullOrEmpty(rsbsa.govIdNo) && rsbsa.withGovId == "Yes" ||
                    string.IsNullOrEmpty(rsbsa.coopName) && rsbsa.isCoopMember == "Yes" || rsbsa.isFarmer == "No" && rsbsa.isLaborer == "No" && rsbsa.isFisherfolk == "No" && rsbsa.isAgriYouth == "No" ||
                    rsbsa.isFarmer == "Yes" && rsbsa.isRiceFarmer == "No" && rsbsa.isCornFarmer == "No" && rsbsa.otherCrops == "" && rsbsa.hasLivestocks == "" && rsbsa.hasPoultry == "" ||
                    rsbsa.isLaborer == "Yes" && rsbsa.isPreparingLand == "No" && rsbsa.isPlanting == "No" && rsbsa.isCultivating == "No" && rsbsa.isHarvesting == "No" && rsbsa.otherLaborWork == "" ||
                    rsbsa.isFisherfolk == "Yes" && rsbsa.isFishCapturing == "No" && rsbsa.isAquaculture == "No" && rsbsa.isGleaning == "No" && rsbsa.isFishProcessing == "No" && rsbsa.isFishVending == "No" && rsbsa.otherFishingAct == "" ||
                    rsbsa.isAgriYouth == "Yes" && rsbsa.isPartOfFarmingHousehold == "No" && rsbsa.isAttendAgrifishery == "No" && rsbsa.isParticipantAgriProgram == "No" && rsbsa.otherAgriYouthAct == ""

                    )
                {
                    MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (string.IsNullOrEmpty(rsbsa.surname))
                    {
                        rsbsaAddView.boxPiSurname.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiSurname.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.firstname))
                    {
                        rsbsaAddView.boxPiFirstname.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiFirstname.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.sex))
                    {
                        rsbsaAddView.boxPiSex.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiSex.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrBrgy))
                    {
                        rsbsaAddView.boxPiAddrBarangay.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiAddrBarangay.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrMunicipality))
                    {
                        rsbsaAddView.boxPiAddrMunicipality.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiAddrMunicipality.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrProvince))
                    {
                        rsbsaAddView.boxPiAddrProvince.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiAddrProvince.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrRegion))
                    {
                        rsbsaAddView.boxPiAddrRegion.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiAddrRegion.Visible = true;
                    }

                    //birth details
                    if (rsbsa.birthDate == DateTime.Today)
                    {
                        rsbsaAddView.errorPiBirthDate.Visible = true;
                    }
                    else
                    {
                        rsbsaAddView.errorPiBirthDate.Visible = false;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthMunicipality))
                    {
                        rsbsaAddView.boxPiBirthMunicipality.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiBirthMunicipality.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthProvince))
                    {
                        rsbsaAddView.boxPiBirthProvince.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiBirthProvince.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthCountry))
                    {
                        rsbsaAddView.boxPiBirthCountry.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiBirthCountry.Visible = true;
                    }

                    //religion
                    if (string.IsNullOrEmpty(rsbsa.religion))
                    {
                        rsbsaAddView.boxPiReligion.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiReligion.Visible = true;
                    }

                    //civil status
                    if (string.IsNullOrEmpty(rsbsa.civilStatus))
                    {
                        rsbsaAddView.boxPiCivilStatus.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiCivilStatus.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.spouseName) && rsbsa.civilStatus != "Single")
                    {
                        rsbsaAddView.boxPiSpouse.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiSpouse.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.isHouseHead))
                    {
                        rsbsaAddView.boxPiHouseholdHead.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiHouseholdHead.Visible = true;
                    }

                    if (string.IsNullOrEmpty(houseHeadName) && rsbsa.isHouseHead == "No")
                    {
                        rsbsaAddView.boxPiHouseholdName.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiHouseholdName.Visible = true;
                    }

                    if (string.IsNullOrEmpty(houseHeadRs) && rsbsa.isHouseHead == "No")
                    {
                        rsbsaAddView.boxPiHosueholdRelationship.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiHosueholdRelationship.Visible = true;
                    }

                    if (rsbsa.houseLivingMemCount == 0)
                    {
                        rsbsaAddView.boxPiHouseholdNumber.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiHouseholdNumber.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes")
                    {
                        rsbsaAddView.boxPiGovId.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiGovId.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.govIdNo) && rsbsa.withGovId == "Yes")
                    {
                        rsbsaAddView.boxPiGovIdNumber.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiGovIdNumber.Visible = true;
                    }
                    
                    if (string.IsNullOrEmpty(rsbsa.coopName) && rsbsa.isCoopMember == "Yes")
                    {
                        rsbsaAddView.boxPiFarmAss.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxPiFarmAss.Visible = true;
                    }
                    
                    //main livelihood
                    if (rsbsa.isFarmer == "No" && rsbsa.isLaborer == "No" && rsbsa.isFisherfolk == "No" && rsbsa.isAgriYouth == "No")
                    {
                        rsbsaAddView.boxMainLivelihood.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxMainLivelihood.Visible = true;
                    }

                    //for farmers
                    if (rsbsa.isFarmer == "Yes" && rsbsa.isRiceFarmer == "No" && rsbsa.isCornFarmer == "No" && rsbsa.otherCrops == "" && rsbsa.hasLivestocks == "" && rsbsa.hasPoultry == "")
                    {
                        rsbsaAddView.boxFarmingActivity.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxFarmingActivity.Visible = true;
                    }

                    //for farmerworker/laborer
                    if (rsbsa.isLaborer == "Yes" && rsbsa.isPreparingLand == "No" && rsbsa.isPlanting == "No" && rsbsa.isCultivating == "No" && rsbsa.isHarvesting == "No" && rsbsa.otherLaborWork == "")
                    {
                        rsbsaAddView.boxWorkKind.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxWorkKind.Visible = true;
                    }
                    
                    //for fisherfolk
                    if (rsbsa.isFisherfolk == "Yes" && rsbsa.isFishCapturing == "No" && rsbsa.isAquaculture == "No" && rsbsa.isGleaning == "No" && rsbsa.isFishProcessing == "No" && rsbsa.isFishVending == "No" && rsbsa.otherFishingAct == "")
                    {
                        rsbsaAddView.boxFishingActivity.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxFishingActivity.Visible = true;
                    }
                    
                    //for agriyouth
                    if (rsbsa.isAgriYouth == "Yes" && rsbsa.isPartOfFarmingHousehold == "No" && rsbsa.isAttendAgrifishery == "No" && rsbsa.isParticipantAgriProgram == "No" && rsbsa.otherAgriYouthAct == "")
                    {
                        rsbsaAddView.boxInvolvementType.Visible = false;
                    }
                    else
                    {
                        rsbsaAddView.boxInvolvementType.Visible = true;
                    }

                    //farm parcels
                    if (rsbsa.farmParcelCount == 0 && rsbsa.isFarmer == "Yes" || rsbsa.isFisherfolk == "Yes")
                    {
                        MessageBox.Show("Please add at least one farm parcel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                   

                }
                else if (isFarmParcelValidated == false)
                {
                    bool continueValidation = true;
                    bool ParcelhasError = false;
                    foreach (FarmParcel parcel in farmParcels)
                    {
                        //if (!continueValidation)
                        //{
                        //    break; 
                        //}
                        // Farm Parcel validation
                        if (string.IsNullOrEmpty(parcel.farmLocBrgy))
                        {
                            MessageBox.Show($"Please enter the location (Barangay) of the farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (string.IsNullOrEmpty(parcel.farmLocMunicipality))
                        {
                            MessageBox.Show($"Please enter the location (Municipality) of the farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.farmSize == null)
                        {
                            MessageBox.Show($"Please enter the Total Farm Size in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }

                        else if (string.IsNullOrEmpty(parcel.ownershipType))
                        {
                            MessageBox.Show($"Please select ownership type of farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.ownershipType == "Registered Owner" && string.IsNullOrEmpty(parcel.ownershipNo))
                        {
                            MessageBox.Show($"Please enter ownership document number of farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.ownershipType != "Registered Owner" && string.IsNullOrEmpty(parcel.ownerName))
                        {
                            MessageBox.Show($"Please enter the name of the land owner in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        if (ParcelhasError)
                        {
                            continue;
                        }

                        else if (parcel.Crops == null || !parcel.Crops.Any(c => !string.IsNullOrEmpty(c.commodityType)))
                        {
                            MessageBox.Show($"No commodity has been selected for farm parcel #{parcel.farmParcelNo}.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (isFarmParcelValidated == false)
                        {
                            double? totalLandSize = 0;
                            // Crop validation (assuming FarmParcel has a List<FarmParcelCrop> property named Crops)
                            foreach (FarmParcelCrop crop in parcel.Crops)
                            {
                                if (ParcelhasError)
                                {
                                    continue;
                                }
                                // Check if the commodity type is not empty
                                if (!string.IsNullOrEmpty(crop.commodityType))
                                {

                                    if (crop.commodityType == "Rice")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the RICE farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid RICE farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "Corn")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the CORN farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid CORN farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "HVC")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the HVC farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid HVC farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "Agri-Fishery")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter a land size for the AGRI-FISHERY farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid AGRI-FISHERY farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType != "Rice" && crop.commodityType != "Corn" && crop.commodityType != "HVC" && crop.commodityType != "Agri-Fishery")
                                    {
                                        if (crop.headCount == 0)
                                        {
                                            MessageBox.Show($"Please enter a head count for {crop.commodityType} in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (!ParcelhasError && (totalLandSize ?? 0.0) > (parcel.farmSize ?? 0.0))
                            {
                                MessageBox.Show($"Total land size of all crops in farm parcel #{parcel.farmParcelNo} exceeds declared farm size.\nPlease ensure it does not exceed total farm area", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ParcelhasError = true;
                                continueValidation = true;
                                break;
                            }

                            if (ParcelhasError == true && continueValidation == true)
                            {
                                break;
                            }
                        }
                    }
                    if (!ParcelhasError)
                    {
                        isFarmParcelValidated = true;
                    }
                }
                else if (isFarmParcelValidated ==true && isDocsValidated == false)
                {
                    bool DocumentshasError = false;
                    //if (rsbsaDocuments == null || !rsbsaDocuments.Any())
                    //{
                    //    // Handle the case where no documents have been attached
                    //    MessageBox.Show("No documents have been attached.Please attach documents.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //else
                    //{
     
                        for (int index = 0; index < rsbsaDocuments.Count; index++)
                        {
                            RSBSADocuments document = rsbsaDocuments[index];
                            if (string.IsNullOrEmpty(document.docType))
                            {
                                // Handle the case where docType is empty
                                DocumentshasError = true;
                                MessageBox.Show($"Please enter the document type for at document #{index + 1}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }

                            else if (document.docPhotoDictionary == null || !document.docPhotoDictionary.Any())
                            {
                                // Handle the case where no images are attached to the document
                                DocumentshasError = true;
                                MessageBox.Show($"No images have been attached to document #{index + 1}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            }
                        }
                        if (!DocumentshasError)
                        {
                            //MessageBox.Show($"Documents validated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            isDocsValidated = true;
                        }
                    //}
                }
                else if (isFarmParcelValidated == true && isDocsValidated==true)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to save this RSBSA record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (await rsbsaModel.AddNewRSBSARecordAsync(rsbsa))
                        {
                            if (await rsbsaModel.AddNewFarmParcelAsync(farmParcels))
                            {
                                if (rsbsaModel.AddNewRSBSADocument(rsbsaDocuments))
                                {
                                    MessageBox.Show("RSBSA Record saved succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isDone = true;
                                    userModel.InserActionLog(username, "Insert", "RSBSA", $"{rsbsaId} added successfully.");
                                }
                            }
                        }
                    }
                }

                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Insert", "RSBSA", $"{rsbsaId} adding failed.");
                return false;
            }
        }

        public async Task<bool> EditRSBSA(
            string rsbsaId,
            string? rsbsaIdLGU,
            DateTime dateModified,

            // Farmer Personal Info
            Image? farmerImg,
            string? surname,
            string? firstname,
            string? middlename,
            string? extname,
            string? sex,
            string? addrPurok,
            string? addrStreet,
            string? addrBrgy,
            string? addrMunicipality,
            string? addrProvince,
            string? addrRegion,
            string? educAttainment,
            string? contactNo,
            string? landlineNo,
            string? withGovId,
            string? govIdType,
            string? govIdNo,
            DateTime birthDate,
            string? birthMunicipality,
            string? birthProvince,
            string? birthCountry,
            string? religion,
            string? civilStatus,
            string? spouseName,
            string? maidenName,
            string? isHouseHead,
            string? houseHeadName,
            string? houseHeadRs,
            int houseLivingMemCount,
            int houseMaleCount,
            int houseFemCount,
            string? isPWD,
            string? is4Ps,
            string? isIp,
            string? ipGroupName,
            string? isCoopMember,
            string? coopName,
            string? emergContactName,
            string? emergContactNo,

            // Farm Profile
            string? isFarmer,
            string? isRiceFarmer,
            string? isCornFarmer,
            string? otherCrops,
            string? hasLivestocks,
            string? hasPoultry,
            string? isLaborer,
            string? isPreparingLand,
            string? isPlanting,
            string? isCultivating,
            string? isHarvesting,
            string? otherLaborWork,
            string? isFisherfolk,
            string? isFishCapturing,
            string? isAquaculture,
            string? isGleaning,
            string? isFishProcessing,
            string? isFishVending,
            string? otherFishingAct,
            string? isAgriYouth,
            string? isPartOfFarmingHousehold,
            string? isAttendAgrifishery,
            string? isParticipantAgriProgram,
            string? otherAgriYouthAct,
            double? annualIncomeFarming,
            double? annualIncomeNonFarming,

            //Farmland
            string? rotatingFarmers,
            int farmParcelCount,

            //Farmland Parcel
            List<FarmParcel> farmParcels,

            //Docs
            List<RSBSADocuments> rsbsaDocuments

            )
        {
            try
            {
                string userId = GetUserIdByFullName(fullName);
                Boolean isDone = false;
                Boolean isFarmParcelValidated = false;
                Boolean isDocsValidated = false;

                // Create an instance of RSBSA and set its properties
                RSBSA rsbsa = new RSBSA
                {
                    rsbsaId = rsbsaId,
                    rsbsaIdLGU= rsbsaIdLGU,
                    dateModified = dateModified,
                    lastModifier = username,

                    // Farmer Personal Info
                    farmerImg = farmerImg,
                    surname = surname,
                    firstname = firstname,
                    middlename = middlename,
                    extname = extname,
                    sex = sex,
                    addrPurok = addrPurok,
                    addrStreet = addrStreet,
                    addrBrgy = addrBrgy,
                    addrMunicipality = addrMunicipality,
                    addrProvince = addrProvince,
                    addrRegion = addrRegion,
                    educAttainment = educAttainment,
                    contactNo = contactNo,
                    landlineNo = landlineNo,
                    withGovId = withGovId,
                    govIdType = govIdType,
                    govIdNo = govIdNo,
                    birthDate = birthDate,
                    birthMunicipality = birthMunicipality,
                    birthProvince = birthProvince,
                    birthCountry = birthCountry,
                    religion = religion,
                    civilStatus = civilStatus,
                    spouseName = spouseName,
                    maidenName = maidenName,
                    isHouseHead = isHouseHead,
                    houseHeadName = houseHeadName,
                    houseHeadRs = houseHeadRs,
                    houseLivingMemCount = houseLivingMemCount,
                    houseMaleCount = houseMaleCount,
                    houseFemCount = houseFemCount,
                    isPWD = isPWD,
                    is4Ps = is4Ps,
                    isIp = isIp,
                    ipGroupName = ipGroupName,
                    isCoopMember = isCoopMember,
                    coopName = coopName,
                    emergContactName = emergContactName,
                    emergContactNo = emergContactNo,

                    // Farm Profile
                    isFarmer = isFarmer,
                    isRiceFarmer = isRiceFarmer,
                    isCornFarmer = isCornFarmer,
                    otherCrops = otherCrops,
                    hasLivestocks = hasLivestocks,
                    hasPoultry = hasPoultry,
                    isLaborer = isLaborer,
                    isPreparingLand = isPreparingLand,
                    isPlanting = isPlanting,
                    isCultivating = isCultivating,
                    isHarvesting = isHarvesting,
                    otherLaborWork = otherLaborWork,
                    isFisherfolk = isFisherfolk,
                    isFishCapturing = isFishCapturing,
                    isAquaculture = isAquaculture,
                    isGleaning = isGleaning,
                    isFishProcessing = isFishProcessing,
                    isFishVending = isFishVending,
                    otherFishingAct = otherFishingAct,
                    isAgriYouth = isAgriYouth,
                    isPartOfFarmingHousehold = isPartOfFarmingHousehold,
                    isAttendAgrifishery = isAttendAgrifishery,
                    isParticipantAgriProgram = isParticipantAgriProgram,
                    otherAgriYouthAct = otherAgriYouthAct,
                    annualIncomeFarming = annualIncomeFarming,
                    annualIncomeNonFarming = annualIncomeNonFarming,

                    // Farmland
                    rotatingFarmers = rotatingFarmers,
                    farmParcelCount = farmParcelCount,


                    // Farmland Parcel
                    farmParcels = farmParcels,

                    // RSBSA Docs
                    rsbsaDocuments = rsbsaDocuments,
                };

                if (string.IsNullOrEmpty(rsbsa.surname) || string.IsNullOrEmpty(rsbsa.firstname) || string.IsNullOrEmpty(rsbsa.sex) ||
                    string.IsNullOrEmpty(rsbsa.addrBrgy) || string.IsNullOrEmpty(rsbsa.addrMunicipality) || string.IsNullOrEmpty(rsbsa.addrProvince) ||
                    string.IsNullOrEmpty(rsbsa.addrRegion) || rsbsa.birthDate == DateTime.Today || string.IsNullOrEmpty(rsbsa.birthMunicipality) ||
                    string.IsNullOrEmpty(rsbsa.birthProvince) || string.IsNullOrEmpty(rsbsa.birthCountry) || string.IsNullOrEmpty(rsbsa.religion) ||
                    string.IsNullOrEmpty(rsbsa.civilStatus) || string.IsNullOrEmpty(rsbsa.spouseName) && rsbsa.civilStatus != "Single" ||
                    string.IsNullOrEmpty(rsbsa.isHouseHead) || string.IsNullOrEmpty(houseHeadName) && rsbsa.isHouseHead == "No" ||
                    string.IsNullOrEmpty(houseHeadRs) && rsbsa.isHouseHead == "No" || rsbsa.houseLivingMemCount == 0 ||
                    string.IsNullOrEmpty(rsbsa.ipGroupName) && rsbsa.isIp == "Yes" || string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes" ||
                    string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes" || string.IsNullOrEmpty(rsbsa.govIdNo) && rsbsa.withGovId == "Yes" ||
                    string.IsNullOrEmpty(rsbsa.coopName) && rsbsa.isCoopMember == "Yes" || rsbsa.isFarmer == "No" && rsbsa.isLaborer == "No" && rsbsa.isFisherfolk == "No" && rsbsa.isAgriYouth == "No" ||
                    rsbsa.isFarmer == "Yes" && rsbsa.isRiceFarmer == "No" && rsbsa.isCornFarmer == "No" && rsbsa.otherCrops == "" && rsbsa.hasLivestocks == "" && rsbsa.hasPoultry == "" ||
                    rsbsa.isLaborer == "Yes" && rsbsa.isPreparingLand == "No" && rsbsa.isPlanting == "No" && rsbsa.isCultivating == "No" && rsbsa.isHarvesting == "No" && rsbsa.otherLaborWork == "" ||
                    rsbsa.isFisherfolk == "Yes" && rsbsa.isFishCapturing == "No" && rsbsa.isAquaculture == "No" && rsbsa.isGleaning == "No" && rsbsa.isFishProcessing == "No" && rsbsa.isFishVending == "No" && rsbsa.otherFishingAct == "" ||
                    rsbsa.isAgriYouth == "Yes" && rsbsa.isPartOfFarmingHousehold == "No" && rsbsa.isAttendAgrifishery == "No" && rsbsa.isParticipantAgriProgram == "No" && rsbsa.otherAgriYouthAct == ""

                    )
                {
                    MessageBox.Show("Please fill in the necessary fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (string.IsNullOrEmpty(rsbsa.surname))
                    {
                        rsbsaEditView.boxPiSurname.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiSurname.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.firstname))
                    {
                        rsbsaEditView.boxPiFirstname.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiFirstname.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.sex))
                    {
                        rsbsaEditView.boxPiSex.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiSex.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrBrgy))
                    {
                        rsbsaEditView.boxPiAddrBarangay.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiAddrBarangay.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrMunicipality))
                    {
                        rsbsaEditView.boxPiAddrMunicipality.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiAddrMunicipality.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrProvince))
                    {
                        rsbsaEditView.boxPiAddrProvince.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiAddrProvince.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.addrRegion))
                    {
                        rsbsaEditView.boxPiAddrRegion.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiAddrRegion.Visible = true;
                    }

                    //birth details
                    if (rsbsa.birthDate == DateTime.Today)
                    {
                        rsbsaEditView.errorPiBirthDate.Visible = true;
                    }
                    else
                    {
                        rsbsaEditView.errorPiBirthDate.Visible = false;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthMunicipality))
                    {
                        rsbsaEditView.boxPiBirthMunicipality.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiBirthMunicipality.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthProvince))
                    {
                        rsbsaEditView.boxPiBirthProvince.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiBirthProvince.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.birthCountry))
                    {
                        rsbsaEditView.boxPiBirthCountry.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiBirthCountry.Visible = true;
                    }

                    //religion
                    if (string.IsNullOrEmpty(rsbsa.religion))
                    {
                        rsbsaEditView.boxPiReligion.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiReligion.Visible = true;
                    }

                    //civil status
                    if (string.IsNullOrEmpty(rsbsa.civilStatus))
                    {
                        rsbsaEditView.boxPiCivilStatus.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiCivilStatus.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.spouseName) && rsbsa.civilStatus != "Single")
                    {
                        rsbsaEditView.boxPiSpouse.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiSpouse.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.isHouseHead))
                    {
                        rsbsaEditView.boxPiHouseholdHead.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiHouseholdHead.Visible = true;
                    }

                    if (string.IsNullOrEmpty(houseHeadName) && rsbsa.isHouseHead == "No")
                    {
                        rsbsaEditView.boxPiHouseholdHead.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiHouseholdHead.Visible = true;
                    }

                    if (string.IsNullOrEmpty(houseHeadRs) && rsbsa.isHouseHead == "No")
                    {
                        rsbsaEditView.boxPiHouseholdRelationship.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiHouseholdRelationship.Visible = true;
                    }

                    if (rsbsa.houseLivingMemCount == 0)
                    {
                        rsbsaEditView.boxPiHouseholdNumber.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiHouseholdNumber.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes")
                    {
                        rsbsaEditView.boxPiGovId.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiGovId.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.govIdNo) && rsbsa.withGovId == "Yes")
                    {
                        rsbsaEditView.boxPiGovIdNumber.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiGovIdNumber.Visible = true;
                    }

                    if (string.IsNullOrEmpty(rsbsa.coopName) && rsbsa.isCoopMember == "Yes")
                    {
                        rsbsaEditView.boxPiFarmAss.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxPiFarmAss.Visible = true;
                    }

                    //main livelihood
                    if (rsbsa.isFarmer == "No" && rsbsa.isLaborer == "No" && rsbsa.isFisherfolk == "No" && rsbsa.isAgriYouth == "No")
                    {
                        rsbsaEditView.boxMainLivelihood.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxMainLivelihood.Visible = true;
                    }

                    //for farmers
                    if (rsbsa.isFarmer == "Yes" && rsbsa.isRiceFarmer == "No" && rsbsa.isCornFarmer == "No" && rsbsa.otherCrops == "" && rsbsa.hasLivestocks == "" && rsbsa.hasPoultry == "")
                    {
                        rsbsaEditView.boxFarmingActivity.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxFarmingActivity.Visible = true;
                    }

                    //for farmerworker/laborer
                    if (rsbsa.isLaborer == "Yes" && rsbsa.isPreparingLand == "No" && rsbsa.isPlanting == "No" && rsbsa.isCultivating == "No" && rsbsa.isHarvesting == "No" && rsbsa.otherLaborWork == "")
                    {
                        rsbsaEditView.boxWorkKind.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxWorkKind.Visible = true;
                    }

                    //for fisherfolk
                    if (rsbsa.isFisherfolk == "Yes" && rsbsa.isFishCapturing == "No" && rsbsa.isAquaculture == "No" && rsbsa.isGleaning == "No" && rsbsa.isFishProcessing == "No" && rsbsa.isFishVending == "No" && rsbsa.otherFishingAct == "")
                    {
                        rsbsaEditView.boxFishingActivity.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxFishingActivity.Visible = true;
                    }

                    //for agriyouth
                    if (rsbsa.isAgriYouth == "Yes" && rsbsa.isPartOfFarmingHousehold == "No" && rsbsa.isAttendAgrifishery == "No" && rsbsa.isParticipantAgriProgram == "No" && rsbsa.otherAgriYouthAct == "")
                    {
                        rsbsaEditView.boxInvolvementType.Visible = false;
                    }
                    else
                    {
                        rsbsaEditView.boxInvolvementType.Visible = true;
                    }

                    //farm parcels
                    if (rsbsa.farmParcelCount == 0 && rsbsa.isFarmer == "Yes" || rsbsa.isFisherfolk == "Yes")
                    {
                        MessageBox.Show("Please add at least one farm parcel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }



                }
                else if (isFarmParcelValidated == false)
                {
                    bool continueValidation = true;
                    bool ParcelhasError = false;
                    foreach (FarmParcel parcel in farmParcels)
                    {
                        //if (!continueValidation)
                        //{
                        //    break; 
                        //}
                        // Farm Parcel validation
                        if (string.IsNullOrEmpty(parcel.farmLocBrgy))
                        {
                            MessageBox.Show($"Please enter the location (Barangay) of the farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (string.IsNullOrEmpty(parcel.farmLocMunicipality))
                        {
                            MessageBox.Show($"Please enter the location (Municipality) of the farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.farmSize == null)
                        {
                            MessageBox.Show($"Please enter the Total Farm Size in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }

                        else if (string.IsNullOrEmpty(parcel.ownershipType))
                        {
                            MessageBox.Show($"Please select ownership type of farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.ownershipType == "Registered Owner" && string.IsNullOrEmpty(parcel.ownershipNo))
                        {
                            MessageBox.Show($"Please enter ownership document number of farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (parcel.ownershipType != "Registered Owner" && string.IsNullOrEmpty(parcel.ownerName))
                        {
                            MessageBox.Show($"Please enter the name of the land owner in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        if (ParcelhasError)
                        {
                            continue;
                        }

                        else if (parcel.Crops == null || !parcel.Crops.Any(c => !string.IsNullOrEmpty(c.commodityType)))
                        {
                            MessageBox.Show($"No commodity has been selected for farm parcel #{parcel.farmParcelNo}.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ParcelhasError = true;
                            break;
                        }
                        else if (isFarmParcelValidated == false)
                        {
                            double? totalLandSize = 0;
                            // Crop validation (assuming FarmParcel has a List<FarmParcelCrop> property named Crops)
                            foreach (FarmParcelCrop crop in parcel.Crops)
                            {
                                if (ParcelhasError)
                                {
                                    continue;
                                }
                                // Check if the commodity type is not empty
                                if (!string.IsNullOrEmpty(crop.commodityType))
                                {

                                    if (crop.commodityType == "Rice")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the RICE farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid RICE farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "Corn")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the CORN farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid CORN farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "HVC")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter land size for the HVC farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid HVC farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType == "Agri-Fishery")
                                    {
                                        if (crop.landSize == null)
                                        {
                                            MessageBox.Show($"Please enter a land size for the AGRI-FISHERY farm in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        if (crop.landSize > parcel.farmSize)
                                        {
                                            MessageBox.Show($"Invalid AGRI-FISHERY farm size in Parcel #{parcel.farmParcelNo}.\nEnsure it does not exceed total farm area.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                        totalLandSize += crop.landSize;
                                    }
                                    if (crop.commodityType != "Rice" && crop.commodityType != "Corn" && crop.commodityType != "HVC" && crop.commodityType != "Agri-Fishery")
                                    {
                                        if (crop.headCount == 0)
                                        {
                                            MessageBox.Show($"Please enter a head count for {crop.commodityType} in farm parcel #{parcel.farmParcelNo}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            ParcelhasError = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (!ParcelhasError && (totalLandSize ?? 0.0) > (parcel.farmSize ?? 0.0))
                            {
                                MessageBox.Show($"Total land size of all crops in farm parcel #{parcel.farmParcelNo} exceeds declared farm size.\nPlease ensure it does not exceed total farm area", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                ParcelhasError = true;
                                continueValidation = true;
                                break;
                            }

                            if (ParcelhasError == true && continueValidation == true)
                            {
                                break;
                            }
                        }
                    }
                    if (!ParcelhasError)
                    {
                        isFarmParcelValidated = true;
                    }
                }
                else if (isFarmParcelValidated == true && isDocsValidated == false)
                {
                    bool DocumentshasError = false;
                    //if (rsbsaDocuments == null || !rsbsaDocuments.Any())
                    //{
                    //    // Handle the case where no documents have been attached
                    //    MessageBox.Show("No documents have been attached.Please attach documents.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //else
                    //{

                    for (int index = 0; index < rsbsaDocuments.Count; index++)
                    {
                        RSBSADocuments document = rsbsaDocuments[index];
                        if (string.IsNullOrEmpty(document.docType))
                        {
                            // Handle the case where docType is empty
                            DocumentshasError = true;
                            MessageBox.Show($"Please enter the document type for at document #{index + 1}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }

                        else if (document.docPhotoDictionary == null || !document.docPhotoDictionary.Any())
                        {
                            // Handle the case where no images are attached to the document
                            DocumentshasError = true;
                            MessageBox.Show($"No images have been attached to document #{index + 1}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                    if (!DocumentshasError)
                    {
                        //MessageBox.Show($"Documents validated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        isDocsValidated = true;
                    }
                    //}
                }
                else if (isFarmParcelValidated == true && isDocsValidated == true)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this RSBSA record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (await rsbsaModel.EditRSBSARecord(rsbsa))
                        {
                            if (await rsbsaModel.EditFarmParcelAsync(farmParcels))
                            {
                                if (rsbsaModel.EditRSBSADocument(rsbsaDocuments))
                                {
                                    MessageBox.Show("RSBSA Record updated succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    isDone = true;
                                    userModel.InserActionLog(username, "Update", "RSBSA", $"{rsbsaId} updated successfully.");
                                }
                            }
                        }
                    }
                }

                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Updating RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                userModel.InserActionLog(username, "Update", "RSBSA", $"{rsbsaId} update failed.");
                return false;
            }
        }

        public RSBSA GetRSBSAInfoByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetRSBSAInfoById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding RSBSA Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetFarmerInfoByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetFarmerInfoById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Farmer Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetFarmProfileByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetFarmProfileById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Farm Profile Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetFarmlandByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetFarmlandById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Farmland Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetFarmlandParcelsByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetFarmlandParcelsById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Farmland Parcel Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetFarmlandParcelCropsByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetFarmlandParcelCropsById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding Farmland Parcel Info Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public RSBSA GetDocsByRSBSAId(string rsbsaId)
        {
            try
            {
                return rsbsaModel.GetDocsById(rsbsaId);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding RSBSA Documents Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }

        public DataTable SearchRSBSA(string searchText, string categoryText, string barangay, string commodityType)
        {
            DataTable dt = new DataTable();
            if (categoryText == "ALL")
            {
                dt = rsbsaModel.SearchRSBSAAll(searchText, barangay, commodityType);
            }
            else if (categoryText == "ID")
            {
                dt = rsbsaModel.SearchRSBSAID(searchText, barangay, commodityType);
            }
            else if (categoryText == "SURNAME")
            {
                dt = rsbsaModel.SearchRSBSASurname(searchText, barangay, commodityType);
            }
            else if (categoryText == "FIRST NAME")
            {
                dt = rsbsaModel.SearchRSBSAFirsName(searchText, barangay, commodityType);
            }
            else if (categoryText == "MIDDLE NAME")
            {
                dt = rsbsaModel.SearchRSBSAMiddleName(searchText, barangay, commodityType);
            }

            return dt;
        }

    }
}
