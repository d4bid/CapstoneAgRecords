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

        public UserView()
        {
            InitializeComponent();
            userController = new UserController(this);
        }

        private void UserView_Load(object sender, EventArgs e)
        {
            DataTable userTable = userController.LoadUserView();
            dgvUsers.DataSource = userTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            UserAddView userAddView = new UserAddView();
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
                userEditView.Show();
                this.Close();

            }
        }
    }
}
