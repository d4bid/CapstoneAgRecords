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

            //rbEducText, txtMobNo.Text, txtLandNo.Text, rbGovIdText, txtGovIdType.Text, txtGovIdNum.Text,


            //Farm Profile



            //Farmland



            //Farmland Parcel



            //Farmland Parcel Crops



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
