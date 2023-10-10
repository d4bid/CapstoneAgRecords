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
    public partial class RiceAddView : Form
    {
        private Panel parentPanel;

        public RiceAddView()
        {
            InitializeComponent();
        }

        // Methods
        private void CropsRiceAddView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        public void FormRefresh()
        {
            cmbSeason.Select();

            SetSeasonYear();

            int currentYear = DateTime.Now.Year;
            txtYear.Text = currentYear.ToString();

        }

        public void SetSeasonYear()
        {
            int currentYear = DateTime.Now.Year;

            // Calculate the past and future years
            int pastYear = currentYear - 1;
            int futureYear = currentYear + 1;

            // Create the items in the format "YYYY-YYYY"
            string pastYearItem = $"{pastYear}-{currentYear}";
            string futureYearItem = $"{currentYear}-{futureYear}";

            // Add the items to the cmbSeasonYear ComboBox
            cmbSeasonYear.Items.Add(futureYearItem);
            cmbSeasonYear.Items.Add(pastYearItem);

            // Optionally, you can set an initial selection
            cmbSeasonYear.SelectedIndex = 0;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            CropsRiceAddView cropsRiceAddView = new CropsRiceAddView();
            cropsRiceAddView.FormClosed += CropsRiceAddView_FormClosed;

            cropsRiceAddView.TopLevel = false;
            cropsRiceAddView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceAddView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceAddView);
            cropsRiceAddView.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RiceAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        // Events
    }
}
