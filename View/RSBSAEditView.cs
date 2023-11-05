using AgRecords.Controller;
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

namespace AgRecords.View
{
    public partial class RSBSAEditView : Form
    {
        public event EventHandler FormClosed;
        private RSBSAController rsbsaController;
        public static RSBSAEditView Instance;
        public Label currentRSBSAId;

        public RSBSAEditView(RSBSA rsbsaInfo, RSBSA farmerInfo, RSBSA farmProfile, RSBSA farmland, RSBSA farmlandParcel, RSBSA farmlandParcelCrops, RSBSA rsbsaDocs)
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

            Instance = this;
            currentRSBSAId = labelRsbsaId;

            pbFarmerPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            //to restore data
            //RSBSA Info
            labelRsbsaId.Text = rsbsaInfo.rsbsaId;
            txtBoxRSBSAIdLGU.Text = rsbsaInfo.rsbsaIdLGU;
            dtDateAdm.Value = rsbsaInfo.dateCreated;

            //Farmer Info
            if (farmerInfo != null)
            {
                if (farmerInfo.farmerImg != null)
                {
                    pbFarmerPhoto.Image = farmerInfo.farmerImg;
                }

                txtSurname.Text = farmerInfo.surname;
                txtFirstname.Text = farmerInfo.firstname;
                txtMiddlename.Text = farmerInfo.middlename;
                txtExtname.Text = farmerInfo.extname;
                cbSex.Text = farmerInfo.sex;

                txtAddPurok.Text = farmerInfo.addrPurok;
                txtAddStreet.Text = farmerInfo.addrStreet;
                cbAddBrgy.Text = farmerInfo.addrBrgy;
                txtAddMunicipality.Text = farmerInfo.addrMunicipality;
                txtAddProvince.Text = farmerInfo.addrProvince;
                txtAddRegion.Text = farmerInfo.addrRegion;

                //set value of radio button for highest educational attainment
                foreach (Control control in panelEduc.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        if (radioButton.Text.Equals(farmerInfo.educAttainment, StringComparison.OrdinalIgnoreCase))
                        {
                            radioButton.Checked = true;
                            break; // Exit the loop if a match is found
                        }
                    }
                }

                txtMobNo.Text = farmerInfo.contactNo;
                txtLandNo.Text = farmerInfo.landlineNo;
                rbGovIdYes.Checked = farmerInfo.withGovId.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rbGovIdNo.Checked = farmerInfo.withGovId.Equals("No", StringComparison.OrdinalIgnoreCase);
                txtGovIdType.Text = farmerInfo.govIdType;
                txtGovIdNum.Text = farmerInfo.govIdNo;

                dtpBirthDate.Value = farmerInfo.birthDate;
                txtBirthMunicipality.Text = farmerInfo.birthMunicipality;
                txtBirthProvince.Text = farmerInfo.birthProvince;
                txtBirthCountry.Text = farmerInfo.birthCountry;

                if (farmerInfo.religion.Equals("Christianity", StringComparison.OrdinalIgnoreCase))
                {
                    rbChristianity.Checked = true;
                }
                else if (farmerInfo.religion.Equals("Islam", StringComparison.OrdinalIgnoreCase))
                {
                    rbIslam.Checked = true;
                }
                else
                {
                    rbOthers.Checked = true;
                    txtReligionOthers.Text = farmerInfo.religion;
                }

                rbCivilSingle.Checked = farmerInfo.civilStatus.Equals("Single", StringComparison.OrdinalIgnoreCase);
                rbCivilMarried.Checked = farmerInfo.civilStatus.Equals("Married", StringComparison.OrdinalIgnoreCase);
                rbCivilWidowed.Checked = farmerInfo.civilStatus.Equals("Widowed", StringComparison.OrdinalIgnoreCase);
                rbSeparated.Checked = farmerInfo.civilStatus.Equals("Separated", StringComparison.OrdinalIgnoreCase);
                txtSpouseName.Text = farmerInfo.spouseName;
                txtMaidenMother.Text = farmerInfo.maidenName;

                rbHouseholdHeadYes.Checked = farmerInfo.isHouseHead.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rbHouseholdHeadNo.Checked = farmerInfo.isHouseHead.Equals("No", StringComparison.OrdinalIgnoreCase);
                txtHouseHeadName.Text = farmerInfo.houseHeadName;
                txtHouseHeadRs.Text = farmerInfo.houseHeadRs;

                nudNoLivingHouseMem.Value = Convert.ToInt32(farmerInfo.houseLivingMemCount);
                nudHouseFemale.Value = Convert.ToInt32(farmerInfo.houseFemCount);
                nudHouseNoMale.Value = Convert.ToInt32(farmerInfo.houseMaleCount);

                rbPwdYes.Checked = farmerInfo.isPWD.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rbPwdNo.Checked = farmerInfo.isPWD.Equals("No", StringComparison.OrdinalIgnoreCase);
                rb4psYes.Checked = farmerInfo.is4Ps.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rb4psNo.Checked = farmerInfo.is4Ps.Equals("No", StringComparison.OrdinalIgnoreCase);
                rbIndigenousYes.Checked = farmerInfo.isIp.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rbIndigenousNo.Checked = farmerInfo.isIp.Equals("No", StringComparison.OrdinalIgnoreCase);
                txtIndigenous.Text = farmerInfo.ipGroupName;
                rbAssociationYes.Checked = farmerInfo.isCoopMember.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                rbAssociationNo.Checked = farmerInfo.isCoopMember.Equals("No", StringComparison.OrdinalIgnoreCase);
                txtAssociation.Text = farmerInfo.coopName;
                txtEcName.Text = farmerInfo.emergContactName;
                txtEcContact.Text = farmerInfo.emergContactNo;
            }

            //Farm Profile
            if (farmProfile != null)
            {
                cbLivelihoodFarmer.Checked = farmProfile.isFarmer.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFarmActRice.Checked = farmProfile.isRiceFarmer.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFarmActCorn.Checked = farmProfile.isCornFarmer.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                if (farmProfile.otherCrops != "")
                {
                    cbOtherCrops.Checked = true;
                    txtFarmActCrops.Text = farmProfile.otherCrops;
                }

                if (farmProfile.hasLivestocks != "")
                {
                    cbLivestock.Checked = true;
                    txtFarmActLivestock.Text = farmProfile.hasLivestocks;
                }

                if (farmProfile.hasPoultry != "")
                {
                    cbPoultry.Checked = true;
                    txtFarmActPoultry.Text = farmProfile.hasPoultry;
                }

                cbLivelihoodFarmworker.Checked = farmProfile.isLaborer.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbWorkKindLandPrep.Checked = farmProfile.isPreparingLand.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbWorkKindPlanting.Checked = farmProfile.isPlanting.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbWorkKindCultivation.Checked = farmProfile.isCultivating.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbWorkKindHarvesting.Checked = farmProfile.isHarvesting.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                if (farmProfile.otherLaborWork != "")
                {
                    cbWorkKindOthers.Checked = true;
                    txtWorkKindOthers.Text = farmProfile.otherLaborWork;
                }

                cbLivelihoodFisherfolk.Checked = farmProfile.isFisherfolk.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFishingActFishCapture.Checked = farmProfile.isFishCapturing.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFishingActAquaculture.Checked = farmProfile.isAquaculture.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFishingActGleaning.Checked = farmProfile.isGleaning.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFishingActProcessing.Checked = farmProfile.isFishProcessing.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbFishingActVending.Checked = farmProfile.isFishVending.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                if (farmProfile.otherFishingAct != "")
                {
                    cbFishingActOthers.Checked = true;
                    txtFishingActOthers.Text = farmProfile.otherFishingAct;
                }

                cbLivelihoodAgriyouth.Checked = farmProfile.isAgriYouth.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbInvolvementHousehold.Checked = farmProfile.isParticipantAgriProgram.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbInvolvementFormalCourse.Checked = farmProfile.isAttendAgrifishery.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                cbInvolvementProgram.Checked = farmProfile.isParticipantAgriProgram.Equals("Yes", StringComparison.OrdinalIgnoreCase);

                if (farmProfile.otherAgriYouthAct != "")
                {
                    cbInvolvementOthers.Checked = true;
                    txtInvolvementOthers.Text = farmProfile.otherAgriYouthAct;
                }

                txtFarmingIncome.Text = farmProfile.annualIncomeFarming.ToString();
                txtNonFarmingIncome.Text = farmProfile.annualIncomeNonFarming.ToString();
            }

            if (farmland != null)
            {
                //Farmland
                labelParcelCount.Text = "0";

                if (farmlandParcel != null)
                {
                    labelParcelCount.Text = farmlandParcel.farmParcels.Count.ToString();
                    for (int i = 0; i < farmlandParcel.farmParcels.Count; i++)
                    {
                        //Farmland Parcel
                        //Farmland Parcel Crops
                        if (farmlandParcelCrops == null)
                        {
                            FarmLandControl farmLandControl = new FarmLandControl();
                            farmLandControl.SetData(farmlandParcel.farmParcels[i], null);
                            farmLandControl.RemoveButtonClick += FarmLandControl_RemoveButtonClick;
                            flowLayoutPanelParcels.Controls.Add(farmLandControl);
                        }
                        else
                        {
                            FarmLandControl farmLandControl = new FarmLandControl();
                            farmLandControl.SetData(farmlandParcel.farmParcels[i], farmlandParcelCrops.farmParcelCrops);
                            farmLandControl.RemoveButtonClick += FarmLandControl_RemoveButtonClick;
                            flowLayoutPanelParcels.Controls.Add(farmLandControl);
                        }
                    }
                }
            }

            //RSBSA Docs
            if (rsbsaDocs != null)
            {
                for (int i = 0; i < rsbsaDocs.rsbsaDocuments.Count; i++)
                {
                    RSBSADocumentControl docsControl = new RSBSADocumentControl();
                    docsControl.SetData(rsbsaDocs.rsbsaDocuments[i]);
                    docsControl.RemoveButtonClick += RSBSADocumentControl_RemoveButtonClick;
                    flowLayoutPanelDocs.Controls.Add(docsControl);
                }
            }
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

        private void RSBSAEditView_Load(object sender, EventArgs e)
        {
            FormRefresh();
            disableObjects();

            DateTime minDate = new DateTime(1900, 1, 1);
            dtpBirthDate.MaxDate = DateTime.Today;
            dtDateAdm.MaxDate = DateTime.Today;
            dtpBirthDate.MinDate = minDate;
            dtDateAdm.MinDate = minDate;
        }

        //codes from add view
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

        private async void btnSave_Click(object sender, EventArgs e)
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
            Image farmerPhoto = null;
            string rbIsHouseholdHeadText = "No";
            string rbCivilStatusText = "";
            string rbEducText = "";
            string rbGovIdText = "No";
            string rbIPGroupText = "No";
            string rbPWDText = "No";
            string rb4PsText = "No";
            string rbReligionText = "";
            string rbCooptText = "No";

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

            if (pbFarmerPhoto.Image != null)
            {
                farmerPhoto = pbFarmerPhoto.Image;
            }
            else
            {
                farmerPhoto = null;
            }


            if (await rsbsaController.EditRSBSA(
                //rsbsa info
                labelRsbsaId.Text, txtBoxRSBSAIdLGU.Text, DateTime.Now,

                //farmer info
                farmerPhoto, txtSurname.Text, txtFirstname.Text, txtMiddlename.Text, txtExtname.Text, cbSex.Text,
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

        private void pbFarmerPhoto_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbFarmerPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        private void ResetPanel(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }


        //EVENTS

        //personal info
        private void disableObjects()
        {
            //personal info
            //txtHouseHeadName.Enabled = false;
            //txtHouseHeadRs.Enabled = false;
            //txtIndigenous.Enabled = false;
            //txtAssociation.Enabled = false;
            //txtReligionOthers.Enabled = false;

            txtHouseHeadName.BackColor = Color.White;
            txtHouseHeadRs.BackColor = Color.White;
            txtIndigenous.BackColor = Color.White;
            txtAssociation.BackColor = Color.White;
            txtGovIdType.BackColor = Color.White;
            txtGovIdNum.BackColor = Color.White;
            txtReligionOthers.BackColor = Color.White;
            txtSpouseName.BackColor = Color.White;
            nudNoLivingHouseMem.BackColor = Color.White;
            txtInvolvementOthers.BackColor = Color.White;
            txtFishingActOthers.BackColor = Color.White;
            txtWorkKindOthers.BackColor = Color.White;
            txtFarmActPoultry.BackColor = Color.White;
            txtFarmActLivestock.BackColor = Color.White;
            txtFarmActCrops.BackColor = Color.White;

            //farm profile
            //panelForFarmers.Enabled = false;
            //panelForFarmerworkers.Enabled = false;
            //panelForFisherfolk.Enabled = false;
            //panelForAgriYouth.Enabled = false;

            //farm land
            //txtRotatingFarmer1.Enabled = false;
            //txtRotatingFarmer2.Enabled = false;
            //txtRotatingFarmer3.Enabled = false;
            //txtRotatingFarmer1.BackColor = Color.White;
            //txtRotatingFarmer2.BackColor = Color.White;
            //txtRotatingFarmer3.BackColor = Color.White;
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
                txtHouseHeadName.Focus();
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
                txtIndigenous.Focus();
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
                txtAssociation.Focus();
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
                txtGovIdType.Focus();
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
                txtReligionOthers.Focus();
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

        private void NumOrDecimalsOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericWithDecimal(sender, e);
        }


        private void NumOnlyLimited(object sender, KeyPressEventArgs e)
        {
            if (txtEcContact.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtEcContact, e, 10);
            }
            else if (txtMobNo.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtMobNo, e, 10);
            }
            else if (txtLandNo.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtLandNo, e, 7);
            }
            else if (txtAddRegion.Focused)
            {
                TextboxValidation.TextBox_NumericOnlyLimited(txtAddRegion, e, 2);
            }
        }

        //textchanged events
        private void AllCaps(object sender, EventArgs e)
        {
            TextboxValidation.TextBox_AllCaps(sender, e);
        }

        //other events
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
                PanelSelected.Panel_Enter(panelCivilStat, panelCivilStatsHeader);
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
            else if (focusedControl.Parent == panelMainLivelihood)
            {
                PanelSelected.Panel_Enter(panelMainLivelihood, panelMainLivelihoodHeader);
            }
            else if (focusedControl.Parent == panelForFarmers)
            {
                PanelSelected.Panel_Enter(panelForFarmers, panelForFarmersHeader);
            }
            else if (focusedControl.Parent == panelForFarmerworkers)
            {
                PanelSelected.Panel_Enter(panelForFarmerworkers, panelForFarmerworkersHeader);
            }
            else if (focusedControl.Parent == panelForFisherfolk)
            {
                PanelSelected.Panel_Enter(panelForFisherfolk, panelForFisherfolkHeader);
            }
            else if (focusedControl.Parent == panelForAgriYouth)
            {
                PanelSelected.Panel_Enter(panelForAgriYouth, panelForAgriYouthHeader);
            }
            else if (focusedControl.Parent == panelAnnuanIncome)
            {
                PanelSelected.Panel_Enter(panelAnnuanIncome, panelAnnuanIncomeHeader);
            }
            else if (focusedControl.Parent == panelFarmersInRotation)
            {
                PanelSelected.Panel_Enter(panelFarmersInRotation, panelFarmersInRotationHeader);
            }
            else if (focusedControl.Parent == panelFarmParcels)
            {
                PanelSelected.Panel_Enter(panelFarmParcels, panelFarmParcelsHeader);
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
                PanelSelected.Panel_Leave(panelCivilStat, panelCivilStatsHeader);
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
            else if (focusedControl.Parent == panelMainLivelihood)
            {
                PanelSelected.Panel_Leave(panelMainLivelihood, panelMainLivelihoodHeader);
            }
            else if (focusedControl.Parent == panelForFarmers)
            {
                PanelSelected.Panel_Leave(panelForFarmers, panelForFarmersHeader);
            }
            else if (focusedControl.Parent == panelForFarmerworkers)
            {
                PanelSelected.Panel_Leave(panelForFarmerworkers, panelForFarmerworkersHeader);
            }
            else if (focusedControl.Parent == panelForFisherfolk)
            {
                PanelSelected.Panel_Leave(panelForFisherfolk, panelForFisherfolkHeader);
            }
            else if (focusedControl.Parent == panelForAgriYouth)
            {
                PanelSelected.Panel_Leave(panelForAgriYouth, panelForAgriYouthHeader);
            }
            else if (focusedControl.Parent == panelAnnuanIncome)
            {
                PanelSelected.Panel_Leave(panelAnnuanIncome, panelAnnuanIncomeHeader);
            }
            else if (focusedControl.Parent == panelFarmersInRotation)
            {
                PanelSelected.Panel_Leave(panelFarmersInRotation, panelFarmersInRotationHeader);
            }
            else if (focusedControl.Parent == panelFarmParcels)
            {
                PanelSelected.Panel_Leave(panelFarmParcels, panelFarmParcelsHeader);
            }

            if (string.IsNullOrEmpty(txtFarmingIncome.Text))
            {
                txtFarmingIncome.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNonFarmingIncome.Text))
            {
                txtNonFarmingIncome.Text = "0";
            }
            if (focusedControl == txtReligionOthers)
            {

                if (rbOthers.Checked && string.IsNullOrEmpty(txtReligionOthers.Text))
                {
                    rbOthers.Checked = false;
                }
            }

            if (focusedControl == txtIndigenous)
            {

                if (rbIndigenousYes.Checked && string.IsNullOrEmpty(txtIndigenous.Text))
                {
                    rbIndigenousYes.Checked = false;
                }
            }
            if (focusedControl == txtAddRegion)
            {
                if (int.TryParse(txtAddRegion.Text, out int regionValue))
                {
                    if (regionValue > 12)
                    {
                        txtAddRegion.Clear();
                    }
                }
                else
                {
                    txtAddRegion.Clear();
                }
            }
            if (focusedControl == txtAddRegion)
            {
                if (int.TryParse(txtAddRegion.Text, out int regionValue))
                {
                    if (regionValue >= 1 && regionValue <= 9)
                    {
                        txtAddRegion.Text = "0" + regionValue.ToString();
                    }
                }
            }
            if (focusedControl == txtBirthMunicipality || focusedControl == txtBirthProvince)
            {
                string enteredMunicipality = txtBirthMunicipality.Text;

                if (txtBirthMunicipality.AutoCompleteCustomSource.Contains(enteredMunicipality))
                {
                    txtBirthProvince.Text = "NUEVA VIZCAYA";
                    txtBirthCountry.Text = "PHILIPPINES";
                }
            }

            if (focusedControl == txtAddMunicipality || focusedControl == txtAddProvince || focusedControl == txtAddRegion)
            {
                string enteredMunicipality = txtAddMunicipality.Text;

                if (txtBirthMunicipality.AutoCompleteCustomSource.Contains(enteredMunicipality))
                {
                    txtAddProvince.Text = "NUEVA VIZCAYA";
                    txtAddRegion.Text = "02";
                }
            }

            if (focusedControl == cbAddBrgy)
            {
                string enteredBarangay = cbAddBrgy.Text;

                if (cbAddBrgy.Items.Contains(enteredBarangay))
                {
                    txtAddMunicipality.Text = "SOLANO";
                    txtAddProvince.Text = "NUEVA VIZCAYA";
                    txtAddRegion.Text = "02";
                }
            }

            if (focusedControl == txtFarmActCrops)
            {

                if (cbOtherCrops.Checked && string.IsNullOrEmpty(txtFarmActCrops.Text))
                {
                    cbOtherCrops.Checked = false;
                }
            }
            if (focusedControl == txtFarmActLivestock)
            {

                if (cbLivestock.Checked && string.IsNullOrEmpty(txtFarmActLivestock.Text))
                {
                    cbLivestock.Checked = false;
                }
            }
            if (focusedControl == txtFarmActPoultry)
            {

                if (cbPoultry.Checked && string.IsNullOrEmpty(txtFarmActPoultry.Text))
                {
                    cbPoultry.Checked = false;
                }
            }
            if (focusedControl == txtWorkKindOthers)
            {

                if (cbWorkKindOthers.Checked && string.IsNullOrEmpty(txtWorkKindOthers.Text))
                {
                    cbWorkKindOthers.Checked = false;

                }
            }
            if (focusedControl == txtFishingActOthers)
            {

                if (cbFishingActOthers.Checked && string.IsNullOrEmpty(txtFishingActOthers.Text))
                {
                    cbFishingActOthers.Checked = false;

                }
            }
            if (focusedControl == txtInvolvementOthers)
            {

                if (cbInvolvementOthers.Checked && string.IsNullOrEmpty(txtInvolvementOthers.Text))
                {
                    cbInvolvementOthers.Checked = false;

                }
            }
        }

        private void nudHouseNoMale_ValueChanged(object sender, EventArgs e)
        {
            nudNoLivingHouseMem.Value = (nudHouseNoMale.Value + nudHouseFemale.Value);


            if (string.IsNullOrEmpty(nudHouseNoMale.Text))
            {
                nudHouseNoMale.Text = "";
                nudHouseNoMale.Value = 0;
            }
        }

        private void nudHouseFemale_ValueChanged(object sender, EventArgs e)
        {
            nudNoLivingHouseMem.Value = (nudHouseNoMale.Value + nudHouseFemale.Value);

            if (string.IsNullOrEmpty(nudHouseFemale.Text))
            {
                nudHouseFemale.Text = "";
                nudHouseFemale.Value = 0;
            }
        }


        private void isChecked(object sender, EventArgs e)
        {
            //main livelihood
            if (cbLivelihoodFarmer.Checked)
            {
                panelForFarmers.Enabled = true;
            }
            else
            {
                ResetPanel(panelForFarmers);
                panelForFarmers.Enabled = false;
            }

            if (cbLivelihoodFarmworker.Checked)
            {
                panelForFarmerworkers.Enabled = true;
            }
            else
            {
                ResetPanel(panelForFarmerworkers);
                panelForFarmerworkers.Enabled = false;
            }

            if (cbLivelihoodFisherfolk.Checked)
            {
                panelForFisherfolk.Enabled = true;
            }
            else
            {
                ResetPanel(panelForFisherfolk);
                panelForFisherfolk.Enabled = false;
            }

            if (cbLivelihoodAgriyouth.Checked)
            {
                panelForAgriYouth.Enabled = true;
            }
            else
            {
                ResetPanel(panelForAgriYouth);
                panelForAgriYouth.Enabled = false;
            }
            //activities
            if (cbOtherCrops.Checked)
            {
                txtFarmActCrops.Enabled = true;
                if (txtFarmActCrops.Text == "")
                {
                    txtFarmActCrops.Focus();
                }
            }
            else
            {
                txtFarmActCrops.Enabled = false;
                txtFarmActCrops.Clear();
            }

            if (cbLivestock.Checked)
            {
                txtFarmActLivestock.Enabled = true;
                if (txtFarmActLivestock.Text == "")
                {
                    txtFarmActLivestock.Focus();
                }
            }
            else
            {
                txtFarmActLivestock.Enabled = false;
                txtFarmActLivestock.Clear();
            }

            if (cbPoultry.Checked)
            {
                txtFarmActPoultry.Enabled = true;
                if (txtFarmActPoultry.Text == "")
                {
                    txtFarmActPoultry.Focus();
                }
            }
            else
            {
                txtFarmActPoultry.Enabled = false;
                txtFarmActPoultry.Clear();
            }

            if (cbWorkKindOthers.Checked)
            {
                txtWorkKindOthers.Enabled = true;
                if (txtWorkKindOthers.Text == "")
                {
                    txtWorkKindOthers.Focus();
                }
            }
            else
            {
                txtWorkKindOthers.Enabled = false;
                txtWorkKindOthers.Clear();
            }

            if (cbFishingActOthers.Checked)
            {
                txtFishingActOthers.Enabled = true;
                if (txtFishingActOthers.Text == "")
                {
                    txtFishingActOthers.Focus();
                }
            }
            else
            {
                txtFishingActOthers.Enabled = false;
                txtFishingActOthers.Clear();
            }

            if (cbInvolvementOthers.Checked)
            {
                txtInvolvementOthers.Enabled = true;
                if (txtInvolvementOthers.Text == "")
                {
                    txtInvolvementOthers.Focus();
                }
            }
            else
            {
                txtInvolvementOthers.Enabled = false;
                txtInvolvementOthers.Clear();
            }
        }


        private void txtFarmingIncome_Click(object sender, EventArgs e)
        {
            if (txtFarmingIncome.Text == "0")
            {
                txtFarmingIncome.Text = string.Empty;
            }
        }

        private void txtNonFarmingIncome_Click(object sender, EventArgs e)
        {
            if (txtNonFarmingIncome.Text == "0")
            {
                txtNonFarmingIncome.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit? Any unsaved changes will be lost.", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void panelAddress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
