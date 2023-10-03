using AgRecords.Model;
using AgRecords.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Controller
{
    internal class RSBSAController
    {
        private RsbsaAddView rsbsaAddView;
        private Boolean isDone = false; 
        private string fullName = HomeView.Instance.fullName.Text;
        private RSBSAModel rsbsaModel;
        UserModel userModel = new UserModel();

        public RSBSAController(RsbsaAddView rsbsaAddView)
        {
            this.rsbsaAddView = rsbsaAddView;
            rsbsaModel = new RSBSAModel();
        }

        public void GenerateNewRSBSAId()
        {
            try
            {
                rsbsaAddView.GenerateNewRSBSAId(rsbsaModel.GenerateRSBSAId());

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "ID Generation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string GetUserIdByFullName(string fullName)
        {
            try
            {
                return userModel.FindUserIDByFullName(fullName);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Finding User ID Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }
        }
    }
}
