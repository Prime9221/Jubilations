using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class UserModel
    {
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string User_PhoneNo { get; set; }
        public string User_DOB { get; set; }
        public string User_Profile_Image { get; set; }

        public string User_GSTNO { get; set; }
        public string User_ShopName { get; set; }
        public string User_Address { get; set; }
        public string User_PinCode { get; set; }
        public string User_Password { get; set; }
        public string User_Create_Date { get; set; }
        public string User_Update_Date { get; set; }

        public User User { get; set; }
        public List<User> UserList { get; set; }

    }
}