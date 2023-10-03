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
    public partial class RSBSAtry : Form
    {
        public RSBSAtry()
        {
            InitializeComponent();
        }

        private void RSBSAtry_Load(object sender, EventArgs e)
        {
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = false;
            this.VerticalScroll.Visible = false;
        }
    }
}
