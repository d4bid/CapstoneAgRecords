﻿using AgRecords.Controller;
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
    public partial class CornAddView : Form
    {
        private CropsCornController cropsCornController;
        public event EventHandler FormClosed;

        private Panel parentPanel;
        public event EventHandler SaveButtonClicked;

        public CornAddView()
        {
            InitializeComponent();

            cropsCornController = new CropsCornController(this);
        }

        public void FormRefresh()
        {
            cmbSeason.Select();

            SetSeasonYear();

            cropsCornController.GenerateNewCornID();

            int currentYear = DateTime.Now.Year;
            textboxYear.Text = currentYear.ToString();

        }

        public string GetCornIdValue()
        {
            return labelCornPrId.Text;
        }

        public string CornPrIdValue
        {
            get { return labelCornPrId.Text; }
        }

        public void GenerateNewCornId(string cornPrId)
        {
            labelCornPrId.Text = cornPrId;
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
            cmbSeasonYear.Items.Add(pastYearItem);
            cmbSeasonYear.Items.Add(futureYearItem);

            // Optionally, you can set an initial selection
            cmbSeasonYear.SelectedIndex = 0;

            // Add the items to the cmbSeasonYear ComboBox
            cmbSeasonYearH.Items.Add(pastYearItem);
            cmbSeasonYearH.Items.Add(futureYearItem);

            // Optionally, you can set an initial selection
            cmbSeasonYearH.SelectedIndex = 0;
        }

        // Events
        private void CornAddView_Load(object sender, EventArgs e)
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
            if (cropsCornController.AddCornPlantingEcoReport(labelCornPrId.Text, cmbSeason.Text, cmbSeasonYear.Text, cmbMonth.Text, cmbWeek.Text, textboxYear.Text) &&
                cropsCornController.AddCornPlantingReport(labelCornPrId.Text, cmbSeason.Text, cmbSeasonYear.Text, cmbMonth.Text, cmbWeek.Text, textboxYear.Text) &&
                cropsCornController.AddCornHarvestingReport(labelCornPrId.Text, cmbSeasonH.Text, cmbSeasonYearH.Text, cmbMonth.Text, cmbWeek.Text, textboxYear.Text))
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
