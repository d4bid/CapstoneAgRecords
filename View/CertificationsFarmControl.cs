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
    public partial class CertificationsFarmControl : UserControl
    {

        public event EventHandler RemoveButtonClick;

        public CertificationsFarmControl()
        {
            InitializeComponent();
        }

        private void CertificationsFarmControl_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Raise the custom event when the remove button is clicked
            RemoveButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public void SetData(Certifications certControlData)
        {
            labelParcelNo.Text = certControlData.farmParcelNo;
            txtFarmAddress.Text = certControlData.farmLocBrgy;
            txtFarmInfo.Text = certControlData.commodityInfo;
        }
    }
}
