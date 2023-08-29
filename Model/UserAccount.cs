using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Model
{
    public class UserAccount
    {
        public string userId { get; set; }
        public string userFirstname { get; set; }
        public string userLastname { get; set; }
        public string userGender { get; set; }
        public string userRole { get; set; }
        public string userContact { get; set; }
        public string userActive { get; set; }
        public string username { get; set; }
        public string userPassword { get; set; }
        public byte[] userPhoto { get; set; }
    }
}
