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
                image.Save(memoryStream,ImageFormat.Png);

                // Convert the memory stream to a byte array and return it
                return memoryStream.ToArray();
            }
        }

        public async Task<bool> AddNewFarmParcelAsync(List<FarmParcel> farmParcels)
        {
            try
            {
                // Use Task.Run to run synchronous code asynchronously
                bool result = await Task.Run(() =>
                {
                    using (DatabaseConnection db = new DatabaseConnection())
                    {
                        db.Open();
                        MySqlTransaction transaction = null;

                        try
                        {
                            // Begin the transaction
                            transaction = db.GetConnection().BeginTransaction();

                            foreach (FarmParcel farmParcel in farmParcels)
                            {
                                // Save data to tbl_farmland_parcel using sp_addNewFarmParcel stored procedure
                                MySqlCommand parcelCommand = new MySqlCommand("sp_addNewFarmParcel", db.GetConnection());
                                parcelCommand.CommandType = CommandType.StoredProcedure;

                                parcelCommand.Parameters.AddWithValue("_rsbsaId", farmParcel.rsbsaId);
                                parcelCommand.Parameters.AddWithValue("_farmParcelNo", farmParcel.farmParcelNo);
                                parcelCommand.Parameters.AddWithValue("_farmLocBrgy", farmParcel.farmLocBrgy);
                                parcelCommand.Parameters.AddWithValue("_farmLocMunicipality", farmParcel.farmLocMunicipality);
                                parcelCommand.Parameters.AddWithValue("_farmSize", farmParcel.farmSize);
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

                            // Commit the transaction
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an exception occurs
                            transaction?.Rollback();
                            throw new ApplicationException("Error adding new farm parcels: " + ex.Message, ex);
                        }
                    }
                });
                return result;
            }
            catch (Exception ex)
            {
                // Handle exceptions here if needed
                // Log the exception, etc.
                return false;
            }

            

        }

        public bool EditFarmParcel(List<FarmParcel> farmParcels)
        {
            using (DatabaseConnection db = new DatabaseConnection())
            {
                db.Open();
                MySqlTransaction transaction = null;

                try
                {
                    // Begin the transaction
                    transaction = db.GetConnection().BeginTransaction();

                    // Call the stored procedure to delete farm parcels by ID
                    if (farmParcels.Count != 0)
                    {
                        MySqlCommand deleteCommand = new MySqlCommand("sp_deleteFarmParcelById", db.GetConnection(), transaction);
                        deleteCommand.CommandType = CommandType.StoredProcedure;
                        deleteCommand.Parameters.AddWithValue("_rsbsaId", farmParcels[0].rsbsaId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    foreach (FarmParcel farmParcel in farmParcels)
                    {
                        // Save data to tbl_farmland_parcel using sp_addNewFarmParcel stored procedure
                        MySqlCommand parcelCommand = new MySqlCommand("sp_addNewFarmParcel", db.GetConnection());
                        parcelCommand.CommandType = CommandType.StoredProcedure;

                        parcelCommand.Parameters.AddWithValue("_rsbsaId", farmParcel.rsbsaId);
                        parcelCommand.Parameters.AddWithValue("_farmParcelNo", farmParcel.farmParcelNo);
                        parcelCommand.Parameters.AddWithValue("_farmLocBrgy", farmParcel.farmLocBrgy);
                        parcelCommand.Parameters.AddWithValue("_farmLocMunicipality", farmParcel.farmLocMunicipality);
                        parcelCommand.Parameters.AddWithValue("_farmSize", farmParcel.farmSize);
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

                    // Commit the transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an exception occurs
                    transaction?.Rollback();
                    throw new ApplicationException("Error updating farm parcels: " + ex.Message, ex);
                }
            }

        }

        public bool AddNewRSBSADocument(List<RSBSADocuments> rsbsaDocuments)
        {
            using (DatabaseConnection db = new DatabaseConnection())
            {
                db.Open();
                MySqlTransaction transaction = null;

                try
                {
                    // Begin the transaction
                    transaction = db.GetConnection().BeginTransaction();

                    foreach (RSBSADocuments rsbsaDocument in rsbsaDocuments)
                    {
                        foreach (var kvp in rsbsaDocument.docPhotoDictionary)
                        {
                            MySqlCommand documentCommand = new MySqlCommand("sp_addNewRSBSADocument", db.GetConnection(), transaction);
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

                    // Commit the transaction
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an exception occurs
                    transaction?.Rollback();
                    throw new ApplicationException("Error adding new RSBSA Document: " + ex.Message, ex);
                }
            }
        }


        public bool EditRSBSADocument(List<RSBSADocuments> rsbsaDocuments)
        {
            using (DatabaseConnection db = new DatabaseConnection())
            {
                db.Open();
                MySqlTransaction transaction = null;

                try
                {
                    // Begin the transaction
                    transaction = db.GetConnection().BeginTransaction();
                    
                    // Call the stored procedure to delete farm parcels by ID
                    if (rsbsaDocuments.Count != 0)
                    {
                        MySqlCommand deleteCommand = new MySqlCommand("sp_deleteRSBSADocsById", db.GetConnection(), transaction);
                        deleteCommand.CommandType = CommandType.StoredProcedure;
                        deleteCommand.Parameters.AddWithValue("_rsbsaId", rsbsaDocuments[0].rsbsaId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    foreach (RSBSADocuments rsbsaDocument in rsbsaDocuments)
                    {
                        foreach (var kvp in rsbsaDocument.docPhotoDictionary)
                        {
                            MySqlCommand documentCommand = new MySqlCommand("sp_addNewRSBSADocument", db.GetConnection(), transaction);
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

                    // Commit the transaction
                    transaction.Commit();
                    return true;

                }
                catch (Exception ex)
                {
                    // Rollback the transaction if an exception occurs
                    transaction?.Rollback();
                    throw new ApplicationException("Error updating RSBSA Document: " + ex.Message, ex);
                }
            }
        }

        public async Task<bool> AddNewRSBSARecordAsync(RSBSA rsbsa)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    await db.OpenAsync();

                    string query = "CALL sp_addNewRSBSARecord(@rsbsaId, @rsbsaIdLGU, @rsbsaIdRegion, @dateCreated, @userId, " +
                                    "@surname, @firstname, @middlename, @extname, @sex, @addrPurok, @addrStreet, @addrBrgy, " +
                                    "@addrMunicipality, @addrProvince, @addrRegion, @educAttainment, @contactNo, @landlineNo, " +
                                    "@withGovId, @govIdType, @govIdNo, @birthDate, @birthMunicipality, @birthProvince, " +
                                    "@birthCountry, @religion, @civilStatus, @spouseName, @maidenName, @isHouseHead, " +
                                    "@houseHeadName, @houseHeadRs, @houseLivingMemCount, @houseMaleCount, @houseFemCount, " +
                                    "@isPWD, @is4Ps, @isIp, @ipGroupName, @isCoopMember, @coopName, @emergContactName, @emergContactNo, " +
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
                    command.Parameters.AddWithValue("@is4Ps", rsbsa.is4Ps);
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

                    await command.ExecuteNonQueryAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Wrap the original exception in a custom exception with a meaningful message.
                throw new ApplicationException("Error adding new RSBSA information: " + ex.Message, ex);
            }
        }

        public Boolean EditRSBSARecord(RSBSA rsbsa)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    string query = "CALL sp_updateRSBSARecord(@rsbsaId, @rsbsaIdLGU, @rsbsaIdRegion, @dateCreated, @userId, " +
                                    "@surname, @firstname, @middlename, @extname, @sex, @addrPurok, @addrStreet, @addrBrgy, " +
                                    "@addrMunicipality, @addrProvince, @addrRegion, @educAttainment, @contactNo, @landlineNo, " +
                                    "@withGovId, @govIdType, @govIdNo, @birthDate, @birthMunicipality, @birthProvince, " +
                                    "@birthCountry, @religion, @civilStatus, @spouseName, @maidenName, @isHouseHead, " +
                                    "@houseHeadName, @houseHeadRs, @houseLivingMemCount, @houseMaleCount, @houseFemCount, " +
                                    "@isPWD, @is4Ps, @isIp, @ipGroupName, @isCoopMember, @coopName, @emergContactName, @emergContactNo, " +
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
                    command.Parameters.AddWithValue("@is4Ps", rsbsa.is4Ps);
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
                throw new ApplicationException("Error updating RSBSA information: " + ex.Message, ex);
            }
        }

        public RSBSA GetRSBSAInfoById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRSBSAInfoById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA rsbsaInfo = null;

                    if (reader.Read())
                    {
                        rsbsaInfo = new RSBSA();
                        rsbsaInfo.rsbsaId = reader["rsbsaId"].ToString();
                        rsbsaInfo.rsbsaIdRegion = reader["rsbsaIdRegion"].ToString();
                        rsbsaInfo.userId = reader["userId"].ToString();
                        rsbsaInfo.dateCreated = DateTime.Parse(reader["dateCreated"].ToString());
                    }

                    reader.Close();
                    return rsbsaInfo;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting RSBSA info by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetFarmerInfoById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmerInfoById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA farmerInfo = null;

                    if (reader.Read())
                    {
                        farmerInfo = new RSBSA();
                        farmerInfo.surname = reader["surname"].ToString();
                        farmerInfo.firstname = reader["firstname"].ToString();
                        farmerInfo.middlename = reader["middlename"].ToString();
                        farmerInfo.extname = reader["extname"].ToString();
                        farmerInfo.sex = reader["sex"].ToString();
                        farmerInfo.addrPurok = reader["addrPurok"].ToString();
                        farmerInfo.addrStreet = reader["addrStreet"].ToString();
                        farmerInfo.addrBrgy = reader["addrBrgy"].ToString();
                        farmerInfo.addrMunicipality = reader["addrMunicipality"].ToString();
                        farmerInfo.addrProvince = reader["addrProvince"].ToString();
                        farmerInfo.addrRegion = reader["addrRegion"].ToString();
                        farmerInfo.educAttainment = reader["educAttainment"].ToString();
                        farmerInfo.contactNo = reader["contactNo"].ToString();
                        farmerInfo.landlineNo = reader["landlineNo"].ToString();
                        farmerInfo.withGovId = reader["withGovId"].ToString();
                        farmerInfo.govIdType = reader["govIdType"].ToString();
                        farmerInfo.govIdNo = reader["govIdNo"].ToString();
                        farmerInfo.birthDate = DateTime.Parse(reader["birthDate"].ToString());
                        farmerInfo.birthMunicipality = reader["birthMunicipality"].ToString();
                        farmerInfo.birthProvince = reader["birthProvince"].ToString();
                        farmerInfo.birthCountry = reader["birthCountry"].ToString();
                        farmerInfo.religion = reader["religion"].ToString();
                        farmerInfo.civilStatus = reader["civilStatus"].ToString();
                        farmerInfo.spouseName = reader["spouseName"].ToString();
                        farmerInfo.maidenName = reader["maidenName"].ToString();
                        farmerInfo.isHouseHead = reader["isHouseHead"].ToString();
                        farmerInfo.houseHeadName = reader["houseHeadName"].ToString();
                        farmerInfo.houseHeadRs = reader["houseHeadRs"].ToString();
                        farmerInfo.houseLivingMemCount = Convert.ToInt32(reader["houseLivingMemCount"]);
                        farmerInfo.houseMaleCount = Convert.ToInt32(reader["houseMaleCount"]);
                        farmerInfo.houseFemCount = Convert.ToInt32(reader["houseFemCount"]);
                        farmerInfo.isPWD = reader["isPWD"].ToString();
                        farmerInfo.is4Ps = reader["is4Ps"].ToString();
                        farmerInfo.isIp = reader["isIp"].ToString();
                        farmerInfo.ipGroupName = reader["ipGroupName"].ToString();
                        farmerInfo.isCoopMember = reader["isCoopMember"].ToString();
                        farmerInfo.coopName = reader["coopName"].ToString();
                        farmerInfo.emergContactName = reader["emergContactName"].ToString();
                        farmerInfo.emergContactNo = reader["emergContactNo"].ToString();
                    }

                    reader.Close();
                    return farmerInfo;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farmer info by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetFarmProfileById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmProfileById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA farmProfile = null;

                    if (reader.Read())
                    {
                        farmProfile = new RSBSA();
                        farmProfile.isFarmer = reader["isFarmer"].ToString();
                        farmProfile.isRiceFarmer = reader["isRiceFarmer"].ToString();
                        farmProfile.isCornFarmer = reader["isCornFarmer"].ToString();
                        farmProfile.otherCrops = reader["otherCrops"].ToString();
                        farmProfile.hasLivestocks = reader["hasLivestocks"].ToString();
                        farmProfile.hasPoultry = reader["hasPoultry"].ToString();
                        farmProfile.isLaborer = reader["isLaborer"].ToString();
                        farmProfile.isPreparingLand = reader["isPreparingLand"].ToString();
                        farmProfile.isPlanting = reader["isPlanting"].ToString();
                        farmProfile.isCultivating = reader["isCultivating"].ToString();
                        farmProfile.isHarvesting = reader["isHarvesting"].ToString();
                        farmProfile.otherLaborWork = reader["otherLaborWork"].ToString();
                        farmProfile.isFisherfolk = reader["isFisherfolk"].ToString();
                        farmProfile.isFishCapturing = reader["isFishCapturing"].ToString();
                        farmProfile.isAquaculture = reader["isAquaculture"].ToString();
                        farmProfile.isGleaning = reader["isGleaning"].ToString();
                        farmProfile.isFishProcessing = reader["isFishProcessing"].ToString();
                        farmProfile.isFishVending = reader["isFishVending"].ToString();
                        farmProfile.otherFishingAct = reader["otherFishingAct"].ToString();
                        farmProfile.isAgriYouth = reader["isAgriYouth"].ToString();
                        farmProfile.isPartOfFarmingHousehold = reader["isPartOfFarmingHousehold"].ToString();
                        farmProfile.isAttendAgrifishery = reader["isAttendAgrifishery"].ToString();
                        farmProfile.isParticipantAgriProgram = reader["isParticipantAgriProgram"].ToString();
                        farmProfile.otherAgriYouthAct = reader["otherAgriYouthAct"].ToString();
                        farmProfile.annualIncomeFarming = reader["annualIncomeFarming"] != DBNull.Value ? Convert.ToDouble(reader["annualIncomeFarming"]) : 0.0;
                        farmProfile.annualIncomeNonFarming = reader["annualIncomeNonFarming"] != DBNull.Value ? Convert.ToDouble(reader["annualIncomeNonFarming"]) : 0.0;
                    }


                    reader.Close();
                    return farmProfile;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farm profile info by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetFarmlandById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmlandById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA farmland = null;

                    if (reader.Read())
                    {
                        farmland = new RSBSA();
                        farmland.rotatingFarmers = reader["rotatingFarmers"].ToString();
                        farmland.farmParcelCount = Convert.ToInt32(reader["farmParcelCount"]);
                    }


                    reader.Close();
                    return farmland;
                }

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farmland info by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetFarmlandParcelsById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmlandParcelById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA parcel = null;

                    if (reader.HasRows)
                    {
                        parcel = new RSBSA();
                        parcel.farmParcels = new List<FarmParcel>();

                        while (reader.Read())
                        {
                            FarmParcel farmParcel = new FarmParcel();
                            farmParcel.rsbsaId = reader["rsbsaId"].ToString();
                            farmParcel.farmParcelNo = reader["farmParcelNo"].ToString();
                            farmParcel.farmLocBrgy = reader["farmLocBrgy"].ToString();
                            farmParcel.farmLocMunicipality = reader["farmLocMunicipality"].ToString();
                            farmParcel.farmSize = reader["farmSize"] != DBNull.Value ? Convert.ToDouble(reader["farmSize"]) : 0.0;
                            farmParcel.isAncestralDomain = reader["isAncestralDomain"].ToString();
                            farmParcel.ownershipNo = reader["ownershipNo"].ToString();
                            farmParcel.isAgrarianBeneficiary = reader["isAgrarianBeneficiary"].ToString();
                            farmParcel.isRegisteredOwner = reader["isRegisteredOwner"].ToString();
                            farmParcel.ownershipType = reader["ownershipType"].ToString();
                            farmParcel.ownerName = reader["ownerName"].ToString();
                            farmParcel.remarks = reader["remarks"].ToString();

                            parcel.farmParcels.Add(farmParcel);
                        }
                    }

                    reader.Close();
                    return parcel;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farmland parcels info by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetFarmlandParcelCropsById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getFarmlandParcelCropsById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA parcelCrops = null;

                    if (reader.HasRows)
                    {
                        parcelCrops = new RSBSA();
                        parcelCrops.farmParcelCrops = new List<FarmParcelCrop>();

                        while (reader.Read())
                        {
                            FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                            farmParcelCrop.farmParcelNo = reader["farmParcelNo"].ToString();
                            farmParcelCrop.commodityType = reader["commodityType"].ToString();
                            farmParcelCrop.landSize = reader["landSize"] != DBNull.Value ? Convert.ToDouble(reader["landSize"]) : 0.0;
                            farmParcelCrop.headCount = reader["headCount"] != DBNull.Value ? Convert.ToInt32(reader["headCount"]) : 0;
                            farmParcelCrop.farmType = reader["farmType"].ToString();
                            farmParcelCrop.isOrganic = reader["isOrganic"].ToString();

                            parcelCrops.farmParcelCrops.Add(farmParcelCrop);
                        }
                    }

                    reader.Close();
                    return parcelCrops;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting farmland parcel crops by ID: " + ex.Message, ex);
            }
        }

        public RSBSA GetDocsById(string rsbsaId)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("CALL sp_getRSBSADocsById(@rsbsaId)", db.GetConnection());
                    command.Parameters.AddWithValue("@rsbsaId", rsbsaId);

                    MySqlDataReader reader = command.ExecuteReader();

                    RSBSA docs = null;

                    if (reader.HasRows)
                    {
                        docs = new RSBSA();
                        docs.rsbsaDocuments = new List<RSBSADocuments>();

                        while (reader.Read())
                        {
                            RSBSADocuments document = new RSBSADocuments();
                            document.rsbsaId = reader["rsbsaId"].ToString();
                            document.docType = reader["docType"].ToString();
                            document.docFilename = reader["docFilename"].ToString();
                            string docFilename = reader["docFilename"].ToString();

                            // Check if "docPhoto" field is not DBNull
                            if (reader["docPhoto"] != DBNull.Value)
                            {
                                // Convert byte array to image
                                byte[] docPhotoBytes = (byte[])reader["docPhoto"];
                                Image docImage = GetImageFromByteArray(docPhotoBytes);

                                // Add image to the document only if it is not null
                                if (docImage != null)
                                {
                                    document.docPhotoDictionary.Add(docFilename, docImage);
                                    docs.rsbsaDocuments.Add(document);
                                }
                            }
                        }
                    }

                    reader.Close();
                    return docs;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error getting documents by ID: " + ex.Message, ex);
            }
        }

        //method to convert byte array to Image
        private Image GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public bool CheckFarmerExistence(string firstName, string middleName, string lastName, string suffixAndExtension, string birthdate)
        {
            try
            {
                using (DatabaseConnection db = new DatabaseConnection())
                {
                    db.Open();

                    MySqlCommand command = new MySqlCommand("sp_isFarmerAlreadySaved", db.GetConnection());
                    command.CommandType = CommandType.StoredProcedure;

                    // Add input parameters
                    command.Parameters.AddWithValue("@_FirstName", firstName);
                    command.Parameters.AddWithValue("@_MiddleName", middleName);
                    command.Parameters.AddWithValue("@_LastName", lastName);
                    command.Parameters.AddWithValue("@_SuffixAndExtension", suffixAndExtension);
                    command.Parameters.AddWithValue("@_Birthdate", birthdate);

                    // Add output parameter
                    MySqlParameter outputParameter = new MySqlParameter("@IsFarmerAlreadySaved", MySqlDbType.Bit);
                    outputParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParameter);

                    command.ExecuteNonQuery();

                    // Get the boolean result from the output parameter
                    bool isFarmerAlreadySaved = Convert.ToBoolean(outputParameter.Value);

                    return isFarmerAlreadySaved;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error checking farmer existence: " + ex.Message, ex);
            }
        }






    }
}
