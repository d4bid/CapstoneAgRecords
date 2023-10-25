using AgRecords.Controller;
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
    public partial class HvcAddView : Form
    {
        private CropsHvcController cropsHvcController;
        public event EventHandler FormClosed;

        private Panel parentPanel;
        public event EventHandler SaveButtonClicked;

        public HvcAddView()
        {
            InitializeComponent();

            cropsHvcController = new CropsHvcController(this);
        }

        // Methods

        public void GenerateNewHvcId(string hvcSrId)
        {
            labelHvcSrId.Text = hvcSrId;
        }

        public void FormRefresh()
        {
            cropsHvcController.GenerateNewHvcID();

            int currentYear = DateTime.Now.Year;
            textboxYear.Text = currentYear.ToString();
        }

        public string GetHvcIdValue()
        {
            return labelHvcSrId.Text;
        }

        public string HvcSrIdValue
        {
            get { return labelHvcSrId.Text; }
        }

        private void HvcAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            // Get the current month
            string currentMonth = DateTime.Now.ToString("MMMM");

            // Find and set the index in the ComboBox
            int selectedIndex = cmbMonth.FindStringExact(currentMonth);

            if (selectedIndex != -1)
            {
                cmbMonth.SelectedIndex = selectedIndex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cropsHvcController.AddHvcStandingReport(labelHvcSrId.Text, cmbMonth.Text, cmbWeek.Text, textboxYear.Text))
            {
                // Trigger the event when the "Save" button is clicked
                SaveButtonClicked?.Invoke(this, EventArgs.Empty);
                this.Close(); // Close the current form (RiceAddView)
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMonth = cmbMonth.SelectedItem.ToString();

            int daysInMonth;

            // Determine the number of days in the selected month
            switch (selectedMonth)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    daysInMonth = 31;
                    break;

                case "April":
                case "June":
                case "September":
                case "November":
                    daysInMonth = 30;
                    break;

                case "February":
                    // Handle leap years
                    int year = DateTime.Now.Year;
                    bool isLeapYear = DateTime.IsLeapYear(year);
                    daysInMonth = isLeapYear ? 29 : 28;
                    break;

                default:
                    daysInMonth = 0; // Invalid month
                    break;
            }

            if (daysInMonth == 30)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-30");
            }
            else if (daysInMonth == 31)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-31");
            }
            else if (daysInMonth == 29 || daysInMonth == 28)
            {
                cmbWeek.Items.Clear();
                cmbWeek.Items.Add("1-15");
                cmbWeek.Items.Add("16-" + daysInMonth);
            }
            else
            {
                cmbWeek.Items.Clear();
            }
        }
    }
}
