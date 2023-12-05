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
    public partial class EditBarangayModal : Form
    {
        // Form style
        private int borderSize = 2;
        public EditBarangayModal(string brgyId, string brgyType, string brgyName, string status)
        {
            InitializeComponent();

            // Set the values in your form controls
            lblBrgyId.Text = brgyId;
            lblBrgyType.Text = brgyType;
            txtBarangay.Text = brgyName;
            comboBoxStatus.Text = status;

            this.Padding = new Padding(borderSize); //Border size
            this.BackColor = Color.FromArgb(5, 93, 96); //Border color
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate barangay name
            if (string.IsNullOrWhiteSpace(txtBarangay.Text))
            {
                MessageBox.Show("Please enter a barangay name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (DatabaseConnection connection = new DatabaseConnection())
                {
                    connection.Open();

                    // Determine the table based on lblBrgyType.Text
                    string tableName;

                    switch (lblBrgyType.Text)
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
                            MessageBox.Show("Invalid barangay type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    // Construct the update query
                    string query = $"UPDATE {tableName} SET brgyName = @brgyName, status = @status WHERE brgyId = @brgyId";
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    cmd.Parameters.AddWithValue("@brgyName", txtBarangay.Text);
                    cmd.Parameters.AddWithValue("@status", comboBoxStatus.Text);
                    cmd.Parameters.AddWithValue("@brgyId", lblBrgyId.Text);

                    // Execute the update query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Barangay updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating barangay: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
