﻿using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace AgRecords.View
{
    public partial class RsbsaAddView : Form
    {
        private RSBSAController rsbsaController;
        public event EventHandler FormClosed;

        public static RsbsaAddView Instance;
        public Label rsbsaId;

        public RsbsaAddView()
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

            Instance = this;
            rsbsaId = labelRsbsaId;
        }

        // Method
        public void FormRefresh()
        {
            panelColorPi.Visible = true;
            panelColorFp.Visible = false;
            panelColorFl.Visible = false;
            panelColorDoc.Visible = false;

            panelPersonalInfo.Visible = true;
            panelFarmProfile.Visible = false;
            panelFarmLand.Visible = false;

            rsbsaController.GenerateNewRSBSAId();

        }

        public void GenerateNewRSBSAId(string rsbsaId)
        {
            labelRsbsaId.Text = rsbsaId;
        }

        private List<FarmParcel> GetFarmParcelsFromControls()
        {
            List<FarmParcel> farmParcels = new List<FarmParcel>();

            foreach (FarmLandControl farmLandControl in flowLayoutPanelParcels.Controls.OfType<FarmLandControl>())
            {
                FarmParcel parcel = farmLandControl.GetFarmParcelData(labelRsbsaId.Text);
                farmParcels.Add(parcel);
            }

            return farmParcels;
        }

        private List<RSBSADocuments> GetDocumentsFromControls()
        {
            List<RSBSADocuments> documentsList = new List<RSBSADocuments>();

            foreach (RSBSADocumentControl documentControl in flowLayoutPanelDocs.Controls.OfType<RSBSADocumentControl>())
            {
                RSBSADocuments document = documentControl.GetDocumentData(labelRsbsaId.Text);
                documentsList.Add(document);
            }

            return documentsList;
        }

        // Buttons/Tab

        private void btnSave_Click(object sender, EventArgs e)
        {
            //radio buttons in personal info
            RadioButton rbIsHouseholdHead = panelHousehold.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbCivilStatus = panelCivilStat.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbEduc = panelEduc.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbGovId = panelGovId.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbIPGroup = panelIPGroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbPWD = panelPWD.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rb4Ps = panel4Ps.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbReligion = panelReligion.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            RadioButton rbCoop = panelCoop.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            //farmer info
            string rbIsHouseholdHeadText = "";
            string rbCivilStatusText = "";
            string rbEducText = "";
            string rbGovIdText = "";
            string rbIPGroupText = "";
            string rbPWDText = "";
            string rb4PsText = "";
            string rbReligionText = "";
            string rbCooptText = "";

            //farm profile
            string isFarmerText = "No";
            string isRiceFarmerText = "No";
            string isCornFarmerText = "No";
            string isLaborerText = "No";
            string isPreparingLandText = "No";
            string isPlantingText = "No";
            string isCultivatingText = "No";
            string isHarvestingText = "No";
            string isFisherfolkText = "No";
            string isFishCapturingText = "No";
            string isAquacultureText = "No";
            string isGleaningText = "No";
            string isFishProcessingText = "No";
            string isFishVendingText = "No";
            string isAgriYouthText = "No";
            string isPartOfFarmingHouseholdText = "No";
            string isAttendAgrifisheryText = "No";
            string isParticipantAgriProgramText = "No";

            //farm info
            if (rbIsHouseholdHead != null)
            {
                rbIsHouseholdHeadText = rbIsHouseholdHead.Text;
            }

            if (rbCivilStatus != null)
            {
                rbCivilStatusText = rbCivilStatus.Text;
            }

            if (rbEduc != null)
            {
                rbEducText = rbEduc.Text;
            }

            if (rbGovId != null)
            {
                rbGovIdText = rbGovId.Text;
            }

            if (rbIPGroup != null)
            {
                rbIPGroupText = rbIPGroup.Text;
            }

            if (rbPWD != null)
            {
                rbPWDText = rbPWD.Text;
            }

            if (rb4Ps != null)
            {
                rb4PsText = rb4Ps.Text;
            }

            if (rbReligion != null)
            {
                if (rbReligion.Text == "Others")
                {
                    rbReligionText = txtReligionOthers.Text;
                }
                else
                {
                    rbReligionText = rbReligion.Text;
                }
            }

            if (rbCoop != null)
            {
                rbCooptText = rbCoop.Text;
            }

            //farm profile
            if (cbLivelihoodFarmer.Checked)
            {
                isFarmerText = "Yes";
            }

            if (cbFarmActRice.Checked)
            {
                isRiceFarmerText = "Yes";
            }

            if (cbFarmActCorn.Checked)
            {
                isCornFarmerText = "Yes";
            }

            if (cbLivelihoodFarmworker.Checked)
            {
                isLaborerText = "Yes";
            }

            if (cbWorkKindLandPrep.Checked)
            {
                isPreparingLandText = "Yes";
            }

            if (cbWorkKindPlanting.Checked)
            {
                isPlantingText = "Yes";
            }

            if (cbWorkKindCultivation.Checked)
            {
                isCultivatingText = "Yes";
            }

            if (cbWorkKindHarvesting.Checked)
            {
                isHarvestingText = "Yes";
            }

            if (cbLivelihoodFisherfolk.Checked)
            {
                isFisherfolkText = "Yes";
            }

            if (cbFishingActFishCapture.Checked)
            {
                isFishCapturingText = "Yes";
            }

            if (cbFishingActAquaculture.Checked)
            {
                isAquacultureText = "Yes";
            }

            if (cbFishingActGleaning.Checked)
            {
                isGleaningText = "Yes";
            }

            if (cbFishingActProcessing.Checked)
            {
                isFishProcessingText = "Yes";
            }

            if (cbFishingActVending.Checked)
            {
                isFishVendingText = "Yes";
            }

            if (cbLivelihoodAgriyouth.Checked)
            {
                isAgriYouthText = "Yes";
            }

            if (cbInvolvementHousehold.Checked)
            {
                isPartOfFarmingHouseholdText = "Yes";
            }

            if (cbInvolvementFormalCourse.Checked)
            {
                isAttendAgrifisheryText = "Yes";
            }

            if (cbInvolvementProgram.Checked)
            {
                isParticipantAgriProgramText = "Yes";
            }


            if (rsbsaController.AddRSBSA(
                //rsbsa info
                labelRsbsaId.Text, null, null, dtDateAdm.Value.Date,

                //farmer info
                txtSurname.Text, txtFirstname.Text, txtMiddlename.Text, txtExtname.Text, cbSex.Text,
                txtAddPurok.Text, txtAddStreet.Text, cbAddBrgy.Text, txtAddMunicipality.Text, txtAddProvince.Text, txtAddRegion.Text,
                rbEducText, txtMobNo.Text, txtLandNo.Text, rbGovIdText, txtGovIdType.Text, txtGovIdNum.Text,
                dtpBirthDate.Value.Date, txtBirthMunicipality.Text, txtBirthProvince.Text, txtBirthCountry.Text,
                rbReligionText, rbCivilStatusText, txtSpouseName.Text, txtMaidenMother.Text,
                rbIsHouseholdHeadText, txtHouseHeadName.Text, txtHouseHeadRs.Text,
                Convert.ToInt32(nudNoLivingHouseMem.Value), Convert.ToInt32(nudHouseFemale.Value), Convert.ToInt32(nudHouseNoMale.Value),
                rbPWDText, rb4PsText, rbIPGroupText, txtIndigenous.Text, rbCooptText, txtAssociation.Text, txtEcName.Text, txtEcContact.Text,

                //farm profile
                isFarmerText, isRiceFarmerText, isCornFarmerText, txtFarmActCrops.Text, txtFarmActLivestock.Text, txtFarmActPoultry.Text,
                isLaborerText, isPreparingLandText, isPlantingText, isCultivatingText, isHarvestingText, txtWorkKindOthers.Text,
                isFisherfolkText, isFishCapturingText, isAquacultureText, isGleaningText, isFishProcessingText, isFishVendingText, txtFishingActOthers.Text,
                isAgriYouthText, isPartOfFarmingHouseholdText, isAttendAgrifisheryText, isParticipantAgriProgramText, txtInvolvementOthers.Text,
                Convert.ToDouble(txtFarmingIncome.Text), Convert.ToDouble(txtNonFarmingIncome.Text),

                //farmland
                "Test", Convert.ToInt32(labelParcelCount.Text),

                //farmland parcel
                GetFarmParcelsFromControls(),

                //Docs
                GetDocumentsFromControls()

                ))
            {
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);

            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelColorPi.Visible = true;
            panelColorFp.Visible = false;
            panelColorFl.Visible = false;
            panelColorDoc.Visible = false;

            panelPersonalInfo.Visible = true;
            panelFarmProfile.Visible = false;
            panelFarmLand.Visible = false;
            panelDocument.Visible = false;
        }

        private void btnFarmProfile_Click(object sender, EventArgs e)
        {
            panelColorPi.Visible = false;
            panelColorFp.Visible = true;
            panelColorFl.Visible = false;
            panelColorDoc.Visible = false;

            panelPersonalInfo.Visible = true;
            panelFarmProfile.Visible = true;
            panelFarmLand.Visible = false;
            panelDocument.Visible = false;

            cbLivelihoodFarmer.Focus();
        }

        private void btnFarmLand_Click(object sender, EventArgs e)
        {
            panelColorPi.Visible = false;
            panelColorFp.Visible = false;
            panelColorFl.Visible = true;
            panelColorDoc.Visible = false;

            panelPersonalInfo.Visible = true;
            panelFarmProfile.Visible = true;
            panelFarmLand.Visible = true;
            panelDocument.Visible = false;
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            panelColorPi.Visible = false;
            panelColorFp.Visible = false;
            panelColorFl.Visible = false;
            panelColorDoc.Visible = true;

            panelPersonalInfo.Visible = true;
            panelFarmProfile.Visible = true;
            panelFarmLand.Visible = true;
            panelDocument.Visible = true;
        }

        // End of Buttons/Tab

        private void RsbsaAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();

            //radiobuttonsPreAnswer_PersonalInfo();
            comboboxesPreAnswer_PersonalInfo();
            disabletxtboxes_PersonalInfo();

            DateTime minDate = new DateTime(1900, 1, 1);
            dtpBirthDate.MaxDate = DateTime.Today;
            dtDateAdm.MaxDate = DateTime.Today;
            dtpBirthDate.MinDate = minDate;
            dtDateAdm.MinDate = minDate;
            txtSurname.Focus();
        }

        private void rectangleRound42_Load(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void nudFarmParcelNo_ValueChanged(object sender, EventArgs e)
        //{

        //    flowLayoutPanelParcels.Controls.Clear();

        //    for (int i = 0; i < numberOfControls; i++)
        //    {
        //        // Create an instance of your custom UserControl
        //        FarmLandControl farmLandControl = new FarmLandControl();

        //        // Set properties of the UserControl as needed
        //        farmLandControl.labelParcelNo.Text = (i + 1).ToString();

        //        // Add the UserControl to the parent control (e.g., Panel)
        //        flowLayoutPanelParcels.Controls.Add(farmLandControl);
        //    }
        //}

        private void btnAddFarmParcel_Click(object sender, EventArgs e)
        {
            FarmLandControl farmLandControl = new FarmLandControl();

            // Set the labelParcelNo.Text based on the current count
            farmLandControl.labelParcelNo.Text = (flowLayoutPanelParcels.Controls.Count + 1).ToString();

            flowLayoutPanelParcels.Controls.Add(farmLandControl);

            // Handle the remove button click event
            farmLandControl.RemoveButtonClick += FarmLandControl_RemoveButtonClick;

            // Update the parcel count label
            UpdateParcelCountLabel();
        }

        private void UpdateParcelCountLabel()
        {
            labelParcelCount.Text = $"{flowLayoutPanelParcels.Controls.Count}";
        }

        private void FarmLandControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (sender is FarmLandControl farmLandControl)
            {
                // Get the index of the control being removed
                int removedIndex = flowLayoutPanelParcels.Controls.IndexOf(farmLandControl);

                // Check if the control was found in the Controls collection
                if (removedIndex >= 0 && removedIndex < flowLayoutPanelParcels.Controls.Count)
                {
                    // Remove the farmLandControl from the flowLayoutPanelParcels
                    flowLayoutPanelParcels.Controls.Remove(farmLandControl);

                    // Update the parcel numbers for the remaining controls
                    for (int i = removedIndex; i < flowLayoutPanelParcels.Controls.Count; i++)
                    {
                        FarmLandControl remainingControl = (FarmLandControl)flowLayoutPanelParcels.Controls[i];
                        remainingControl.labelParcelNo.Text = (i + 1).ToString();
                    }
                }

                // Update the parcel count label
                UpdateParcelCountLabel();
            }
        }

        private void txtAssociation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplayListCon_Click(object sender, EventArgs e)
        {
            DisplayFarmParcelsDataInTextBox(GetFarmParcelsFromControls());
        }

        private void DisplayFarmParcelsDataInTextBox(List<FarmParcel> farmParcels)
        {
            StringBuilder sb = new StringBuilder();

            foreach (FarmParcel parcel in farmParcels)
            {
                sb.AppendLine($"RSBSA No: {parcel.rsbsaId}");
                sb.AppendLine($"Farm Parcel No: {parcel.farmParcelNo}");
                sb.AppendLine($"Farm Location Brgy: {parcel.farmLocBrgy}");
                sb.AppendLine($"Farm Location Municipality: {parcel.farmLocMunicipality}");
                sb.AppendLine($"Is Ancestral Domain: {parcel.isAncestralDomain}");
                sb.AppendLine($"Ownership No: {parcel.ownershipNo}");
                sb.AppendLine($"Is Agrarian Beneficiary: {parcel.isAgrarianBeneficiary}");
                sb.AppendLine($"Is Registered Owner: {parcel.isRegisteredOwner}");
                sb.AppendLine($"Ownership Type: {parcel.ownershipType}");
                sb.AppendLine($"Owner Name: {parcel.ownerName}");
                sb.AppendLine($"Remarks: {parcel.remarks}");
                sb.AppendLine();

                foreach (FarmParcelCrop crop in parcel.Crops)
                {
                    sb.AppendLine($"RSBSA No: {crop.rsbsaId}");
                    sb.AppendLine($"Farm Parcel No: {crop.farmParcelNo}");
                    sb.AppendLine($"Commodity Type: {crop.commodityType}");
                    sb.AppendLine($"Land Size: {crop.landSize}");
                    sb.AppendLine($"Head Count: {crop.headCount}");
                    sb.AppendLine($"Farm Type: {crop.farmType}");
                    sb.AppendLine($"Is Organic: {crop.isOrganic}");
                    sb.AppendLine();
                }

                sb.AppendLine(); // Add a newline to separate farm parcels
            }

            // Assuming textBoxFarmParcels is the TextBox control where you want to display the data
            textBoxFarmParcels.Text = sb.ToString();
        }

        //EVENTS

        //personal info
        private void disabletxtboxes_PersonalInfo()
        {
            txtHouseHeadName.Enabled = false;
            txtHouseHeadRs.Enabled = false;
            txtIndigenous.Enabled = false;
            txtAssociation.Enabled = false;
            txtGovIdType.Enabled = false;
            txtGovIdNum.Enabled = false;
            txtReligionOthers.Enabled = false;

            txtHouseHeadName.BackColor = Color.White;
            txtHouseHeadRs.BackColor = Color.White;
            txtIndigenous.BackColor = Color.White;
            txtAssociation.BackColor = Color.White;
            txtGovIdType.BackColor = Color.White;
            txtGovIdNum.BackColor = Color.White;
            txtReligionOthers.BackColor = Color.White;
            txtSpouseName.BackColor = Color.White;

        }
        private void radiobuttonsPreAnswer_PersonalInfo()
        {
            rbGovIdYes.Checked = true;
            rb4psYes.Checked = true;
            rbHouseholdHeadYes.Checked = true;

            rbPwdNo.Checked = true;
            rbAssociationNo.Checked = true;
            rbIndigenousNo.Checked = true;

            rbChristianity.Checked = true;
            rbCivilMarried.Checked = true;
        }

        private void comboboxesPreAnswer_PersonalInfo()
        {
            cbSex.SelectedIndex = 0;
        }

        private void rbHouseholdHeadNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHouseholdHeadNo.Checked)
            {
                txtHouseHeadName.Enabled = true;
                txtHouseHeadRs.Enabled = true;
            }
            else
            {
                txtHouseHeadName.Enabled = false;
                txtHouseHeadRs.Enabled = false;
                txtHouseHeadName.Clear();
                txtHouseHeadRs.Clear();
            }
        }

        private void rbIndigenousYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIndigenousYes.Checked)
            {
                txtIndigenous.Enabled = true;
            }
            else
            {
                txtIndigenous.Enabled = false;
                txtIndigenous.Clear();
            }

        }

        private void rbAssociationYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAssociationYes.Checked)
            {
                txtAssociation.Enabled = true;
            }
            else
            {
                txtAssociation.Enabled = false;
                txtAssociation.Clear();
            }
        }

        private void rbGovIdYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGovIdYes.Checked)
            {
                txtGovIdType.Enabled = true;
                txtGovIdNum.Enabled = true;
            }
            else
            {
                txtGovIdType.Enabled = false;
                txtGovIdNum.Enabled = false;
                txtGovIdType.Clear();
                txtGovIdNum.Clear();
            }
        }

        private void rbOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOthers.Checked)
            {
                txtReligionOthers.Enabled = true;
            }
            else
            {
                txtReligionOthers.Enabled = false;
                txtReligionOthers.Clear();
            }
        }
        private void rbCivilSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCivilSingle.Checked)
            {
                txtSpouseName.Enabled = false;
                txtSpouseName.Clear();
            }
            else
            {
                txtSpouseName.Enabled = true;
            }
        }
        private void btnAddDocsControl_Click(object sender, EventArgs e)
        {
            RSBSADocumentControl documentControl = new RSBSADocumentControl();

            // Subscribe to the RemoveButtonClick event
            documentControl.RemoveButtonClick += RSBSADocumentControl_RemoveButtonClick;

            // Add the documentControl to the flowLayoutPanelDocs
            flowLayoutPanelDocs.Controls.Add(documentControl);
        }

        private void RSBSADocumentControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (sender is RSBSADocumentControl documentControl)
            {
                // Remove the documentControl from the flowLayoutPanelDocs
                flowLayoutPanelDocs.Controls.Remove(documentControl);
            }
        }
        //keypress events
        private void AlphaNum(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlpaNumeric(sender, e);
        }

        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlphaOnly(sender, e);
        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericOnly(sender, e);
        }

        private void NumOnlyLimited(object sender, KeyPressEventArgs e)
        {
            if (txtEcContact.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtEcContact, e, 11);
            }
            else if (txtMobNo.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtMobNo, e, 11);
            }
            else if (txtLandNo.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtLandNo, e, 7);
            }
        }

        //textchanged events
        private void AllCaps(object sender, EventArgs e)
        {
            TextboxValidation.TextBox_AllCaps(sender, e);
        }

        private void SelectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelPersonalDetails)
            {
                PanelSelected.Panel_Enter(panelPersonalDetails, panelPersonalDetailsHeader);
            }
            else if (focusedControl.Parent == panelAddress)
            {
                PanelSelected.Panel_Enter(panelAddress, panelAddressHeader);
            }
            else if (focusedControl.Parent == panelContactDetails)
            {
                PanelSelected.Panel_Enter(panelContactDetails, panelContactDetailsHeader);
            }
            else if (focusedControl.Parent == panelBirthDetails)
            {
                PanelSelected.Panel_Enter(panelBirthDetails, panelBirthDetailsHeader);
            }
            else if (focusedControl.Parent == panelReligion)
            {
                PanelSelected.Panel_Enter(panelReligion, panelReligionHeader);
            }
            else if (focusedControl.Parent == panelCivilStat)
            {
                PanelSelected.Panel_Enter(panelCivilStat, panelCivStasHeader);
            }
            else if (focusedControl.Parent == panelHousehold)
            {
                PanelSelected.Panel_Enter(panelHousehold, panelHouseholdHeader);
            }
            else if (focusedControl.Parent == panelEduc)
            {
                PanelSelected.Panel_Enter(panelEduc, panelEducHeader);
            }
            else if (focusedControl.Parent == panelAffiliations || focusedControl.Parent == panelPWD || focusedControl.Parent == panel4Ps || focusedControl.Parent == panelIPGroup || focusedControl.Parent == panelGovId || focusedControl.Parent == panelCoop)
            {
                PanelSelected.Panel_Enter(panelAffiliations, panelAffiliationsHeader);
            }
            else if (focusedControl.Parent == panelEmergencyCon)
            {
                PanelSelected.Panel_Enter(panelEmergencyCon, panelEmergencyConHeader);
            }
            else if (focusedControl.Parent == panelMaidenName)
            {
                PanelSelected.Panel_Enter(panelMaidenName, panelMaidenNameHeader);
            }
        }

        private void UnselectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelPersonalDetails)
            {
                PanelSelected.Panel_Leave(panelPersonalDetails, panelPersonalDetailsHeader);
            }
            else if (focusedControl.Parent == panelAddress)
            {
                PanelSelected.Panel_Leave(panelAddress, panelAddressHeader);
            }
            else if (focusedControl.Parent == panelContactDetails)
            {
                PanelSelected.Panel_Leave(panelContactDetails, panelContactDetailsHeader);
            }
            else if (focusedControl.Parent == panelBirthDetails)
            {
                PanelSelected.Panel_Leave(panelBirthDetails, panelBirthDetailsHeader);
            }
            else if (focusedControl.Parent == panelReligion)
            {
                PanelSelected.Panel_Leave(panelReligion, panelReligionHeader);
            }
            else if (focusedControl.Parent == panelCivilStat)
            {
                PanelSelected.Panel_Leave(panelCivilStat, panelCivStasHeader);
            }
            else if (focusedControl.Parent == panelHousehold)
            {
                PanelSelected.Panel_Leave(panelHousehold, panelHouseholdHeader);
            }
            else if (focusedControl.Parent == panelEduc)
            {
                PanelSelected.Panel_Leave(panelEduc, panelEducHeader);
            }
            else if (focusedControl.Parent == panelAffiliations || focusedControl.Parent == panelPWD || focusedControl.Parent == panel4Ps || focusedControl.Parent == panelIPGroup || focusedControl.Parent == panelGovId || focusedControl.Parent == panelCoop)
            {
                PanelSelected.Panel_Leave(panelAffiliations, panelAffiliationsHeader);
            }
            else if (focusedControl.Parent == panelEmergencyCon)
            {
                PanelSelected.Panel_Leave(panelEmergencyCon, panelEmergencyConHeader);
            }
            else if (focusedControl.Parent == panelMaidenName)
            {
                PanelSelected.Panel_Leave(panelMaidenName, panelMaidenNameHeader);
            }
        }
    }
}
