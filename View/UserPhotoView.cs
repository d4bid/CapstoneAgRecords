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
    public partial class UserPhotoView : Form
    {
        private Image displayedImage;

        public UserPhotoView(Image selectedImage)
        {
            InitializeComponent();
            displayedImage = selectedImage;
            pictureBox1.Image = displayedImage;
        }
    }
}
