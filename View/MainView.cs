﻿using System;
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

        public MainView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
