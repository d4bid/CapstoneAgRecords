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
    public partial class AnalyticsRsbsaView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public AnalyticsRsbsaView(Control parentControl)
        {
            InitializeComponent();


            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        public void CountFarmer(string countFarmer)
        {
            labelFarmers.Text = countFarmer.ToString();
        }

        public void CountFisherfolk(string countFisherfolk)
        {
            labelFarmers.Text = countFisherfolk.ToString();
        }

        private void AnalyticsRsbsaView_Load(object sender, EventArgs e)
        {
            analyticsController.CountFarmer();
            analyticsController.CountFisherfolk();


        }
    }
}
