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
    public partial class WeeklyActivitiesView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;

        public WeeklyActivitiesView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
        }

        private void WeeklyActivitiesView_Load(object sender, EventArgs e)
        {
            DataTable actsTable = analyticsController.LoadWeeklyActivities();
            dgvActivities.DataSource = actsTable;
        }
    }
}
