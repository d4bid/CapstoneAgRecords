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
            btnRemove.Click += btnRemove_Click;
        }

        public void SetData(FarmParcel farmParcel, List<FarmParcelCrop> farmParcelCrop)
        {
            //parcel
            labelParcelNo.Text = farmParcel.farmParcelNo.ToString();
            txtFarmLocBarangay.Text = farmParcel.farmLocBrgy;
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

            if(farmParcelCrop != null)
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
            //SetComboBoxesSelectedIndex(this);
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

        public FarmParcel GetFarmParcelData()
        {
            rsbsaId = rsbsaController.RSBSAIdForUserControl();

            FarmParcel parcel = new FarmParcel
            {
                rsbsaId = rsbsaId,
                farmParcelNo = labelParcelNo.Text,
                farmLocBrgy = txtFarmLocBarangay.Text,
                farmLocMunicipality = txtFarmLocMunicipality.Text,
                farmSize = Convert.ToDouble(txtFarmArea.Text),
                isAncestralDomain = panelAncestralDomain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                ownershipNo = txtOwnershipDocNo.Text,
                isAgrarianBeneficiary = panelBeneficiary.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                isRegisteredOwner = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Registered Owner" ? "Yes" : "No",
                ownershipType = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                ownerName = (panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Registered Owner") ? null : txtOwnerName.Text,
                remarks = txtRemarks.Text,
                Crops = new List<FarmParcelCrop>()
            };

            if (chCropIsRice.Checked)
            {
                FarmParcelCrop riceCrop = new FarmParcelCrop
                {
                    rsbsaId = rsbsaId,
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "Rice",
                    landSize = Convert.ToDouble(txtLandSizeRice.Text),
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
                    landSize = Convert.ToDouble(txtLandSizeCorn.Text),
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
                    landSize = Convert.ToDouble(txtLandSizeHVC.Text),
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
                    landSize = Convert.ToDouble(txtLandSizeAgriFishery.Text),
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

        private void txtLivestockHeadCount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLivestockHeadCount2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLivestockHeadCount3_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbIsOrganicCorn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFarmArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
