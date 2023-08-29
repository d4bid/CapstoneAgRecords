using AgRecords.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    public class LoginController
    {
        private LoginView view;
        private LoginModel model;

        public LoginController(LoginView view)
        {
            this.view = view;
            model = new LoginModel();
        }

        public void ValidateUser(string username, string password)
        {
            UserAccount user = model.GetUserAccount(username, password);

            if (user == null)
            {
                view.ShowError();
                //model.AuditLoginFailed(username);
            }
            else
            {
                bool isActive = model.CheckUserActive(user.username);

                if (isActive)
                {
                    view.NavigateToDashboard(user);
                    // Audit login success
                    //model.AuditLoginSuccess(user.username);
                    model.UpdateLoginStatus(user.username);
                }
                else
                {
                    view.ShowInactiveError();
                    //model.AuditLoginFailed(user.username);
                }
            }
        }

        public void ResetLoginTable()
        {
            model.ResetLoginTable();
        }
    }
}
