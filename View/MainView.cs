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
    public partial class MainView : Form
    {
        private Panel parentPanel;
        private AnalyticsController analyticsController;
        private LetterController letterController;

        public MainView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            analyticsController = new AnalyticsController(this);
            letterController = new LetterController(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            DataTable lettersTable = analyticsController.LoadLetterNotif();
            dgvNotif.DataSource = lettersTable;

            letterController.UpdateLetterStatus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
