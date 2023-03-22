using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Jubilations.Models
{
    public class User_Role_MapModel
    {

        public User_Role_MapModel()
        {
            User_Names = new User();
            UserRole_Names = new User_Role();
            User_Role_MapList = new List<User_Role_Map>();
        }




        public int Id { get; set; }




        [Display(Name = "User_Name")]
        public List<User> User_IdList { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Names { get; set; }



        [Display(Name = "UserRole_Name")]
        public List<User_Role> User_RoleList { get; set; }
        [ForeignKey("UserRole_Id")]
        public virtual User_Role UserRole_Names { get; set; }


        public User_Role_Map User_Role_Maps { get; set; }
        public List<User_Role_Map> User_Role_MapList { get; set; }
    }
}