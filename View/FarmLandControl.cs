using AgRecords.Controller;
using AgRecords.Model;
using AgRecords.Utilities;
using Org.BouncyCastle.Crypto.Modes;
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
    public partial class FarmLandControl : UserControl
    {
        private RSBSAController rsbsaController;
        private string rsbsaId = "";

        // Declare the event
        public event EventHandler RemoveButtonClick;

        public FarmLandControl()
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);

            // Wire up the remove button click event
            //btnRemove.Click += btnRemove_Click;
        }

        public void SetData(FarmParcel farmParcel, List<FarmParcelCrop> farmParcelCrop)
        {
            //parcel
            labelParcelNo.Text = farmParcel.farmParcelNo.ToString();
            cbFarmLocBarangay.Text = farmParcel.farmLocBrgy;
            txtFarmLocMunicipality.Text = farmParcel.farmLocMunicipality;
            txtFarmArea.Text = farmParcel.farmSize.ToString();
            txtOwnershipDocNo.Text = farmParcel.ownershipNo;

            rbAncestralDomainYes.Checked = farmParcel.isAncestralDomain.Equals("Yes", StringComparison.OrdinalIgnoreCase);
            rbAncestralDomainNo.Checked = farmParcel.isAncestralDomain.Equals("No", StringComparison.OrdinalIgnoreCase);

            rbBeneficiaryYes.Checked = farmParcel.isAgrarianBeneficiary.Equals("Yes", StringComparison.OrdinalIgnoreCase);
            rbBeneficiaryNo.Checked = farmParcel.isAgrarianBeneficiary.Equals("No", StringComparison.OrdinalIgnoreCase);

            txtRemarks.Text = farmParcel.remarks;


            if (farmParcel.isRegisteredOwner == "Yes")
            {
                rbOwnershipTypeOwner.Checked = true;
            }
            else
            {
                foreach (Control control in panelOwnershipType.Controls)
                {
                    if (control is RadioButton radioButton)
                    {
                        if (radioButton.Text.Equals(farmParcel.ownershipType, StringComparison.OrdinalIgnoreCase))
                        {
                            radioButton.Checked = true;
                            break; // Exit the loop if a match is found
                        }
                    }
                }

                txtOwnerName.Text = farmParcel.ownerName;
            }

            if (farmParcelCrop != null)
            {
                //parcel crop/commodities
                int livestockIndex = 1; //index for the first available txtLivestock TextBox

                for (int i = 0; i < farmParcelCrop.Count; i++)
                {
                    if (farmParcel.farmParcelNo == farmParcelCrop[i].farmParcelNo)
                    {
                        if (farmParcelCrop[i].commodityType == "Rice")
                        {
                            chCropIsRice.Checked = true;
                            txtLandSizeRice.Text = farmParcelCrop[i].landSize.ToString();
                            cbRiceFarmType.SelectedIndex = Convert.ToInt32(farmParcelCrop[i].farmType) - 1;
                            cbIsOrganicRice.Text = farmParcelCrop[i].isOrganic;
                        }
                        else if (farmParcelCrop[i].commodityType == "Corn")
                        {
                            chCropIsCorn.Checked = true;
                            txtLandSizeCorn.Text = farmParcelCrop[i].landSize.ToString();
                            cbCornFarmType.SelectedIndex = Convert.ToInt32(farmParcelCrop[i].farmType) - 1;
                            cbIsOrganicCorn.Text = farmParcelCrop[i].isOrganic;
                        }
                        else if (farmParcelCrop[i].commodityType == "HVC")
                        {
                            chCropIsHVC.Checked = true;
                            txtLandSizeHVC.Text = farmParcelCrop[i].landSize.ToString();
                            cbHVCFarmType.SelectedIndex = Convert.ToInt32(farmParcelCrop[i].farmType) - 1;
                            cbIsOrganicHVC.Text = farmParcelCrop[i].isOrganic;
                        }
                        else if (farmParcelCrop[i].commodityType == "Agri-Fishery")
                        {
                            chIsAgriFishery.Checked = true;
                            txtLandSizeAgriFishery.Text = farmParcelCrop[i].landSize.ToString();
                            cbAgriFisheryFarmType.SelectedIndex = Convert.ToInt32(farmParcelCrop[i].farmType) - 1;
                            cbIsOrganicAgriFishery.Text = farmParcelCrop[i].isOrganic;
                        }
                        else //if (farmParcelCrop[i].commodityType != "Agri-Fishery" || farmParcelCrop[i].commodityType != "Rice" || farmParcelCrop[i].commodityType != "Corn" || farmParcelCrop[i].commodityType != "HVC")
                        {
                            // Assign livestock type to the corresponding txtLivestock TextBox
                            Control livestockTypeTextBox = Controls.Find($"txtLivestock{livestockIndex}", true).FirstOrDefault();
                            if (livestockTypeTextBox is TextBox typeTextBox)
                            {
                                typeTextBox.Text = farmParcelCrop[i].commodityType;
                            }

                            // Assign livestock head count to the corresponding txtLivestockHeadCount TextBox
                            Control headCountTextBox = Controls.Find($"txtLivestockHeadCount{livestockIndex}", true).FirstOrDefault();
                            if (headCountTextBox is TextBox headNoTextBox)
                            {
                                headNoTextBox.Text = farmParcelCrop[i].headCount.ToString();
                            }

                            livestockIndex++;
                        }
                    }

                }

            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Raise the custom event when the remove button is clicked
            RemoveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void FarmLandControl_Load(object sender, EventArgs e)
        {
            disableObjects();
            preAnswerRB();
            cbFarmLocBarangay.Focus();
        }

        private void SetComboBoxesSelectedIndex(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (ctrl.Controls.Count > 0)
                {
                    SetComboBoxesSelectedIndex(ctrl);
                }
            }
        }

        public FarmParcel GetFarmParcelData(string rsbsaId)
        {
            double? _farmSize = double.TryParse(txtFarmArea.Text, out double farmSizeParsedValue) && farmSizeParsedValue > 0 ? farmSizeParsedValue : (double?)null;

            FarmParcel parcel = new FarmParcel
            {
                rsbsaId = rsbsaId,
                farmParcelNo = labelParcelNo.Text,
                farmLocBrgy = cbFarmLocBarangay.Text,
                farmLocMunicipality = txtFarmLocMunicipality.Text,
                farmSize = _farmSize,
                isAncestralDomain = panelAncestralDomain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                ownershipNo = txtOwnershipDocNo.Text,
                isAgrarianBeneficiary = panelBeneficiary.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                isRegisteredOwner = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Registered Owner" ? "Yes" : "No",
                ownershipType = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                ownerName = (panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Registered Owner") ? null : txtOwnerName.Text,
                remarks = txtRemarks.Text,
                Crops = new List<FarmParcelCrop>()
            };

            //if value cannot be parsed to double, return null
            double? riceLandSize = double.TryParse(txtLandSizeRice.Text, out double riceParsedValue) && riceParsedValue > 0 ? riceParsedValue : (double?)null;
            double? cornLandSize = double.TryParse(txtLandSizeCorn.Text, out double cornParsedValue) && cornParsedValue > 0 ? cornParsedValue : (double?)null;
            double? hvcLandSize = double.TryParse(txtLandSizeRice.Text, out double hvcParsedValue) && hvcParsedValue > 0 ? hvcParsedValue : (double?)null;
            double? agrifishLandSize = double.TryParse(txtLandSizeRice.Text, out double agrifishParsedValue) && agrifishParsedValue > 0 ? agrifishParsedValue : (double?)null;


            if (chCropIsRice.Checked)
            {
                FarmParcelCrop riceCrop = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "Rice",
                    landSize = riceLandSize,
                    headCount = 0, // HeadCount for crops is always 0
                    farmType = cbRiceFarmType.Text,
                    isOrganic = cbIsOrganicRice.Text
                };

                parcel.Crops.Add(riceCrop);
            }

            if (chCropIsCorn.Checked)
            {
                FarmParcelCrop cornCrop = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "Corn",
                    landSize = cornLandSize,
                    headCount = 0, // HeadCount for crops is always 0
                    farmType = cbCornFarmType.Text,
                    isOrganic = cbIsOrganicCorn.Text
                };

                parcel.Crops.Add(cornCrop);
            }

            if (chCropIsHVC.Checked)
            {
                FarmParcelCrop hvcCrop = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "HVC",
                    landSize = hvcLandSize,
                    headCount = 0, // HeadCount for crops is always 0
                    farmType = cbHVCFarmType.Text,
                    isOrganic = cbIsOrganicHVC.Text
                };

                parcel.Crops.Add(hvcCrop);
            }

            if (chIsAgriFishery.Checked)
            {
                FarmParcelCrop agriFisheryCrop = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "Agri-Fishery",
                    landSize = agrifishLandSize,
                    headCount = 0, // HeadCount for crops is always 0
                    farmType = cbAgriFisheryFarmType.Text,
                    isOrganic = cbIsOrganicAgriFishery.Text
                };

                parcel.Crops.Add(agriFisheryCrop);
            }

            //add logic for livestock/poultry
            if (!string.IsNullOrWhiteSpace(txtLivestock1.Text))
            {
                FarmParcelCrop livestock1 = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock1.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount1.Text),
                    farmType = null,
                    isOrganic = null
                };

                parcel.Crops.Add(livestock1);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock2.Text))
            {
                FarmParcelCrop livestock2 = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock2.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount2.Text),
                    farmType = null,
                    isOrganic = null
                };

                parcel.Crops.Add(livestock2);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock3.Text))
            {
                FarmParcelCrop livestock3 = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock3.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount3.Text),
                    farmType = null,
                    isOrganic = null
                };

                parcel.Crops.Add(livestock3);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock4.Text))
            {
                FarmParcelCrop livestock4 = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock4.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount4.Text),
                    farmType = null,
                    isOrganic = null
                };

                parcel.Crops.Add(livestock4);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock5.Text))
            {
                FarmParcelCrop livestock5 = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock5.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount5.Text),
                    farmType = null,
                    isOrganic = null
                };

                parcel.Crops.Add(livestock5);
            }

            return parcel;
        }

        //keypress events
        private void AlphaNum(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlpaNumeric(sender, e);
        }

        private void AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_AlphaOnly(sender, e);
            if (sender == txtLivestock1 && txtLivestock1.Text.Length >= 2)
            {
                txtLivestockHeadCount1.Enabled = true;
            }

            if (sender == txtLivestock2 && txtLivestock2.Text.Length >= 2)
            {
                txtLivestockHeadCount2.Enabled = true;
            }
            if (sender == txtLivestock3 && txtLivestock3.Text.Length >= 2)
            {
                txtLivestockHeadCount3.Enabled = true;
            }
            if (sender == txtLivestock4 && txtLivestock4.Text.Length >= 2)
            {
                txtLivestockHeadCount4.Enabled = true;
            }
            if (sender == txtLivestock5 && txtLivestock5.Text.Length >= 2)
            {
                txtLivestockHeadCount5.Enabled = true;
            }

        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            TextboxValidation.TextBox_NumericOnly(sender, e);

        }

        private void enableNextTexbox(object sender, EventArgs e)
        {
            if (sender == txtLivestockHeadCount1 && txtLivestockHeadCount1.Text.Length >= 1)
            {
                txtLivestock2.Enabled = true;
            }
            else
            {
                txtLivestock2.Enabled = false;
            }

            if (sender == txtLivestockHeadCount2 && txtLivestockHeadCount2.Text.Length >= 1)
            {
                txtLivestock3.Enabled = true;
            }

            if (sender == txtLivestockHeadCount3 && txtLivestockHeadCount2.Text.Length >= 1)
            {
                txtLivestock4.Enabled = true;
            }

            if (sender == txtLivestockHeadCount4 && txtLivestockHeadCount2.Text.Length >= 1)
            {
                txtLivestock5.Enabled = true;
            }
        }

        private void NumOrDecimalsOnly(object sender, KeyPressEventArgs e)
        {

            TextboxValidation.TextBox_NumericWithDecimal(sender, e);

        }


        private void NumOnlyLimited(object sender, KeyPressEventArgs e)
        {
            //if (txtEcContact.Focused)
            //{
            //    TextboxValidation.TextBox_NumericOnlyLimited(txtEcContact, e, 11);
            //}
            //else if (txtMobNo.Focused)
            //{
            //    TextboxValidation.TextBox_NumericOnlyLimited(txtMobNo, e, 11);
            //}
            //else if (txtLandNo.Focused)
            //{
            //    TextboxValidation.TextBox_NumericOnlyLimited(txtLandNo, e, 7);
            //}
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

            if (focusedControl.Parent == panelFarmLandDescription || focusedControl.Parent == panelOwnershipType || focusedControl.Parent == panelAncestralDomain || focusedControl.Parent == panelBeneficiary)
            {
                PanelSelected.Panel_Enter(panelFarmLandDescription, panelFarmLandDescriptionHeader);
            }
            else if (focusedControl.Parent == panelFarm || focusedControl.Parent == gbCrops || focusedControl.Parent == gbFarmType || focusedControl.Parent == gbSize || focusedControl.Parent == gbLivestock || focusedControl.Parent == gbOrganic || focusedControl == txtRemarks)
            {
                PanelSelected.Panel_Enter(panelFarm, panelFarmHeader);
            }
        }

        private void UnselectedPanel(object sender, EventArgs e)
        {
            Control focusedControl = sender as Control;

            if (focusedControl.Parent == panelFarmLandDescription || focusedControl.Parent == panelOwnershipType || focusedControl.Parent == panelAncestralDomain || focusedControl.Parent == panelBeneficiary)
            {
                PanelSelected.Panel_Leave(panelFarmLandDescription, panelFarmLandDescriptionHeader);
            }

            else if (focusedControl.Parent == panelFarm || focusedControl.Parent == gbCrops || focusedControl.Parent == gbFarmType || focusedControl.Parent == gbSize || focusedControl.Parent == gbLivestock || focusedControl.Parent == gbOrganic || focusedControl == txtRemarks)
            {
                PanelSelected.Panel_Leave(panelFarm, panelFarmHeader);
            }

            //if (string.IsNullOrEmpty(txtFarmingIncome.Text))
            //{
            //    txtFarmingIncome.Text = "0";
            //}
            //if (string.IsNullOrEmpty(txtNonFarmingIncome.Text))
            //{
            //    txtNonFarmingIncome.Text = "0";
            //}
        }
        private void disableObjects()
        {
            txtOwnerName.Enabled = false;
            txtLandSizeRice.Enabled = false;
            txtLandSizeCorn.Enabled = false;
            txtLandSizeHVC.Enabled = false;
            txtLandSizeAgriFishery.Enabled = false;
            txtLivestockHeadCount1.Enabled = false;
            txtLivestockHeadCount2.Enabled = false;
            txtLivestockHeadCount3.Enabled = false;
            txtLivestockHeadCount4.Enabled = false;
            txtLivestockHeadCount5.Enabled = false;
            cbRiceFarmType.Enabled = false;
            cbCornFarmType.Enabled = false;
            cbHVCFarmType.Enabled = false;
            cbAgriFisheryFarmType.Enabled = false;
            cbIsOrganicRice.Enabled = false;
            cbIsOrganicCorn.Enabled = false;
            cbIsOrganicHVC.Enabled = false;
            cbIsOrganicAgriFishery.Enabled = false;
            txtLivestock2.Enabled = false;
            txtLivestock3.Enabled = false;
            txtLivestock4.Enabled = false;
            txtLivestock5.Enabled = false;

            txtOwnerName.BackColor = Color.White;
            txtLandSizeRice.BackColor = Color.White;
            txtLandSizeCorn.BackColor = Color.White;
            txtLandSizeHVC.BackColor = Color.White;
            txtLivestock2.BackColor = Color.White;
            txtLivestock3.BackColor = Color.White;
            txtLivestock4.BackColor = Color.White;
            txtLivestock5.BackColor = Color.White;
            txtLandSizeAgriFishery.BackColor = Color.White;
            txtLivestockHeadCount1.BackColor = Color.White;
            txtLivestockHeadCount2.BackColor = Color.White;
            txtLivestockHeadCount3.BackColor = Color.White;
            txtLivestockHeadCount4.BackColor = Color.White;
            txtLivestockHeadCount5.BackColor = Color.White;



        }
        private void preAnswerRB()
        {
            rbAncestralDomainNo.Checked = true;
            rbBeneficiaryNo.Checked = true;
        }
        private void cbQuickAnswer_Farmland(object sender, EventArgs e)
        {
            if (sender == chCropIsRice)
            {
                if (chCropIsRice.Checked)
                {
                    cbRiceFarmType.SelectedIndex = 0;
                    cbIsOrganicRice.SelectedIndex = 1;
                    txtLandSizeRice.Enabled = true;
                    txtLandSizeRice.Focus();
                    cbRiceFarmType.Enabled = true;
                    cbIsOrganicRice.Enabled = true;
                }
                else
                {
                    cbRiceFarmType.SelectedIndex = -1;
                    cbIsOrganicRice.SelectedIndex = -1;
                    txtLandSizeRice.Clear();
                    txtLandSizeRice.Enabled = false;
                    cbRiceFarmType.Enabled = false;
                    cbIsOrganicRice.Enabled = false;
                }
            }
            if (sender == chCropIsCorn)
            {
                if (chCropIsCorn.Checked)
                {
                    cbCornFarmType.SelectedIndex = 0;
                    cbIsOrganicCorn.SelectedIndex = 1;
                    txtLandSizeCorn.Enabled = true;
                    txtLandSizeCorn.Focus();
                    cbCornFarmType.Enabled = true;
                    cbIsOrganicCorn.Enabled = true;
                }
                else
                {
                    txtLandSizeCorn.Enabled = false;
                    cbCornFarmType.Enabled = false;
                    cbIsOrganicCorn.Enabled = false;
                    cbCornFarmType.SelectedIndex = -1;
                    cbIsOrganicCorn.SelectedIndex = -1;
                    txtLandSizeCorn.Clear();
                }
            }

            if (sender == chCropIsHVC)
            {
                if (chCropIsHVC.Checked)
                {
                    cbHVCFarmType.SelectedIndex = 0;
                    cbIsOrganicHVC.SelectedIndex = 1;
                    txtLandSizeHVC.Enabled = true;
                    txtLandSizeHVC.Focus();
                    cbHVCFarmType.Enabled = true;
                    cbIsOrganicHVC.Enabled = true;
                }
                else
                {
                    txtLandSizeHVC.Enabled = false;
                    cbHVCFarmType.Enabled = false;
                    cbIsOrganicHVC.Enabled = false;
                    cbHVCFarmType.SelectedIndex = -1;
                    cbIsOrganicHVC.SelectedIndex = -1;
                    txtLandSizeHVC.Clear();

                }
            }
            if (sender == chIsAgriFishery)
            {
                if (chIsAgriFishery.Checked)
                {
                    cbAgriFisheryFarmType.SelectedIndex = 0;
                    cbIsOrganicAgriFishery.SelectedIndex = 1;
                    txtLandSizeAgriFishery.Enabled = true;
                    txtLandSizeAgriFishery.Focus();
                    cbAgriFisheryFarmType.Enabled = true;
                    cbIsOrganicAgriFishery.Enabled = true;
                }
                else
                {
                    txtLandSizeAgriFishery.Enabled = false;
                    cbAgriFisheryFarmType.Enabled = false;
                    cbIsOrganicAgriFishery.Enabled = false;
                    cbAgriFisheryFarmType.SelectedIndex = -1;
                    cbIsOrganicAgriFishery.SelectedIndex = -1;
                    txtLandSizeAgriFishery.Clear();
                }
            }
        }

        private void rbOwnershipTypeOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOwnershipTypeOwner.Checked)
            {
                txtOwnerName.Enabled = false;
                txtOwnerName.Clear();
            }
            else
            {
                txtOwnerName.Enabled = true;
                txtOwnerName.Focus();
            }
        }
    }
}

