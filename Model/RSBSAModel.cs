using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class RSBSAModel
    {
        //generate new RSBSA ID
        public string GenerateRSBSAId()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_selectMaxRSBSAId", db.GetConnection());

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                    {
                        return "RSBSA000001";
                    }
                    else
                    {
                        string lastId = result.ToString();
                        int lastNumber = int.Parse(lastId.Substring(6));
                        int nextNumber = lastNumber + 1;
                        string nextId = "RSBSA" + nextNumber.ToString("000000");
                        return nextId;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error generating RSBSA ID: " + ex.Message, ex);
            }
        }

        public Boolean AddNewRSBSAInfo(RSBSA rsbsaInfo)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewRSBSAInfo(@rsbsaId, @rsbsaNo, @enrollType, @dateAdmin, @refNo, @userId)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaInfo.rsbsaId);
                    command.Parameters.AddWithValue("@rsbsaIdRegion", rsbsaInfo.rsbsaIdRegion);
                    command.Parameters.AddWithValue("@dateAdmin", rsbsaInfo.dateCreated);
                    command.Parameters.AddWithValue("@userId", rsbsaInfo.userId);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new RSBSA info: " + ex.Message, ex);
            }
        }

        public Boolean AddNewFarmerInfo(RSBSAPersonalInfo farmerInfo)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewFarmerInfo(@rsbsaId, @surname, @firstname, @middlename, " +
                                    "@extname, @sex, @addrPurok, @addrStreet, @addrBrgy, @addrMunicipality, " +
                                    "@addrProvince, @addrRegion, @educAttainment, @contactNo, @landlineNo, " +
                                    "@withGovId, @govIdType, @govIdNo, @birthDate, @birthMunicipality, " +
                                    "@birthProvince, @birthCountry, @religion, @civilStatus, @spouseName, " +
                                    "@maidenName, @isHouseHead, @houseHeadName, @houseHeadRs, @houseLivingMemCount, " +
                                    "@houseMaleCount, @houseFemCount, @isPWD, @isIp, @ipGroupName, @isCoopMember, @coopName, " +
                                    "@emergContactName, @emergContactNo)";

                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", farmerInfo.rsbsaId);
                    command.Parameters.AddWithValue("@surname", farmerInfo.surname);
                    command.Parameters.AddWithValue("@firstname", farmerInfo.firstname);
                    command.Parameters.AddWithValue("@middlename", farmerInfo.middlename);
                    command.Parameters.AddWithValue("@extname", farmerInfo.extname);
                    command.Parameters.AddWithValue("@sex", farmerInfo.sex);
                    command.Parameters.AddWithValue("@addrPurok", farmerInfo.addrPurok);
                    command.Parameters.AddWithValue("@addrStreet", farmerInfo.addrStreet);
                    command.Parameters.AddWithValue("@addrBrgy", farmerInfo.addrBrgy);
                    command.Parameters.AddWithValue("@addrMunicipality", farmerInfo.addrMunicipality);
                    command.Parameters.AddWithValue("@addrProvince", farmerInfo.addrProvince);
                    command.Parameters.AddWithValue("@addrRegion", farmerInfo.addrRegion);
                    command.Parameters.AddWithValue("@educAttainment", farmerInfo.educAttainment);
                    command.Parameters.AddWithValue("@contactNo", farmerInfo.contactNo);
                    command.Parameters.AddWithValue("@landlineNo", farmerInfo.landlineNo);
                    command.Parameters.AddWithValue("@withGovId", farmerInfo.withGovId);
                    command.Parameters.AddWithValue("@govIdType", farmerInfo.govIdType);
                    command.Parameters.AddWithValue("@govIdNo", farmerInfo.govIdNo);
                    command.Parameters.AddWithValue("@birthDate", farmerInfo.birthDate);
                    command.Parameters.AddWithValue("@birthMunicipality", farmerInfo.birthMunicipality);
                    command.Parameters.AddWithValue("@birthProvince", farmerInfo.birthProvince);
                    command.Parameters.AddWithValue("@birthCountry", farmerInfo.birthCountry);
                    command.Parameters.AddWithValue("@religion", farmerInfo.religion);
                    command.Parameters.AddWithValue("@civilStatus", farmerInfo.civilStatus);
                    command.Parameters.AddWithValue("@spouseName", farmerInfo.spouseName);
                    command.Parameters.AddWithValue("@maidenName", farmerInfo.maidenName);
                    command.Parameters.AddWithValue("@isHouseHead", farmerInfo.isHouseHead);
                    command.Parameters.AddWithValue("@houseHeadName", farmerInfo.houseHeadName);
                    command.Parameters.AddWithValue("@houseHeadRs", farmerInfo.houseHeadRs);
                    command.Parameters.AddWithValue("@houseLivingMemCount", farmerInfo.houseLivingMemCount);
                    command.Parameters.AddWithValue("@houseMaleCount", farmerInfo.houseMaleCount);
                    command.Parameters.AddWithValue("@houseFemCount", farmerInfo.houseFemCount);
                    command.Parameters.AddWithValue("@isPWD", farmerInfo.isPWD);
                    command.Parameters.AddWithValue("@isIp", farmerInfo.isIp);
                    command.Parameters.AddWithValue("@ipGroupName", farmerInfo.ipGroupName);
                    command.Parameters.AddWithValue("@isCoopMember", farmerInfo.isCoopMember);
                    command.Parameters.AddWithValue("@coopName", farmerInfo.coopName);
                    command.Parameters.AddWithValue("@emergContactName", farmerInfo.emergContactName);
                    command.Parameters.AddWithValue("@emergContactNo", farmerInfo.emergContactNo);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new farmer information: " + ex.Message, ex);
            }
        }


        public Boolean AddNewFarmProfile(RSBSAFarmProfile farmProfile)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewFarmProfile(@rsbsaId, @livelihoodType, @farmingAct, @workKind, @fishingAct, @involveType, @gaiFarming, @gaiNonFarming)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", farmProfile.rsbsaId);
                    command.Parameters.AddWithValue("@livelihoodType", farmProfile.livelihoodType);
                    command.Parameters.AddWithValue("@farmingAct", farmProfile.farmingAct);
                    command.Parameters.AddWithValue("@workKind", farmProfile.workKind);
                    command.Parameters.AddWithValue("@fishingAct", farmProfile.fishingAct);
                    command.Parameters.AddWithValue("@involveType", farmProfile.involveType);
                    command.Parameters.AddWithValue("@gaiFarming", farmProfile.gaiFarming);
                    command.Parameters.AddWithValue("@gaiNonFarming", farmProfile.gaiNonFarming);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new farm profile: " + ex.Message, ex);
            }
        }

        public Boolean AddNewFarmland(RSBSAFarmland farmLand)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewFarmland(@rsbsaId, @farmers, @farmParcelCount)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", farmLand.rsbsaId);
                    command.Parameters.AddWithValue("@farmers", farmLand.farmers);
                    command.Parameters.AddWithValue("@farmParcelCount", farmLand.farmParcelCount);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new farmland: " + ex.Message, ex);
            }
        }

        public Boolean AddNewFarmParcel(RSBSAFarmParcel farmParcel)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewFarmParcel(@rsbsaId, @farmLocBrgy, @farmLocMunicipality, @withAncestralDomain, @isAgrarianBeneficiary, @ownershipNo, @ownershipType, @ownerName, @farmCommodity, @livestockPoultry, @farmSize, @headCount, @farmType, @isOrganicPractitioner, @remarks)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", farmParcel.rsbsaId);
                    command.Parameters.AddWithValue("@farmLocBrgy", farmParcel.farmLocBrgy);
                    command.Parameters.AddWithValue("@farmLocMunicipality", farmParcel.farmLocMunicipality);
                    command.Parameters.AddWithValue("@withAncestralDomain", farmParcel.withAncestralDomain);
                    command.Parameters.AddWithValue("@isAgrarianBeneficiary", farmParcel.isAgrarianBeneficiary);
                    command.Parameters.AddWithValue("@ownershipNo", farmParcel.ownershipNo);
                    command.Parameters.AddWithValue("@ownershipType", farmParcel.ownershipType);
                    command.Parameters.AddWithValue("@ownerName", farmParcel.ownerName);
                    command.Parameters.AddWithValue("@farmCommodity", farmParcel.farmCommodity);
                    command.Parameters.AddWithValue("@livestockPoultry", farmParcel.livestockPoultry);
                    command.Parameters.AddWithValue("@farmSize", farmParcel.farmSize);
                    command.Parameters.AddWithValue("@headCount", farmParcel.headCount);
                    command.Parameters.AddWithValue("@farmType", farmParcel.farmType);
                    command.Parameters.AddWithValue("@isOrganicPractitioner", farmParcel.isOrganicPractitioner);
                    command.Parameters.AddWithValue("@remarks", farmParcel.remarks);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new farm parcel: " + ex.Message, ex);
            }
        }

        public Boolean AddNewRSBSADocument(string rsbsaId, string farmers, int farmParcelCount, Image docPhoto, string docFileName)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewRSBSADocument(@rsbsaId, @farmers, @farmParcelCount, @docPhoto, @docFileName)";
                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);
                    command.Parameters.AddWithValue("@farmers", farmers);
                    command.Parameters.AddWithValue("@farmParcelCount", farmParcelCount);
                    command.Parameters.AddWithValue("@docFileName", docFileName);

                    // Convert the Image to a byte array
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        docPhoto.Save(ms, ImageFormat.Jpeg); // Replace with the appropriate image format
                        imageBytes = ms.ToArray();
                    }

                    command.Parameters.AddWithValue("@docPhoto", imageBytes);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new RSBSA document: " + ex.Message, ex);
            }
        }

        public Boolean AddNewRSBSARecord(RSBSA rsbsa)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_addNewRSBSARecord(@rsbsaId, @rsbsaIdLGU, @rsbsaIdRegion, @dateCreated, @userId, " +
                                    "@surname, @firstname, @middlename, @extname, @sex, @addrPurok, @addrStreet, @addrBrgy, " +
                                    "@addrMunicipality, @addrProvince, @addrRegion, @educAttainment, @contactNo, @landlineNo, " +
                                    "@withGovId, @govIdType, @govIdNo, @birthDate, @birthMunicipality, @birthProvince, " +
                                    "@birthCountry, @religion, @civilStatus, @spouseName, @maidenName, @isHouseHead, " +
                                    "@houseHeadName, @houseHeadRs, @houseLivingMemCount, @houseMaleCount, @houseFemCount, " +
                                    "@isPWD, @isIp, @ipGroupName, @isCoopMember, @coopName, @emergContactName, @emergContactNo, " +
                                    "@isFarmer, @isRiceFarmer, @isCornFarmer, @otherCrops, @hasLivestocks, @hasPoultry, " +
                                    "@isLaborer, @isPreparingLand, @isPlanting, @isCultivating, @isHarvesting, @otherLaborWork, " +
                                    "@isFisherfolk, @isFishCapturing, @isAquaculture, @isGleaning, @isFishProcessing, " +
                                    "@isFishVending, @otherFishingAct, @isAgriYouth, @isPartOfFarmingHousehold, " +
                                    "@isAttendAgrifishery, @isParticipantAgriProgram, @otherAgriYouthAct, @annualIncomeFarming, " +
                                    "@annualIncomeNonFarming, @rotatingFarmers, @farmParcelCount)";

                    MySqlCommand command = new MySqlCommand(query, db.GetConnection());
                    //for rsbsa info table
                    command.Parameters.AddWithValue("@rsbsaId", rsbsa.rsbsaId);
                    command.Parameters.AddWithValue("@rsbsaIdLGU", rsbsa.rsbsaIdLGU);
                    command.Parameters.AddWithValue("@rsbsaIdRegion", rsbsa.rsbsaIdRegion);
                    command.Parameters.AddWithValue("@dateCreated", rsbsa.dateCreated);
                    command.Parameters.AddWithValue("@userId", rsbsa.userId);

                    //for farmer info table
                    command.Parameters.AddWithValue("@surname", rsbsa.surname);
                    command.Parameters.AddWithValue("@firstname", rsbsa.firstname);
                    command.Parameters.AddWithValue("@middlename", rsbsa.middlename);
                    command.Parameters.AddWithValue("@extname", rsbsa.extname);
                    command.Parameters.AddWithValue("@sex", rsbsa.sex);
                    command.Parameters.AddWithValue("@addrPurok", rsbsa.addrPurok);
                    command.Parameters.AddWithValue("@addrStreet", rsbsa.addrStreet);
                    command.Parameters.AddWithValue("@addrBrgy", rsbsa.addrBrgy);
                    command.Parameters.AddWithValue("@addrMunicipality", rsbsa.addrMunicipality);
                    command.Parameters.AddWithValue("@addrProvince", rsbsa.addrProvince);
                    command.Parameters.AddWithValue("@addrRegion", rsbsa.addrRegion);
                    command.Parameters.AddWithValue("@educAttainment", rsbsa.educAttainment);
                    command.Parameters.AddWithValue("@contactNo", rsbsa.contactNo);
                    command.Parameters.AddWithValue("@landlineNo", rsbsa.landlineNo);
                    command.Parameters.AddWithValue("@withGovId", rsbsa.withGovId);
                    command.Parameters.AddWithValue("@govIdType", rsbsa.govIdType);
                    command.Parameters.AddWithValue("@govIdNo", rsbsa.govIdNo);
                    command.Parameters.AddWithValue("@birthDate", rsbsa.birthDate);
                    command.Parameters.AddWithValue("@birthMunicipality", rsbsa.birthMunicipality);
                    command.Parameters.AddWithValue("@birthProvince", rsbsa.birthProvince);
                    command.Parameters.AddWithValue("@birthCountry", rsbsa.birthCountry);
                    command.Parameters.AddWithValue("@religion", rsbsa.religion);
                    command.Parameters.AddWithValue("@civilStatus", rsbsa.civilStatus);
                    command.Parameters.AddWithValue("@spouseName", rsbsa.spouseName);
                    command.Parameters.AddWithValue("@maidenName", rsbsa.maidenName);
                    command.Parameters.AddWithValue("@isHouseHead", rsbsa.isHouseHead);
                    command.Parameters.AddWithValue("@houseHeadName", rsbsa.houseHeadName);
                    command.Parameters.AddWithValue("@houseHeadRs", rsbsa.houseHeadRs);
                    command.Parameters.AddWithValue("@houseLivingMemCount", rsbsa.houseLivingMemCount);
                    command.Parameters.AddWithValue("@houseMaleCount", rsbsa.houseMaleCount);
                    command.Parameters.AddWithValue("@houseFemCount", rsbsa.houseFemCount);
                    command.Parameters.AddWithValue("@isPWD", rsbsa.isPWD);
                    command.Parameters.AddWithValue("@isIp", rsbsa.isIp);
                    command.Parameters.AddWithValue("@ipGroupName", rsbsa.ipGroupName);
                    command.Parameters.AddWithValue("@isCoopMember", rsbsa.isCoopMember);
                    command.Parameters.AddWithValue("@coopName", rsbsa.coopName);
                    command.Parameters.AddWithValue("@emergContactName", rsbsa.emergContactName);
                    command.Parameters.AddWithValue("@emergContactNo", rsbsa.emergContactNo);

                    //for farm profile table
                    command.Parameters.AddWithValue("@isFarmer", rsbsa.isFarmer);
                    command.Parameters.AddWithValue("@isRiceFarmer", rsbsa.isRiceFarmer);
                    command.Parameters.AddWithValue("@isCornFarmer", rsbsa.isCornFarmer);
                    command.Parameters.AddWithValue("@otherCrops", rsbsa.otherCrops);
                    command.Parameters.AddWithValue("@hasLivestocks", rsbsa.hasLivestocks);
                    command.Parameters.AddWithValue("@hasPoultry", rsbsa.hasPoultry);
                    command.Parameters.AddWithValue("@isLaborer", rsbsa.isLaborer);
                    command.Parameters.AddWithValue("@isPreparingLand", rsbsa.isPreparingLand);
                    command.Parameters.AddWithValue("@isPlanting", rsbsa.isPlanting);
                    command.Parameters.AddWithValue("@isCultivating", rsbsa.isCultivating);
                    command.Parameters.AddWithValue("@isHarvesting", rsbsa.isHarvesting);
                    command.Parameters.AddWithValue("@otherLaborWork", rsbsa.otherLaborWork);
                    command.Parameters.AddWithValue("@isFisherfolk", rsbsa.isFisherfolk);
                    command.Parameters.AddWithValue("@isFishCapturing", rsbsa.isFishCapturing);
                    command.Parameters.AddWithValue("@isAquaculture", rsbsa.isAquaculture);
                    command.Parameters.AddWithValue("@isGleaning", rsbsa.isGleaning);
                    command.Parameters.AddWithValue("@isFishProcessing", rsbsa.isFishProcessing);
                    command.Parameters.AddWithValue("@isFishVending", rsbsa.isFishVending);
                    command.Parameters.AddWithValue("@otherFishingAct", rsbsa.otherFishingAct);
                    command.Parameters.AddWithValue("@isAgriYouth", rsbsa.isAgriYouth);
                    command.Parameters.AddWithValue("@isPartOfFarmingHousehold", rsbsa.isPartOfFarmingHousehold);
                    command.Parameters.AddWithValue("@isAttendAgrifishery", rsbsa.isAttendAgrifishery);
                    command.Parameters.AddWithValue("@isParticipantAgriProgram", rsbsa.isParticipantAgriProgram);
                    command.Parameters.AddWithValue("@otherAgriYouthAct", rsbsa.otherAgriYouthAct);
                    command.Parameters.AddWithValue("@annualIncomeFarming", rsbsa.annualIncomeFarming);
                    command.Parameters.AddWithValue("@annualIncomeNonFarming", rsbsa.annualIncomeNonFarming);

                    //for farmland table
                    command.Parameters.AddWithValue("@rotatingFarmers", rsbsa.rotatingFarmers);
                    command.Parameters.AddWithValue("@farmParcelCount", rsbsa.farmParcelCount);

                    //for farmland parcel table



                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new RSBSA information: " + ex.Message, ex);
            }
        }




    }
}
