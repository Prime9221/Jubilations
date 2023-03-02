using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class User_Role_Map
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "User_Name")]
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Names { get; set; }




        [Display(Name = "UserRole_Name")]
        public int UserRole_Id { get; set; }
        [ForeignKey("UserRole_Id")]
        public virtual User_Role UserRole_Names { get; set; }
    }
}