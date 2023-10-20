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
    public partial class UserView : Form
    {
        private UserController userController;
        private Panel parentPanel;

        public UserView(Control parentControl)
        {
            InitializeComponent();

            this.parentPanel = parentControl as Panel;
            userController = new UserController(this);
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            FormRefresh();
        }

        public void FormRefresh()
        {
            DataTable userTable = userController.LoadUserView();
            dgvUsers.DataSource = userTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAddView userAddView = new UserAddView();
            userAddView.FormClosed += UserAddView_FormClosed;

            userAddView.TopLevel = false;
            userAddView.FormBorderStyle = FormBorderStyle.None;
            userAddView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(userAddView);
            userAddView.Show();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the user clicked on a cell in a row, not on the header row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                // Get the user ID from the first cell of the row
                string userId = row.Cells[1].Value.ToString();

                // Get the user account data from the database using the user ID
                UserAccount user = userController.GetUserAccountById(userId);

                UserEditView userEditView = new UserEditView(user);
                userEditView.FormClosed += UserEditView_FormClosed;

                userEditView.TopLevel = false;
                userEditView.FormBorderStyle = FormBorderStyle.None;
                userEditView.Dock = DockStyle.Fill;

                parentPanel.Controls.Clear();
                parentPanel.Controls.Add(userEditView);
                userEditView.Show();

            }
        }

        // Methods

        private void UserAddView_FormClosed(object sender, EventArgs e)
        {
            UserView userView = new UserView(parentPanel);
            userView.TopLevel = false;
            userView.FormBorderStyle = FormBorderStyle.None;
            userView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(userView);
            userView.Show();
        }

        private void UserEditView_FormClosed(object sender, EventArgs e)
        {
            UserView userView = new UserView(parentPanel);
            userView.TopLevel = false;
            userView.FormBorderStyle = FormBorderStyle.None;
            userView.Dock = DockStyle.Fill;

            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(userView);
            userView.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            RSBSAImportExcelView importExcelView = new RSBSAImportExcelView();
            importExcelView.ShowDialog();
        }
    }
}
