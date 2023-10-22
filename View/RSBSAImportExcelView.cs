using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace AgRecords.View
{
    public partial class RSBSAImportExcelView : Form
    {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Iterate through DataTable rows and insert into the database
            foreach (DataRow row in ((DataTable)dgvRSBSAtoImport.DataSource).Rows)
            {

            }
        }
    }
}
