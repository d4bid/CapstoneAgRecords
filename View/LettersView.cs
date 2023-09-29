using AgRecords.Controller;
using AgRecords.Model;
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
        private string type = "";

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

        private void LettersEditView_FormClosed(object sender, EventArgs e)
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
            comboBoxSearchCategory.SelectedIndex = 0;
            comboBoxFilterType.SelectedIndex = 0;

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

        private void dgvLetters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvLetters.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string userId = row.Cells[0].Value.ToString();

                if (userId != null)
                {
                    // Get the user account data from the database using the user ID
                    Letters letters = letterController.GetLetterInfoByLetterId(userId);
                    LettersPages lettersPages = letterController.GetLetterPagesByLetterId(userId);

                    LettersEditView lettersEditView = new LettersEditView(letters, lettersPages);
                    lettersEditView.FormClosed += LettersEditView_FormClosed;

                    lettersEditView.TopLevel = false;
                    lettersEditView.FormBorderStyle = FormBorderStyle.None;
                    lettersEditView.Dock = DockStyle.Fill;

                    parentPanel.Controls.Clear();
                    parentPanel.Controls.Add(lettersEditView);
                    lettersEditView.Show();
                }
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            getType(comboBoxFilterType);
            DataTable dt = letterController.SearchLetter(txtBoxSearch.Text, comboBoxSearchCategory.Text, type);
            dgvLetters.DataSource = dt;
        }

        private void comboBoxSearchFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            getType(comboBoxFilterType);
            DataTable dt = letterController.SearchLetter(txtBoxSearch.Text, comboBoxSearchCategory.Text, type);
            dgvLetters.DataSource = dt;
        }

        private void comboBoxFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            getType(comboBoxFilterType);
            DataTable dt = letterController.SearchLetter(txtBoxSearch.Text, comboBoxSearchCategory.Text, type);
            dgvLetters.DataSource = dt;
        }

        public string getType(ComboBox comboBox)
        {
            type = comboBox.Text;
            if (type == "All")
            {
                return type = "";
            }
            else
            {
                return type;
            }
        }
    }
}
