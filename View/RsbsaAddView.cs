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
    public partial class RsbsaAddView : Form
    {
        private RSBSAController rsbsaController;
        public event EventHandler FormClosed;

        public RsbsaAddView()
        {
            InitializeComponent();
            rsbsaController = new RSBSAController(this);
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

            nudFarmParcelNo.Value = 1;

            rsbsaController.GenerateNewRSBSAId();

        }

        public void GenerateNewRSBSAId(string rsbsaId)
        {
            labelRsbsaId.Text = rsbsaId;
        }

        // Buttons/Tab

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

        // End of Buttons/Tab

        private void RsbsaAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
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

        private void nudFarmParcelNo_ValueChanged(object sender, EventArgs e)
        {
            int numberOfControls = (int)nudFarmParcelNo.Value;

            flowLayoutPanelParcels.Controls.Clear();

            for (int i = 0; i < numberOfControls; i++)
            {
                // Create an instance of your custom UserControl
                FarmLandControl farmLandControl = new FarmLandControl();

                // Set properties of the UserControl as needed
                farmLandControl.labelParcelNo.Text = "Parcel #" + (i + 1);

                // Add the UserControl to the parent control (e.g., Panel)
                flowLayoutPanelParcels.Controls.Add(farmLandControl);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rsbsaController.AddRSBSA(labelRsbsaId.Text, null, null, dtDateAdm.Value.Date, txtSurname.Text, txtFirstname.Text, txtMiddlename.Text,
                txtExtname.Text, cbSex.Text, txtAddPurok.Text, txtAddStreet.Text, cbAddBrgy.Text, txtAddMunicipality.Text, txtAddProvince.Text, txtAddRegion.Text,
                null, txtMobNo.Text, txtLandNo.Text, "Yes", txtGovIdType.Text, txtGovIdNum.Text, dtpBirthDate.Value.Date, txtBirthMunicipality.Text, txtBirthProvince.Text,
                txtBirthCountry.Text, null, null, txtSpouseName.Text, txtMaidenMother.Text, "Yes", null, null, Convert.ToInt32(nudNoLivingHouseMem.Value), Convert.ToInt32(nudHouseFemale.Value),
                Convert.ToInt32(nudHouseNoMale.Value), "No", "No", txtIndigenous.Text, "Yes", txtAssociation.Text, txtEcName.Text, txtEcContact.Text, "Yes", "Yes", "No", "No", "No", "No",
                "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No", "No",
                Convert.ToDouble(txtFarmingIncome.Text), Convert.ToDouble(txtNonFarmingIncome.Text)))
            {
                this.Close();
                FormClosed?.Invoke(this, EventArgs.Empty);

            }
        }

        private void txtAssociation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
