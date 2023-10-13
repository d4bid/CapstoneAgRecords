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



        public RSBSAEditView(RSBSA rsbsaInfo, RSBSA farmerInfo, RSBSA farmProfile, RSBSA farmland, RSBSA farmlandParcel, RSBSA farmlandParcelCrops, RSBSA rsbsaDocs)
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

            //to restore data
            //RSBSA Info
            labelRsbsaId.Text = rsbsaInfo.rsbsaId;
            dtDateAdm.Value = rsbsaInfo.dateCreated;

            //Farmer Info
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

            //Farm Profile
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

            if (farmland != null)
            {
                //Farmland
                labelParcelCount.Text = farmland.farmParcelCount.ToString();

                if (farmlandParcel != null)
                {
                    for (int i = 0; i < farmlandParcel.farmParcels.Count; i++)
                    {
                        //Farmland Parcel
                        //Farmland Parcel Crops
                        if (farmlandParcelCrops == null)
                        {
                            FarmLandControl farmLandControl = new FarmLandControl();
                            farmLandControl.SetData(farmlandParcel.farmParcels[i], null);
                            flowLayoutPanelParcels.Controls.Add(farmLandControl);
                        }
                        else
                        {
                            FarmLandControl farmLandControl = new FarmLandControl();
                            farmLandControl.SetData(farmlandParcel.farmParcels[i], farmlandParcelCrops.farmParcelCrops);
                            flowLayoutPanelParcels.Controls.Add(farmLandControl);
                        }
                    }
                }
            }



            //RSBSA Docs

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
        }
    }
}
