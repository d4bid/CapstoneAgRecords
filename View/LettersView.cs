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
    public partial class LettersView : Form
    {
        public LettersView()
        {
            InitializeComponent();
        }

        private void LettersView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LettersAddView lettersAddView = new LettersAddView();
            lettersAddView.Show();
            this.Close();
        }
    }
}
