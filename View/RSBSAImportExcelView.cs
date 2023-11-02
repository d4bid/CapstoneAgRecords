using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgRecords.Model;
using ExcelDataReader;

namespace AgRecords.View
{
    public partial class RSBSAImportExcelView : Form
    {

        RSBSAModel rsbsaModel = new RSBSAModel();
        UserModel userModel = new UserModel();
        private string fullName = HomeView.Instance.fullName.Text;
        private string username = HomeView.Instance.username.Text;

        public RSBSAImportExcelView()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                dgvRSBSAtoImport.DataSource = null;
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true } });

                                // Check if the DataSet contains tables and if those tables have rows
                                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
                                {
                                    dgvRSBSAtoImport.DataSource = result.Tables[txtSheetName.Text];
                                }
                                else
                                {
                                    MessageBox.Show("No data found in the Excel file.");
                                }
                            } // Reader is automatically disposed of after this block
                        } // FileStream is automatically closed and disposed of after this block
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}\nPlease close the Excel file and try again.", "File In Use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } // OpenFileDialog is automatically closed after this block
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder failedRecords = new StringBuilder();
            int totalRows = 0;
            string userId = userModel.FindUserIDByFullName(fullName);


            // Count rows that meet the condition
            foreach (DataRow row in ((DataTable)dgvRSBSAtoImport.DataSource).Rows)
            {
                if (row["RSBSA REFERENCE NUMBER"] != null && row["RSBSA REFERENCE NUMBER"].ToString().StartsWith("02-50"))
                {
                    totalRows++;
                }
            }

            // Set the ProgressBar properties
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalRows;
            progressBar1.Value = 0;

            // Iterate through DataTable rows and insert into the database
            foreach (DataRow row in ((DataTable)dgvRSBSAtoImport.DataSource).Rows)
            {
                // Check if the value in the first column starts with '02-50'
                if (row["RSBSA REFERENCE NUMBER"] != null && row["RSBSA REFERENCE NUMBER"].ToString().StartsWith("02-50"))
                {
                    string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy" };
                    DateTime excelDate;

                    if (DateTime.TryParseExact(row["BIRTHDATE (MM/DD/CCYY)"].ToString(), dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out excelDate))
                    {
                        StringBuilder sb = new StringBuilder();
                        RSBSA rsbsa = new RSBSA();

                        // Convert the date to the database format "yyyy-MM-dd"
                        string databaseDate = excelDate.ToString("yyyy-MM-dd");

                        string lastNameQualifier = row.Table.Columns.Contains("LAST NAME / QUALIFIER") ? row["LAST NAME / QUALIFIER"].ToString() : null;
                        string lastName = row.Table.Columns.Contains("LAST NAME") ? row["LAST NAME"].ToString() : null;

                        if (rsbsaModel.CheckRefNoExistence(row["RSBSA REFERENCE NUMBER"].ToString()))
                        {
                            // Farmer with the provided details already exists in the database
                            //TO DO: UPDATE THE EXISTING RSBSA USING THE SAME ROWS USED IN THE 'ELSE' PART

                            RSBSAModel rsbsaModel = new RSBSAModel();
                            string getRsbsaId = rsbsaModel.GetRSBSAIDByRefNo(row["RSBSA REFERENCE NUMBER"].ToString());

                            // Farmer with the provided details does not exist in the database

                            //Farmer Info
                            rsbsa.rsbsaId = getRsbsaId;
                            rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            //rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            rsbsa.surname = lastNameQualifier ?? lastName;
                            rsbsa.firstname = row["FIRST \nNAME"].ToString();
                            rsbsa.middlename = row["MIDDLE \nNAME"].ToString();
                            rsbsa.extname = row["EXT. NAME"].ToString();
                            rsbsa.withGovId = !string.IsNullOrWhiteSpace(row["ID \nNUMBER"].ToString()) ? "Yes" : "No";
                            rsbsa.govIdNo = row["ID \nNUMBER"].ToString();
                            rsbsa.govIdType = row["ID NO. \nTYPE"].ToString();
                            rsbsa.contactNo = row["MOBILE NO."].ToString();
                            rsbsa.addrStreet = row["PERMANENT ADDRESS 1\n- NO., STREET"].ToString();
                            rsbsa.addrBrgy = row["PERMANENT ADDRESS 2\n- BRGY/VILL"].ToString();
                            rsbsa.addrMunicipality = row["PERMANENT \nCITY"].ToString();
                            rsbsa.addrProvince = row["PERMANENT \nPROVINCE"].ToString();
                            rsbsa.birthDate = excelDate;
                            rsbsa.birthMunicipality = row["PLACE OF \nBIRTH"].ToString();
                            rsbsa.maidenName = row["MOTHER'S \nMAIDEN NAME"].ToString();
                            rsbsa.sex = (row["GENDER"].ToString().Equals("F", StringComparison.OrdinalIgnoreCase)) ? "FEMALE" : rsbsa.sex;
                            rsbsa.sex = (row["GENDER"].ToString().Equals("M", StringComparison.OrdinalIgnoreCase)) ? "MALE" : rsbsa.sex;

                            string nonParcel;
                            int parsedValue = 0;

                            //if value is integer...
                            if (int.TryParse(row["# OF FARM PARCEL"].ToString(), out parsedValue))
                            {
                                // Parsing successful, set rsbsa.farmParcelCount to the parsed value
                                rsbsa.farmParcelCount = parsedValue;
                                rsbsa.isFarmer = "Yes";
                            }
                            else //if value is string
                            {
                                // Parsing failed, get the text and pass it to nonParcel
                                nonParcel = row["# OF FARM PARCEL"].ToString();
                                rsbsa.farmParcelCount = 0;

                                if (nonParcel.Contains("FARMWORKER", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isLaborer = "Yes";
                                    rsbsa.otherLaborWork = nonParcel;
                                }
                                else if (nonParcel.Contains("RAIS", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isFarmer = "Yes";
                                    rsbsa.hasLivestocks = nonParcel;
                                }
                                else if (nonParcel.Contains("YOUTH", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isAgriYouth = "Yes";
                                    rsbsa.otherAgriYouthAct = nonParcel;
                                }
                            }

                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.farmParcelCrops = new List<FarmParcelCrop>();
                            rsbsa.dateModified = DateTime.Now;
                            rsbsa.lastModifier = username;

                            //Initialize farmparcel
                            FarmParcel farmParcel = new FarmParcel();
                            farmParcel.farmParcelNo = "1";
                            farmParcel.rsbsaId = getRsbsaId;
                            farmParcel.farmLocBrgy = row["PERMANENT ADDRESS 2\n- BRGY/VILL"].ToString();
                            farmParcel.farmLocMunicipality = row["PERMANENT \nCITY"].ToString();
                            farmParcel.farmSize = row["TOTAL FARM AREA (Ha)"] != null && Double.TryParse(row["TOTAL FARM AREA (Ha)"].ToString(), out double farmArea) ? farmArea : 0.0;

                            farmParcel.Crops = new List<FarmParcelCrop>();

                            if (double.TryParse(row["RICE"].ToString(), out double riceArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "Rice";
                                farmParcelCrop.landSize = riceArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getRsbsaId;
                                farmParcel.Crops.Add(farmParcelCrop);
                                rsbsa.isRiceFarmer = "Yes";

                            }

                            if (double.TryParse(row["CORN"].ToString(), out double cornArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "Corn";
                                farmParcelCrop.landSize = cornArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getRsbsaId;
                                farmParcel.Crops.Add(farmParcelCrop);
                                rsbsa.isCornFarmer = "Yes";

                            }

                            if (double.TryParse(row["HVC"].ToString(), out double hvcArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "HVC";
                                farmParcelCrop.landSize = hvcArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getRsbsaId;
                                farmParcel.Crops.Add(farmParcelCrop);
                                rsbsa.otherCrops = "HVC";

                            }

                            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("AGRI-FISHERY"))
                            {
                                if (double.TryParse(row["AGRI-FISHERY"].ToString(), out double agriFisheryArea))
                                {
                                    FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                    farmParcelCrop.commodityType = "Agri-Fishery";
                                    farmParcelCrop.landSize = agriFisheryArea;
                                    farmParcelCrop.farmParcelNo = "1";
                                    farmParcelCrop.rsbsaId = getRsbsaId;
                                    farmParcel.Crops.Add(farmParcelCrop);
                                }

                                rsbsa.farmParcels.Add(farmParcel);

                            }

                            if (await rsbsaModel.EditRSBSARecord(rsbsa))
                            {
                                if (await rsbsaModel.EditFarmParcelAsync(rsbsa.farmParcels))
                                {
                                    // Increment the ProgressBar value and update the label
                                    progressBar1.Value++;
                                    labelProgress.Text = $"Saving: {progressBar1.Value} of {totalRows}";
                                }
                            }

                        }
                        else
                        {
                            RSBSAModel rsbsaModel = new RSBSAModel();
                            string getNextRSBSAId = rsbsaModel.GenerateRSBSAId();

                            // Farmer with the provided details does not exist in the database

                            //Farmer Info
                            rsbsa.rsbsaId = getNextRSBSAId;
                            rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            rsbsa.surname = lastNameQualifier ?? lastName;
                            rsbsa.firstname = row["FIRST \nNAME"].ToString();
                            rsbsa.middlename = row["MIDDLE \nNAME"].ToString();
                            rsbsa.extname = row["EXT. NAME"].ToString();
                            rsbsa.withGovId = !string.IsNullOrWhiteSpace(row["ID \nNUMBER"].ToString()) ? "Yes" : "No";
                            rsbsa.govIdNo = row["ID \nNUMBER"].ToString();
                            rsbsa.govIdType = row["ID NO. \nTYPE"].ToString();
                            rsbsa.contactNo = row["MOBILE NO."].ToString();
                            rsbsa.addrStreet = row["PERMANENT ADDRESS 1\n- NO., STREET"].ToString();
                            rsbsa.addrBrgy = row["PERMANENT ADDRESS 2\n- BRGY/VILL"].ToString();
                            rsbsa.addrMunicipality = row["PERMANENT \nCITY"].ToString();
                            rsbsa.addrProvince = row["PERMANENT \nPROVINCE"].ToString();
                            rsbsa.birthDate = excelDate;
                            rsbsa.birthMunicipality = row["PLACE OF \nBIRTH"].ToString();
                            rsbsa.maidenName = row["MOTHER'S \nMAIDEN NAME"].ToString();
                            rsbsa.sex = (row["GENDER"].ToString().Equals("F", StringComparison.OrdinalIgnoreCase)) ? "FEMALE" : rsbsa.sex;
                            rsbsa.sex = (row["GENDER"].ToString().Equals("M", StringComparison.OrdinalIgnoreCase)) ? "MALE" : rsbsa.sex;

                            string nonParcel;
                            int parsedValue = 0;

                            //if value is integer...
                            if (int.TryParse(row["# OF FARM PARCEL"].ToString(), out parsedValue))
                            {
                                // Parsing successful, set rsbsa.farmParcelCount to the parsed value
                                rsbsa.farmParcelCount = parsedValue;
                                rsbsa.isFarmer = "Yes";
                            }
                            else //if value is string
                            {
                                // Parsing failed, get the text and pass it to nonParcel
                                nonParcel = row["# OF FARM PARCEL"].ToString();
                                rsbsa.farmParcelCount = 0;

                                if (nonParcel.Contains("FARMWORKER", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isLaborer = "Yes";
                                    rsbsa.otherLaborWork = nonParcel;
                                }
                                else if (nonParcel.Contains("RAIS", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isFarmer = "Yes";
                                    rsbsa.hasLivestocks = nonParcel;
                                }
                                else if (nonParcel.Contains("YOUTH", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isAgriYouth = "Yes";
                                    rsbsa.otherAgriYouthAct = nonParcel;
                                }
                            }

                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.dateImported = DateTime.Now;
                            rsbsa.dateCreated = DateTime.Now;
                            rsbsa.userId = userId;

                            if (int.TryParse(row["# OF FARM PARCEL"].ToString(), out parsedValue))
                            {
                                //Initialize farmparcel
                                FarmParcel farmParcel = new FarmParcel();
                                farmParcel.farmParcelNo = "1";
                                farmParcel.rsbsaId = getNextRSBSAId;
                                farmParcel.farmLocBrgy = row["PERMANENT ADDRESS 2\n- BRGY/VILL"].ToString();
                                farmParcel.farmLocMunicipality = row["PERMANENT \nCITY"].ToString();
                                farmParcel.farmSize = row["TOTAL FARM AREA (Ha)"] != null && Double.TryParse(row["TOTAL FARM AREA (Ha)"].ToString(), out double farmArea) ? farmArea : 0.0;
                                farmParcel.Crops = new List<FarmParcelCrop>();

                                if (double.TryParse(row["RICE"].ToString(), out double riceArea))
                                {
                                    FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                    farmParcelCrop.commodityType = "Rice";
                                    farmParcelCrop.landSize = riceArea;
                                    farmParcelCrop.farmParcelNo = "1";
                                    farmParcelCrop.rsbsaId = getNextRSBSAId;
                                    farmParcel.Crops.Add(farmParcelCrop);
                                    rsbsa.isRiceFarmer = "Yes";

                                }

                                if (double.TryParse(row["CORN"].ToString(), out double cornArea))
                                {
                                    FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                    farmParcelCrop.commodityType = "Corn";
                                    farmParcelCrop.landSize = cornArea;
                                    farmParcelCrop.farmParcelNo = "1";
                                    farmParcelCrop.rsbsaId = getNextRSBSAId;
                                    farmParcel.Crops.Add(farmParcelCrop);
                                    rsbsa.isCornFarmer = "Yes";

                                }

                                if (double.TryParse(row["HVC"].ToString(), out double hvcArea))
                                {
                                    FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                    farmParcelCrop.commodityType = "HVC";
                                    farmParcelCrop.landSize = hvcArea;
                                    farmParcelCrop.farmParcelNo = "1";
                                    farmParcelCrop.rsbsaId = getNextRSBSAId;
                                    farmParcel.Crops.Add(farmParcelCrop);
                                    rsbsa.otherCrops = "HVC";

                                }

                                if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("AGRI-FISHERY"))
                                {
                                    if (double.TryParse(row["AGRI-FISHERY"].ToString(), out double agriFisheryArea))
                                    {
                                        FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                        farmParcelCrop.commodityType = "Agri-Fishery";
                                        farmParcelCrop.landSize = agriFisheryArea;
                                        farmParcelCrop.farmParcelNo = "1";
                                        farmParcelCrop.rsbsaId = getNextRSBSAId;
                                        farmParcel.Crops.Add(farmParcelCrop);
                                        rsbsa.isAquaculture = "Yes";
                                    }

                                    rsbsa.farmParcels.Add(farmParcel);

                                }
                            }

                            if (await rsbsaModel.AddNewRSBSARecordAsync(rsbsa))
                            {

                                if (await rsbsaModel.AddNewFarmParcelAsync(rsbsa.farmParcels))
                                {
                                    // Increment the ProgressBar value and update the label
                                    progressBar1.Value++;
                                    labelProgress.Text = $"Saving: {progressBar1.Value} of {totalRows}";
                                    //foreach (FarmParcel farmParcel1 in rsbsa.farmParcels)
                                    //{
                                    //    sb.AppendLine($"Farm Parcel Number: {farmParcel1.farmParcelNo}");
                                    //    sb.AppendLine($"Farm Location Brgy: {farmParcel1.farmLocBrgy}");
                                    //    sb.AppendLine($"Farm Location Municipality: {farmParcel1.farmLocMunicipality}");
                                    //    sb.AppendLine($"Farm Size: {farmParcel1.farmSize} Ha");

                                    //    // Loop through crops in the current farm parcel and append crop information
                                    //    foreach (FarmParcelCrop farmParcelCrop in farmParcel.Crops)
                                    //    {
                                    //        sb.AppendLine($"Crop Type: {farmParcelCrop.commodityType}");
                                    //        sb.AppendLine($"Land Size: {farmParcelCrop.landSize}");
                                    //        sb.AppendLine("----------------------");
                                    //    }

                                    //    sb.AppendLine("======================");
                                    //}

                                    //// Show the content in a message box
                                    //MessageBox.Show(sb.ToString(), "Farm Parcel Information");
                                }
                            }
                        }
                    }
                    else
                    {
                        //If the birthdate is null, add RSBSA REFERENCE NUMBER to the failed records list
                        failedRecords.AppendLine(row["RSBSA REFERENCE NUMBER"].ToString());

                    }
                }
            }

            if (failedRecords.Length > 0)
            {
                labelProgress.Text = $"Saving completed: {progressBar1.Value} of {totalRows}";

                // Display a warning message without the StringBuilder content
                DialogResult dialogResult = MessageBox.Show($"{progressBar1.Value} out of {totalRows} records are saved. Do you want to save the list of unsaved records in a text file?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    // Ask user to choose a location to save the file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.Title = "Save Failed RSBSA Records";

                    // Set the preset file name with dynamic content from txtSheetName and current date
                    string DateOnly = DateTime.Now.ToString("yyyyMMdd");
                    saveFileDialog.FileName = $"FailedRSBSARecords({txtSheetName.Text}) - {DateOnly}.txt";

                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        // Create the additional lines of text
                        string sheetName = $"[{txtSheetName.Text}]\n";
                        string additionalText = $"Only {progressBar1.Value} out of {totalRows} is saved.\n" +
                                                "NOTE: Try checking the birthday\n\n" +
                                                $"List of unsaved records ({totalRows - progressBar1.Value}):";
                        string divText = "----------------------------------\n";

                        // Combine additional text with failed records and save to the selected text file
                        File.WriteAllText(saveFileDialog.FileName, $"{sheetName}{additionalText}\n{divText}{failedRecords.ToString()}{divText}");
                    }
                }
            }
            else
            {
                // All rows are saved, update progress label
                labelProgress.Text = $"Saving completed: {totalRows} of {totalRows}";

                // Display a completion message
                MessageBox.Show("RSBSA Records saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task SaveRSBSARecordAndParcelsAsync(RSBSA rsbsa)
        {
            // Save RSBSA record asynchronously
            if (await rsbsaModel.AddNewRSBSARecordAsync(rsbsa))
            {
                // Save farm parcels asynchronously
                await rsbsaModel.AddNewFarmParcelAsync(rsbsa.farmParcels);
            }
        }

        private void RSBSAImportExcelView_Load(object sender, EventArgs e)
        {

        }
    }
}
