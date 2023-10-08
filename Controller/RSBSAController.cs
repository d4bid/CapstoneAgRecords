using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    internal class RSBSAController
    {
        private RsbsaAddView rsbsaAddView;
        private Boolean isDone = false; 
        private string fullName = HomeView.Instance.fullName.Text;
        private RSBSAModel rsbsaModel;
        UserModel userModel = new UserModel();

        public RSBSAController(RsbsaAddView rsbsaAddView)
        {
            this.rsbsaAddView = rsbsaAddView;
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
            int farmParcelCount



            //Farmland Parcel

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
                    farmParcelCount = farmParcelCount


                    // Farmland Parcel

                };


                //if (letter.letterTitle == "")
                //{
                //    MessageBox.Show("Title is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //}
                //else if (letter.letterDescription == "")
                //{
                //    MessageBox.Show("Description is required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //}
                //else if (letter.letterTitle != "" && letter.letterDescription != "" && letter.letterTo != "" && letter.letterFrom != "")
                //{
                    DialogResult result = MessageBox.Show("Are you sure you want to save this letter?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (rsbsaModel.AddNewRSBSARecord(rsbsa))
                        {
                            MessageBox.Show("RSBSA Record saved succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isDone = true;
                        }
                    }
                //    else //cancel saving
                //    {

                //    }
                //}

                // Return true to indicate a successful operation
                return isDone;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Add RSBSA Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }
    }
}
