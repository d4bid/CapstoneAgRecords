using AgRecords.Controller;
using AgRecords.Model;
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
    }
}
