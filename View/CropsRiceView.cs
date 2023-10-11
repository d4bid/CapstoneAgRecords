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
    public partial class CropsRiceView : Form
    {
        private Panel parentPanel;

        public CropsRiceView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
        }

        // Methods
        private void CropsRiceAddView_FormClosed(object sender, EventArgs e)
        {
            CropsRiceView cropsRiceView = new CropsRiceView(parentPanel);
            cropsRiceView.TopLevel = false;
            cropsRiceView.FormBorderStyle = FormBorderStyle.None;
            cropsRiceView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(cropsRiceView);
            cropsRiceView.Show();
        }

        // Trigger Events

        private void CropsRiceView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RiceAddView riceAddView = new RiceAddView();
            riceAddView.FormClosed += (s, args) => {
                // Show CropsRiceAddView when RiceAddView is closed
                CropsRiceAddView cropsRiceAddView = new CropsRiceAddView();
                cropsRiceAddView.FormClosed += CropsRiceAddView_FormClosed;

                cropsRiceAddView.TopLevel = false;
                cropsRiceAddView.FormBorderStyle = FormBorderStyle.None;
                cropsRiceAddView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(cropsRiceAddView);
                cropsRiceAddView.Show();
            };

            riceAddView.Show();
        }
    }
}
