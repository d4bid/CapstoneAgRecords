using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    internal class RSBSAController
    {
        private RsbsaAddView rsbsaAddView;
        private RSBSAEditView rsbsaEditView;
        private RsbsaView rsbsaView;
        private FarmLandControl farmLandControl;
        private RSBSADocumentControl rsbsaDocumentControl;
        private Boolean isDone = false;
        private string fullName = HomeView.Instance.fullName.Text;
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

        public bool AddRSBSA(
            string rsbsaId,
            string? rsbsaIdLGU,
            string rsbsaIdRegion,
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

                // Create an instance of RSBSA and set its properties
                RSBSA rsbsa = new RSBSA
                {
                    rsbsaId = rsbsaId,
                    rsbsaIdLGU = rsbsaIdLGU,
                    rsbsaIdRegion = rsbsaIdRegion,
                    dateCreated = dateCreated,
                    userId = userId,

                    // Farmer Personal Info
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
                if (string.IsNullOrEmpty(rsbsa.surname))
                {
                    MessageBox.Show("Please enter surname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.firstname))
                {
                    MessageBox.Show("Please enter firstname.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.middlename))
                {
                    MessageBox.Show("Please enter middlename.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.sex))
                {
                    MessageBox.Show("Please select a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //else if(!Regex.IsMatch(rsbsa.extname, @"[CDILSJRXV.]"))
                //{
                //    MessageBox.Show("Please enter a valid extension name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //address
                else if (string.IsNullOrEmpty(rsbsa.addrPurok))
                {
                    MessageBox.Show("Please enter purok in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.addrStreet))
                {
                    MessageBox.Show("Please enter street in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.addrBrgy))
                {
                    MessageBox.Show("Please enter barangay in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.addrMunicipality))
                {
                    MessageBox.Show("Please enter municipality in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.addrProvince))
                {
                    MessageBox.Show("Please enter province in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.addrRegion))
                {
                    MessageBox.Show("Please enter region in the address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // contact
                else if (string.IsNullOrEmpty(rsbsa.contactNo))
                {
                    MessageBox.Show("Please enter a contact number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Regex.IsMatch(rsbsa.contactNo, @"^\d{11}$"))
                {
                    MessageBox.Show("Please enter a valid 11-digit contact number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //birth details
                else if (rsbsa.birthDate == DateTime.Today)
                {
                    MessageBox.Show("Please enter a valid birth date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.birthMunicipality))
                {
                    MessageBox.Show("Please enter the birth municipality.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.birthProvince))
                {
                    MessageBox.Show("Please enter the birth province.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.birthCountry))
                {
                    MessageBox.Show("Please enter the birth country.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //religion
                else if (string.IsNullOrEmpty(rsbsa.religion))
                {
                    MessageBox.Show("Please select/specify the religion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //civil status
                else if (string.IsNullOrEmpty(rsbsa.civilStatus))
                {
                    MessageBox.Show("Please select a civil status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.spouseName) && rsbsa.civilStatus != "Single")
                {
                    MessageBox.Show("Please enter spouse's name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //mother's maiden name
                else if (string.IsNullOrEmpty(rsbsa.maidenName))
                {
                    MessageBox.Show("Please enter mother's maiden name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //household
                else if (string.IsNullOrEmpty(rsbsa.isHouseHead))
                {
                    MessageBox.Show("Please select if person is the house head or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(houseHeadName) && rsbsa.isHouseHead == "No")
                {
                    MessageBox.Show("Please enter the house head's name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(houseHeadRs) && rsbsa.isHouseHead == "No")
                {
                    MessageBox.Show("Please enter the house head's relationship status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }             
                else if (rsbsa.houseLivingMemCount == 0)
                {
                    MessageBox.Show("Please indicate number of living house hold members.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsbsa.houseMaleCount == 0)
                {
                    MessageBox.Show("Please indicate number of living male house hold members.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsbsa.houseFemCount == 0)
                {
                    MessageBox.Show("Please indicate nummber of living female house hold members.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //educational attaiment
                else if (string.IsNullOrEmpty(rsbsa.educAttainment))
                {
                    MessageBox.Show("Please select an education attainment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //affiliations
                else if (string.IsNullOrEmpty(rsbsa.isPWD))
                {
                    MessageBox.Show("Please select if PWD or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.is4Ps))
                {
                    MessageBox.Show("Please select if 4P's beneficiary or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.isIp))
                {
                    MessageBox.Show("Please select if IP or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.ipGroupName) && rsbsa.isIp == "Yes")
                {
                     MessageBox.Show("Please enter the IP group name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.withGovId))
                {
                    MessageBox.Show("Please select if with government ID or not.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.govIdType) && rsbsa.withGovId == "Yes")
                {
                    MessageBox.Show("Please enter ID type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.govIdNo) && rsbsa.withGovId == "Yes")
                {
                    MessageBox.Show("Please enter ID number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.isCoopMember))
                {
                    MessageBox.Show("Please select if an association/cooperative member.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.coopName) && rsbsa.isCoopMember == "Yes")
                {
                    MessageBox.Show("Please enter the cooperative name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.emergContactName))
                {
                    MessageBox.Show("Please enter emergency contact name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (string.IsNullOrEmpty(rsbsa.emergContactNo))
                {
                    MessageBox.Show("Please enter emergency contact number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //main livelihood
                else if (rsbsa.isFarmer == "No" && rsbsa.isLaborer == "No" && rsbsa.isFisherfolk == "No" && rsbsa.isAgriYouth == "No")
                {
                    MessageBox.Show("Please select at least one main livelihood.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //for farmers
                else if (rsbsa.isFarmer == "Yes" && rsbsa.isRiceFarmer=="No" && rsbsa.isCornFarmer == "No" && rsbsa.otherCrops == "No" && rsbsa.hasLivestocks == "No" && rsbsa.hasPoultry == "No")
                {
                    MessageBox.Show("Please select at least one activity for farmer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //for farmerworker/laborer
                else if (rsbsa.isLaborer == "Yes" && rsbsa.isPreparingLand == "No" && rsbsa.isPlanting == "No" && rsbsa.isCultivating == "No" && rsbsa.isHarvesting == "No" && rsbsa.otherLaborWork == "No")
                {
                    MessageBox.Show("Please select at least one activity for farmorker.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //for fisherfolk
                else if (rsbsa.isFisherfolk == "Yes" && rsbsa.isFishCapturing == "No" && rsbsa.isAquaculture == "No" && rsbsa.isGleaning == "No" && rsbsa.isFishProcessing == "No" && rsbsa.isFishVending == "No" && rsbsa.otherFishingAct == "No")
                {
                    MessageBox.Show("Please select at least one activity for fisherfolk.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //for agriyouth
                else if (rsbsa.isAgriYouth == "Yes" && rsbsa.isPartOfFarmingHousehold == "No" && rsbsa.isAttendAgrifishery == "No" && rsbsa.isParticipantAgriProgram == "No" && rsbsa.otherAgriYouthAct == "No")
                {
                    MessageBox.Show("Please select at least one activity for Agri Youth.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //gross annual income
                else if (rsbsa.annualIncomeFarming==0)
                {
                    MessageBox.Show("Please enter gross annual income for farming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (rsbsa.annualIncomeNonFarming == 0)
                {
                    MessageBox.Show("Please enter gross annual income for non-farming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                DialogResult result = MessageBox.Show("Are you sure you want to save this RSBSA record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (rsbsaModel.AddNewRSBSARecord(rsbsa))
                    {
                        if (rsbsaModel.AddNewFarmParcel(farmParcels))
                        {
                            if (rsbsaModel.AddNewRSBSADocument(rsbsaDocuments))
                            {
                                MessageBox.Show("RSBSA Record saved succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                isDone = true;
                            }
                        }
                    }
                }

                return isDone;

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }

        public bool EditRSBSA(
            string rsbsaId,
            string? rsbsaIdLGU,
            string rsbsaIdRegion,
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

                // Create an instance of RSBSA and set its properties
                RSBSA rsbsa = new RSBSA
                {
                    rsbsaId = rsbsaId,
                    rsbsaIdLGU = rsbsaIdLGU,
                    rsbsaIdRegion = rsbsaIdRegion,
                    dateCreated = dateCreated,
                    userId = userId,

                    // Farmer Personal Info
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

                DialogResult result = MessageBox.Show("Are you sure you want to update this RSBSA record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (rsbsaModel.EditRSBSARecord(rsbsa))
                    {
                        if (rsbsaModel.EditFarmParcel(farmParcels))
                        {
                            if (rsbsaModel.EditRSBSADocument(rsbsaDocuments))
                            {
                                MessageBox.Show("RSBSA Record updated succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                isDone = true;
                            }
                        }
                    }
                }

                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Updating RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

    }
}
