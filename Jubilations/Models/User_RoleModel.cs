using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class User_RoleModel
    {
        public int UserRole_Id { get; set; }
        public string UserRole_Name { get; set; }

        public User_Role User_Roles { get; set; }
        public List<User_Role> User_RoleList { get; set; }
    }
}