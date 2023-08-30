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
    public partial class RsbsaView : Form
    {
        private UserController userController;
        private Panel parentPanel;

        public RsbsaView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
        }

        private void RsbsaView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RsbsaAddView rsbsaAddView = new RsbsaAddView();
            rsbsaAddView.FormClosed += RsbsaAddView_FormClosed;

            rsbsaAddView.TopLevel = false;
            rsbsaAddView.FormBorderStyle = FormBorderStyle.None;
            rsbsaAddView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaAddView);
            rsbsaAddView.Show();
        }

        // Methods

        private void RsbsaAddView_FormClosed(object sender, EventArgs e)
        {
            RsbsaView rsbsaView = new RsbsaView(parentPanel);
            rsbsaView.TopLevel = false;
            rsbsaView.FormBorderStyle = FormBorderStyle.None;
            rsbsaView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(rsbsaView);
            rsbsaView.Show();
        }
    }
}
