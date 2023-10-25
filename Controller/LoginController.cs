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
        UserModel userModel = new UserModel();

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
                userModel.InserActionLog(username, "Login", "Account", $"Login failed, invalid username or password ({username})");
                view.ShowError();
                //model.AuditLoginFailed(username);
            }
            else
            {
                bool isActive = model.CheckUserActive(user.username);

                if (isActive)
                {
                    userModel.InserActionLog(username, "Login", "Account", $"Login success ({username})");
                    view.NavigateToDashboard(user);
                    // Audit login success
                    //model.AuditLoginSuccess(user.username);
                    model.UpdateLoginStatus(user.username);
                }
                else
                {
                    userModel.InserActionLog(username, "Login", "Account", $"Login failed, account is inactive ({username})");
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
