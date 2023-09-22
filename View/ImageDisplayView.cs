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
    public partial class ImageDisplayView : Form
    {
        private Image displayedImage;

        public ImageDisplayView(Image selectedImage)
        {
            InitializeComponent();
            displayedImage = selectedImage;
            pictureBox1.Image = displayedImage;

        }

        private void ImageDisplayView_Load(object sender, EventArgs e)
        {

        }
    }
}