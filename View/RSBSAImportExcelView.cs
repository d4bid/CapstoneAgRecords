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
            // Get the total number of rows to be saved
            int totalRows = ((DataTable)dgvRSBSAtoImport.DataSource).Rows.Count; // minus 1 for the extra row occupied by the columns in excel

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

                        if (rsbsaModel.CheckFarmerExistence(row["FIRST \nNAME"].ToString(), row["MIDDLE \nNAME"].ToString(), row["LAST NAME / QUALIFIER"].ToString(), row["EXT. NAME"].ToString(), databaseDate))
                        {
                            // Farmer with the provided details already exists in the database
                            //TO DO: UPDATE THE EXISTING RSBSA
                            progressBar1.Value++;
                        }
                        else
                        {
                            RSBSAModel rsbsaModel = new RSBSAModel();
                            string getNextRSBSAId = rsbsaModel.GenerateRSBSAId();

                            // Farmer with the provided details does not exist in the database

                            //Farmer Info
                            rsbsa.rsbsaId = getNextRSBSAId;
                            rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            rsbsa.surname = row["LAST NAME / QUALIFIER"].ToString();
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

                                if (nonParcel.Contains("FARMWORKER", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isLaborer = "Yes";
                                }
                                else if (nonParcel.Contains("RAIS", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isFarmer = "Yes";
                                }
                                else if (nonParcel.Contains("YOUTH", StringComparison.OrdinalIgnoreCase))
                                {
                                    rsbsa.isAgriYouth = "Yes";
                                }
                            }

                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.farmParcelCrops = new List<FarmParcelCrop>();
                            rsbsa.dateImported = DateTime.Now;
                            rsbsa.dateCreated = DateTime.Now;

                            //Initialize farmparcel
                            FarmParcel farmParcel = new FarmParcel();
                            farmParcel.farmParcelNo = "1";
                            farmParcel.rsbsaId = getNextRSBSAId;
                            farmParcel.farmLocBrgy = row["PERMANENT ADDRESS 2\n- BRGY/VILL"].ToString();
                            farmParcel.farmLocMunicipality = row["PERMANENT \nCITY"].ToString();
                            farmParcel.farmSize = Convert.ToDouble(row["TOTAL FARM AREA (Ha)"]);
                            farmParcel.Crops = new List<FarmParcelCrop>();

                            if (double.TryParse(row["RICE"].ToString(), out double riceArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "Rice";
                                farmParcelCrop.landSize = riceArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getNextRSBSAId;
                                farmParcel.Crops.Add(farmParcelCrop);
                            }

                            if (double.TryParse(row["CORN"].ToString(), out double cornArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "Corn";
                                farmParcelCrop.landSize = cornArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getNextRSBSAId;
                                farmParcel.Crops.Add(farmParcelCrop);
                            }

                            if (double.TryParse(row["HVC"].ToString(), out double hvcArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "HVC";
                                farmParcelCrop.landSize = hvcArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getNextRSBSAId;
                                farmParcel.Crops.Add(farmParcelCrop);
                            }

                            if (double.TryParse(row["AGRI-FISHERY"].ToString(), out double agriFisheryArea))
                            {
                                FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                                farmParcelCrop.commodityType = "Agri-Fishery";
                                farmParcelCrop.landSize = agriFisheryArea;
                                farmParcelCrop.farmParcelNo = "1";
                                farmParcelCrop.rsbsaId = getNextRSBSAId;
                                farmParcel.Crops.Add(farmParcelCrop);
                            }

                            rsbsa.farmParcels.Add(farmParcel);

                            if (await rsbsaModel.AddNewRSBSARecordAsync(rsbsa))
                            {
                                if (await rsbsaModel.AddNewFarmParcelAsync(rsbsa.farmParcels))
                                {
                                    // Increment the ProgressBar value and update the label
                                    progressBar1.Value++;
                                    labelProgress.Text = $"Saving: {progressBar1.Value} of {totalRows}";
                                }
                            }
                        }
                    }

                }
            }
            // All rows are saved, update progress label
            labelProgress.Text = $"Saving completed: {totalRows} of {totalRows}";

            // Display a completion message
            MessageBox.Show("RSBSA Records saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
