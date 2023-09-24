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
        public RsbsaAddView()
        {
            InitializeComponent();
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

            numericUpDown1.Value = 1;
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
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            panelColorPi.Visible = false;
            panelColorFp.Visible = false;
            panelColorFl.Visible = false;
            panelColorDoc.Visible = true;

            panelPersonalInfo.Visible = false;
            panelFarmProfile.Visible = false;
            panelFarmLand.Visible = false;
        }

        // End of Buttons/Tab

        private void RsbsaAddView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        //for farm parcel
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int numberOfControls = (int)numericUpDown1.Value;

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
    }
}
