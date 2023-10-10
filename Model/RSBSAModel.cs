using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable LoadRSBSADataGrid()
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();
                    DataTable dataTable = new DataTable();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM vw_get_all_rsbsa;", db.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error loading RSBSA records: " + ex.Message, ex);
            }
        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Save the image to the memory stream in the desired format (e.g., JPEG)
                image.Save(memoryStream, ImageFormat.Jpeg);

                // Convert the memory stream to a byte array and return it
                return memoryStream.ToArray();
            }
        }

        public bool AddNewFarmParcel(List<FarmParcel> farmParcels)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    foreach (FarmParcel farmParcel in farmParcels)
                    {
                        // Save data to tbl_farmland_parcel using sp_addNewFarmParcel stored procedure
                        MySqlCommand parcelCommand = new MySqlCommand("sp_addNewFarmParcel", db.GetConnection());
                        parcelCommand.CommandType = CommandType.StoredProcedure;

                        parcelCommand.Parameters.AddWithValue("_rsbsaId", farmParcel.rsbsaId);
                        parcelCommand.Parameters.AddWithValue("_farmParcelNo", farmParcel.farmParcelNo);
                        parcelCommand.Parameters.AddWithValue("_farmLocBrgy", farmParcel.farmLocBrgy);
                        parcelCommand.Parameters.AddWithValue("_farmLocMunicipality", farmParcel.farmLocMunicipality);
                        parcelCommand.Parameters.AddWithValue("_isAncestralDomain", farmParcel.isAncestralDomain);
                        parcelCommand.Parameters.AddWithValue("_isAgrarianBeneficiary", farmParcel.isAgrarianBeneficiary);
                        parcelCommand.Parameters.AddWithValue("_ownershipNo", farmParcel.ownershipNo);
                        parcelCommand.Parameters.AddWithValue("_isRegisteredOwner", farmParcel.isRegisteredOwner);
                        parcelCommand.Parameters.AddWithValue("_ownershipType", farmParcel.ownershipType);
                        parcelCommand.Parameters.AddWithValue("_ownerName", farmParcel.ownerName);
                        parcelCommand.Parameters.AddWithValue("_remarks", farmParcel.remarks);

                        parcelCommand.ExecuteNonQuery();

                        // Save data to tbl_farmland_parcel_crops using sp_addNewFarmParcelCrops stored procedure
                        foreach (FarmParcelCrop crop in farmParcel.Crops)
                        {
                            MySqlCommand cropCommand = new MySqlCommand("sp_addNewFarmParcelCrops", db.GetConnection());
                            cropCommand.CommandType = CommandType.StoredProcedure;

                            cropCommand.Parameters.AddWithValue("_rsbsaId", crop.rsbsaId);
                            cropCommand.Parameters.AddWithValue("_farmParcelNo", crop.farmParcelNo);
                            cropCommand.Parameters.AddWithValue("_commodityType", crop.commodityType);
                            cropCommand.Parameters.AddWithValue("_landSize", crop.landSize);
                            cropCommand.Parameters.AddWithValue("_headCount", crop.headCount);
                            cropCommand.Parameters.AddWithValue("_farmType", crop.farmType);
                            cropCommand.Parameters.AddWithValue("_isOrganic", crop.isOrganic);

                            cropCommand.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and return false if there is an error
                throw new ApplicationException("Error adding new farm parcels: " + ex.Message, ex);
            }
        }

        public bool AddNewRSBSADocument(List<RSBSADocuments> rsbsaDocuments)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    foreach (RSBSADocuments rsbsaDocument in rsbsaDocuments)
                    {
                        foreach (var kvp in rsbsaDocument.docPhotoDictionary)
                        {
                            MySqlCommand documentCommand = new MySqlCommand("sp_addNewRSBSADocument", db.GetConnection());
                            documentCommand.CommandType = CommandType.StoredProcedure;

                            documentCommand.Parameters.AddWithValue("_rsbsaId", rsbsaDocument.rsbsaId);
                            documentCommand.Parameters.AddWithValue("_docType", rsbsaDocument.docType);
                            documentCommand.Parameters.AddWithValue("_docFilename", kvp.Key); // Filename from the dictionary

                            byte[] docPhotoBytes = ConvertImageToByteArray(kvp.Value);

                            // Add the image data to the database command parameters
                            documentCommand.Parameters.AddWithValue("_docPhoto", docPhotoBytes);

                            documentCommand.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions and return false if there is an error
                throw new ApplicationException("Error adding new RSBSA Document: " + ex.Message, ex);
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
