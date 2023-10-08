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
        RsbsaAddView rsbsaAddView;
        public FarmLandControl()
        {
            InitializeComponent();
        }

        private void FarmLandControl_Load(object sender, EventArgs e)
        {
            SetComboBoxesSelectedIndex(this);
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
            FarmParcel parcel = new FarmParcel
            {
                farmParcelNo = labelParcelNo.Text,
                farmLocBrgy = txtFarmLocBarangay.Text,
                farmLocMunicipality = txtFarmLocMunicipality.Text,
                farmSize = Convert.ToDouble(txtFarmArea.Text),
                isAncestralDomain = panelAncestralDomain.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                ownershipNo = txtOwnershipDocNo.Text,
                isAgrarianBeneficiary = panelBeneficiary.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                isRegisteredOwner = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text == "Yes" ? "Yes" : "No",
                ownershipType = panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
                ownerName = (panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text != "owner") ? txtOwnerName.Text : null,
                remarks = (panelOwnershipType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text != "owner") ? txtRemarks.Text : null,
                Crops = new List<FarmParcelCrop>()
            };

            if (chCropIsRice.Checked)
            {
                FarmParcelCrop riceCrop = new FarmParcelCrop
                {
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
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = "AgriFishery",
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
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock1.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount1.Text),
                    farmType = cbLivestockFarmType1.Text,
                    isOrganic = cbLivestockIsOrganic1.Text
                };

                parcel.Crops.Add(livestock1);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock2.Text))
            {
                FarmParcelCrop livestock2 = new FarmParcelCrop
                {
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock2.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount2.Text),
                    farmType = cbLivestockFarmType2.Text,
                    isOrganic = cbLivestockIsOrganic2.Text
                };

                parcel.Crops.Add(livestock2);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock3.Text))
            {
                FarmParcelCrop livestock3 = new FarmParcelCrop
                {
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock3.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount3.Text),
                    farmType = cbLivestockFarmType3.Text,
                    isOrganic = cbLivestockIsOrganic3.Text
                };

                parcel.Crops.Add(livestock3);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock4.Text))
            {
                FarmParcelCrop livestock4 = new FarmParcelCrop
                {
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock4.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount4.Text),
                    farmType = cbLivestockFarmType4.Text,
                    isOrganic = cbLivestockIsOrganic4.Text
                };

                parcel.Crops.Add(livestock4);
            }

            if (!string.IsNullOrWhiteSpace(txtLivestock5.Text))
            {
                FarmParcelCrop livestock5 = new FarmParcelCrop
                {
                    farmParcelNo = labelParcelNo.Text,
                    commodityType = txtLivestock5.Text,
                    landSize = 0,
                    headCount = Convert.ToInt32(txtLivestockHeadCount5.Text),
                    farmType = cbLivestockFarmType5.Text,
                    isOrganic = cbLivestockIsOrganic5.Text
                };

                parcel.Crops.Add(livestock5);
            }

            return parcel;
        }

    }
}
