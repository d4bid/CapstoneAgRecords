using AgRecords.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgRecords.View
{
    public partial class SettingsManageDataView : Form
    {
        private Panel parentPanel;

        public SettingsManageDataView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;

            comboBoxStatus.SelectedIndex = 0;
            comboBoxFilter.SelectedIndex = 0;
        }

        private void btnRiceBrgySave_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxFilter.Text;

            switch (selectedFilter)
            {
                case "Barangay":
                    LoadData("tbl_solano_barangays");
                    break;

                case "Rice Farm Barangay":
                    LoadData("tbl_barangay");
                    break;

                case "Corn Farm Barangay":
                    LoadData("tbl_brgy");
                    break;

                // Add more cases if needed

                default:
                    // Handle default case, if any
                    break;
            }
        }

        private void LoadData(string tableName)
        {
            try
            {
                using (DatabaseConnection connection = new DatabaseConnection())
                {
                    connection.Open();

                    // Assuming dgvBarangay is your DataGridView
                    string query = $"SELECT brgyId AS ID, brgyName AS Barangay, status AS Status FROM {tableName}";

                    // Use the MySqlConnection from your DatabaseConnection class
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBarangay.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input before proceeding
            if (!ValidateInput())
            {
                return;
            }

            // Confirm with the user before saving
            DialogResult result = MessageBox.Show("Are you sure you want to save this barangay information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SaveBarangay();

                // Clear the input fields after successful save
                txtBarangay.Clear();
                comboBoxFilter_SelectedIndexChanged(sender, e);
            }
        }

        private void SaveBarangay()
        {
            string barangayName = txtBarangay.Text;
            string status = comboBoxStatus.Text;
            string selectedFilter = comboBoxFilter.Text;

            try
            {
                using (DatabaseConnection connection = new DatabaseConnection())
                {
                    connection.Open();

                    string tableName;

                    // Determine the table based on the selected filter
                    switch (selectedFilter)
                    {
                        case "Barangay":
                            tableName = "tbl_solano_barangays";
                            break;

                        case "Rice Farm Barangay":
                            tableName = "tbl_barangay";
                            break;

                        case "Corn Farm Barangay":
                            tableName = "tbl_brgy";
                            break;

                        // Add more cases if needed

                        default:
                            MessageBox.Show("Invalid filter selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Insert the data into the specified table
                    string query = $"INSERT INTO {tableName} (brgyName, status) VALUES (@brgyName, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    cmd.Parameters.AddWithValue("@brgyName", barangayName);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Barangay saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving barangay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBarangay.Text))
            {
                MessageBox.Show("Please enter a barangay name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Add more validations if needed

            return true;
        }

        private void dgvBarangay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvBarangay.Rows[e.RowIndex];

                using (EditBarangayModal editBrgy = new EditBarangayModal(
                    selectedRow.Cells["ID"].Value.ToString(),
                    comboBoxFilter.Text,
                    selectedRow.Cells["Barangay"].Value.ToString(),
                    selectedRow.Cells["Status"].Value.ToString()))
                {
                    DialogResult result = editBrgy.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        comboBoxFilter_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }
    }
}
