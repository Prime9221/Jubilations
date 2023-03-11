using Jubilations.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class ServicesModel
    {
        public ServicesModel()
        {
            User_Names = new User();
        }
        public int Services_Id { get; set; }
        public string Services_Name { get; set; }



        [Display(Name = "User_Name")]
        public int User_Id { get; set; }

        public List<User> UserNameList { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Names { get; set; }


        [Display(Name = "Category_Name")]
        public List<Category> CategoryList { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Category_Names { get; set; }
        public Services Services { get; set; }
        public List<Services> ServicesList { get; set; }
    }
}