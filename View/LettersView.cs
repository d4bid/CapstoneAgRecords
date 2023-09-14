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
    public partial class LettersView : Form
    {
        private LetterController letterController;
        private Panel parentPanel;


        public LettersView(Control parentControl)
        {
            InitializeComponent();
            letterController = new LetterController(this);
            this.parentPanel = parentControl as Panel;
        }

        // Methods

        private void LettersAddView_FormClosed(object sender, EventArgs e)
        {
            LettersView lettersView = new LettersView(parentPanel);
            lettersView.TopLevel = false;
            lettersView.FormBorderStyle = FormBorderStyle.None;
            lettersView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(lettersView);
            lettersView.Show();
        }

        private void LettersView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable letterTable = letterController.LoadLetterView();
            dgvLetters.DataSource = letterTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LettersAddView lettersAddView = new LettersAddView();
            lettersAddView.FormClosed += LettersAddView_FormClosed;

            lettersAddView.TopLevel = false;
            lettersAddView.FormBorderStyle = FormBorderStyle.None;
            lettersAddView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(lettersAddView);
            lettersAddView.Show();
        }
    }
}
