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
                    FileStream fs = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
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
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Get the total number of rows to be saved
            int totalRows = ((DataTable)dgvRSBSAtoImport.DataSource).Rows.Count - 2; // minus 2 for the extra row occupied by the columns in excel

            // Set the ProgressBar properties
            progressBar1.Minimum = 0;
            progressBar1.Maximum = totalRows;
            progressBar1.Value = 0;

            // Iterate through DataTable rows and insert into the database
            foreach (DataRow row in ((DataTable)dgvRSBSAtoImport.DataSource).Rows)
            {
                // Check if the value in the first column starts with '02-50'
                if (row["SYSTEM_GENERATED_RSBSA_NUMBER"] != null && row["SYSTEM_GENERATED_RSBSA_NUMBER"].ToString().StartsWith("02-50"))
                {
                    string[] dateFormats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy" };
                    DateTime excelDate;

                    if (DateTime.TryParseExact(row["BIRTHDATE"].ToString(), dateFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out excelDate))
                    {
                        StringBuilder sb = new StringBuilder();
                        RSBSA rsbsa = new RSBSA();

                        // Convert the date to the database format "yyyy-MM-dd"
                        string databaseDate = excelDate.ToString("yyyy-MM-dd");

                        if (rsbsaModel.CheckFarmerExistence(row["FIRST NAME"].ToString(), row["MIDDLE NAME"].ToString(), row["LAST NAME"].ToString(), row["SUFFIX AND EXTENSION"].ToString(), databaseDate))
                        {
                            // Farmer with the provided details already exists in the database
                            //MessageBox.Show("HAAAKDUG");
                            progressBar1.Value++;
                        }
                        else
                        {
                            RSBSAModel rsbsaModel = new RSBSAModel();
                            string getNextRSBSAId = rsbsaModel.GenerateRSBSAId();

                            // Farmer with the provided details does not exist in the database
                            rsbsa.rsbsaId = getNextRSBSAId;
                            rsbsa.rsbsaIdRegion = row["SYSTEM_GENERATED_RSBSA_NUMBER"].ToString();
                            rsbsa.surname = row["LAST NAME"].ToString();
                            rsbsa.firstname = row["FIRST NAME"].ToString();
                            rsbsa.middlename = row["MIDDLE NAME"].ToString();
                            rsbsa.extname = row["SUFFIX AND EXTENSION"].ToString();
                            rsbsa.sex = row["SEX"].ToString();
                            rsbsa.addrPurok = row["FARMER ADDRESS 1"].ToString();
                            rsbsa.addrMunicipality = row["FARMER ADDRESS 2"].ToString();
                            rsbsa.addrProvince = row["FARMER ADDRESS 3"].ToString();
                            rsbsa.birthDate = excelDate;
                            rsbsa.contactNo = row["CONTACT NO"].ToString();
                            rsbsa.is4Ps = row["4Ps"].ToString();
                            rsbsa.isIp = row["Indegenous"].ToString();
                            rsbsa.isPWD = row["PWD"].ToString();
                            rsbsa.farmParcelCount = 1;
                            rsbsa.farmParcels = new List<FarmParcel>();
                            rsbsa.farmParcelCrops = new List<FarmParcelCrop>();
                            rsbsa.dateCreated = DateTime.Now;

                            FarmParcel farmParcel = new FarmParcel();
                            farmParcel.farmParcelNo = "1";
                            farmParcel.rsbsaId = getNextRSBSAId;
                            farmParcel.farmLocBrgy = row["FARM ADDRESS 1"].ToString();
                            farmParcel.farmLocMunicipality = row["FARM ADDRESS 2"].ToString();
                            farmParcel.farmSize = Convert.ToDouble(row["FARM AREA"]);
                            farmParcel.Crops = new List<FarmParcelCrop>();


                            FarmParcelCrop farmParcelCrop = new FarmParcelCrop();
                            if (row["COMMODITY"].ToString().IndexOf("palay", StringComparison.OrdinalIgnoreCase) >= 0 || row["COMMODITY"].ToString().IndexOf("rice", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                farmParcelCrop.commodityType = "Rice";
                            }
                            else if (row["COMMODITY"].ToString().IndexOf("corn", StringComparison.OrdinalIgnoreCase) >= 0 || row["COMMODITY"].ToString().IndexOf("mais", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                farmParcelCrop.commodityType = "Corn";
                            }
                            else if (row["COMMODITY"].ToString().IndexOf("HVC", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                farmParcelCrop.commodityType = "HVC";
                            }
                            else if (row["COMMODITY"].ToString().IndexOf("fish", StringComparison.OrdinalIgnoreCase) >= 0 || row["COMMODITY"].ToString().IndexOf("agri-fishery", StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                farmParcelCrop.commodityType = "Agri-Fishery";
                            }

                            farmParcelCrop.landSize = Convert.ToDouble(row["FARM AREA"]);
                            farmParcelCrop.farmParcelNo = "1";
                            farmParcelCrop.rsbsaId = getNextRSBSAId;

                            farmParcel.Crops.Add(farmParcelCrop);

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
