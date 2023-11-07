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
                                if (result.Tables.Count > 0)
                                {
                                    if (string.IsNullOrEmpty(txtSheetName.Text))
                                    {
                                        // Import all sheets if txtSheetName.Text is empty
                                        dgvRSBSAtoImport.DataSource = result.Tables[0]; // Display the first sheet
                                    }
                                    else if (result.Tables.Contains(txtSheetName.Text))
                                    {
                                        // Import the specified sheet if it exists
                                        dgvRSBSAtoImport.DataSource = result.Tables[txtSheetName.Text];
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Sheet '{txtSheetName.Text}' not found in the Excel file.");
                                    }
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
            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("RSBSA REFERENCE NUMBER"))
            {
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
                labelProgress.Visible = true;

                // Iterate through DataTable rows and insert into the database
                foreach (DataRow row in ((DataTable)dgvRSBSAtoImport.DataSource).Rows)
                {
                    // Check if the value in the first column starts with '02-50'
                    if (row["RSBSA REFERENCE NUMBER"] != null && row["RSBSA REFERENCE NUMBER"].ToString().StartsWith("02-50"))
                    {
                        string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy" };
                        DateTime? excelDate = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("BIRTHDATE (MM/DD/CCYY)") && DateTime.TryParseExact(row["BIRTHDATE (MM/DD/CCYY)"]?.ToString(), dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate) ? parsedDate : (DateTime?)null;

                        StringBuilder sb = new StringBuilder();
                        RSBSA rsbsa = new RSBSA();

                        if (rsbsaModel.CheckRefNoExistence(row["RSBSA REFERENCE NUMBER"].ToString()))
                        {
                            // Farmer with the provided details already exists in the database
                            //TO DO: UPDATE THE EXISTING RSBSA USING THE SAME ROWS USED IN THE 'ELSE' PART

                            RSBSAModel rsbsaModel = new RSBSAModel();
                            string getRsbsaId = rsbsaModel.GetRSBSAIDByRefNo(row["RSBSA REFERENCE NUMBER"].ToString());

                            //Farmer Info
                            rsbsa.rsbsaId = getRsbsaId;
                            rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            //rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            rsbsa.surname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("LAST NAME") ? row["LAST NAME"]?.ToString() : null;
                            rsbsa.firstname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("FIRST NAME") ? row["FIRST NAME"]?.ToString() : null;
                            rsbsa.middlename = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("MIDDLE NAME") ? row["MIDDLE NAME"]?.ToString() : null;
                            rsbsa.extname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("EXT. NAME") ? row["EXT. NAME"]?.ToString() : null;
                            rsbsa.withGovId = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NUMBER") ? !string.IsNullOrWhiteSpace(row["ID NUMBER"]?.ToString()) ? "Yes" : "No" : null;
                            rsbsa.govIdNo = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NUMBER") ? row["ID NUMBER"]?.ToString() : null;
                            rsbsa.govIdType = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NO. TYPE") ? row["ID NO. TYPE"]?.ToString() : null;
                            rsbsa.contactNo = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("MOBILE NO.") ? row["MOBILE NO."]?.ToString() : null;
                            rsbsa.addrStreet = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 1- NO., STREET") ? row["PERMANENT ADDRESS 1- NO., STREET"]?.ToString() : null;
                            rsbsa.addrBrgy = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 2- BRGY/VILL") ? row["PERMANENT ADDRESS 2- BRGY/VILL"]?.ToString() : null;
                            rsbsa.birthDate = excelDate;
                            rsbsa.addrMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT CITY") ? row["PERMANENT CITY"]?.ToString() : null;
                            rsbsa.addrProvince = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT PROVINCE") ? row["PERMANENT PROVINCE"]?.ToString() : null;
                            rsbsa.birthMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PLACE OF BIRTH") ? row["PLACE OF BIRTH"]?.ToString() : null;

                            // Handle gender property
                            string gender = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("GENDER") ? row["GENDER"]?.ToString() : null;
                            rsbsa.sex = gender != null && (gender.Equals("F", StringComparison.OrdinalIgnoreCase) || gender.Equals("M", StringComparison.OrdinalIgnoreCase)) ? gender.ToUpper() : null;

                            string nonParcel;
                            int parsedValue = 0;

                            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("# OF FARM PARCEL"))
                            {
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
                            }

                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.farmParcelCrops = new List<FarmParcelCrop>();
                            rsbsa.dateModified = DateTime.Now;
                            rsbsa.lastModifier = username;

                            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("# OF FARM PARCEL"))
                            {
                                if (int.TryParse(row["# OF FARM PARCEL"].ToString(), out parsedValue))
                                {
                                    //Initialize farmparcel
                                    FarmParcel farmParcel = new FarmParcel();
                                    farmParcel.farmParcelNo = "1";
                                    farmParcel.rsbsaId = getRsbsaId;
                                    farmParcel.farmLocBrgy = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 2- BRGY/VILL") ? row["PERMANENT ADDRESS 2- BRGY/VILL"]?.ToString() : null;
                                    farmParcel.farmLocMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT CITY") ? row["PERMANENT CITY"]?.ToString() : null;
                                    farmParcel.farmSize = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("TOTAL FARM AREA (Ha)") && Double.TryParse(row["TOTAL FARM AREA (Ha)"]?.ToString(), out double farmArea) ? farmArea : 0.0;

                                    farmParcel.Crops = new List<FarmParcelCrop>();

                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("RICE"))
                                    {
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
                                    }
                                    
                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("CORN"))
                                    {
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
                                    }
                                    
                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("CORN"))
                                    {
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
                                }
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

                            //Farmer Info
                            rsbsa.rsbsaId = getNextRSBSAId;
                            rsbsa.rsbsaIdLGU = row["RSBSA REFERENCE NUMBER"].ToString();
                            rsbsa.surname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("LAST NAME") ? row["LAST NAME"]?.ToString() : null;
                            rsbsa.firstname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("FIRST NAME") ? row["FIRST NAME"]?.ToString() : null;
                            rsbsa.middlename = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("MIDDLE NAME") ? row["MIDDLE NAME"]?.ToString() : null;
                            rsbsa.extname = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("EXT. NAME") ? row["EXT. NAME"]?.ToString() : null;
                            rsbsa.withGovId = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NUMBER") ? !string.IsNullOrWhiteSpace(row["ID NUMBER"]?.ToString()) ? "Yes" : "No" : null;
                            rsbsa.govIdNo = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NUMBER") ? row["ID NUMBER"]?.ToString() : null;
                            rsbsa.govIdType = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("ID NO. TYPE") ? row["ID NO. TYPE"]?.ToString() : null;
                            rsbsa.contactNo = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("MOBILE NO.") ? row["MOBILE NO."]?.ToString() : null;
                            rsbsa.addrStreet = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 1- NO., STREET") ? row["PERMANENT ADDRESS 1- NO., STREET"]?.ToString() : null;
                            rsbsa.addrBrgy = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 2- BRGY/VILL") ? row["PERMANENT ADDRESS 2- BRGY/VILL"]?.ToString() : null;
                            rsbsa.birthDate = excelDate;
                            rsbsa.addrMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT CITY") ? row["PERMANENT CITY"]?.ToString() : null;
                            rsbsa.addrProvince = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT PROVINCE") ? row["PERMANENT PROVINCE"]?.ToString() : null;
                            rsbsa.birthMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PLACE OF BIRTH") ? row["PLACE OF BIRTH"]?.ToString() : null;

                            // Handle gender property
                            string gender = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("GENDER") ? row["GENDER"]?.ToString() : null;
                            rsbsa.sex = gender != null && (gender.Equals("F", StringComparison.OrdinalIgnoreCase) || gender.Equals("M", StringComparison.OrdinalIgnoreCase)) ? gender.ToUpper() : null;

                            string nonParcel;
                            int parsedValue = 0;

                            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("# OF FARM PARCEL"))
                            {
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
                            }

                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.dateImported = DateTime.Now;
                            rsbsa.dateCreated = DateTime.Now;
                            rsbsa.userId = userId;


                            if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("# OF FARM PARCEL"))
                            {
                                if (int.TryParse(row["# OF FARM PARCEL"].ToString(), out parsedValue))
                                {
                                    //Initialize farmparcel
                                    FarmParcel farmParcel = new FarmParcel();
                                    farmParcel.farmParcelNo = "1";
                                    farmParcel.rsbsaId = getNextRSBSAId;
                                    farmParcel.farmLocBrgy = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT ADDRESS 2- BRGY/VILL") ? row["PERMANENT ADDRESS 2- BRGY/VILL"]?.ToString() : null;
                                    farmParcel.farmLocMunicipality = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("PERMANENT CITY") ? row["PERMANENT CITY"]?.ToString() : null;
                                    farmParcel.farmSize = ((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("TOTAL FARM AREA (Ha)") && Double.TryParse(row["TOTAL FARM AREA (Ha)"]?.ToString(), out double farmArea) ? farmArea : 0.0;

                                    farmParcel.Crops = new List<FarmParcelCrop>();

                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("RICE"))
                                    {
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
                                    }

                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("CORN"))
                                    {
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
                                    }

                                    if (((DataTable)dgvRSBSAtoImport.DataSource).Columns.Contains("CORN"))
                                    {
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
                                        }

                                        rsbsa.farmParcels.Add(farmParcel);
                                    }
                                }
                            }

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
                // All rows are saved, update progress label
                labelProgress.Text = $"Saving completed: {totalRows} of {totalRows}";

                // Display a completion message
                MessageBox.Show("RSBSA Records saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userModel.InserActionLog(username, "Import", "RSBSA", $"Excel imported successfully.");
                labelProgress.Visible = false;
                progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("There is no existing RSBSA Record in the selected file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
