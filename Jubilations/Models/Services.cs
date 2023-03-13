using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Models
{
    public class Services
    {
        [Key]
        public int Services_Id { get; set; }



        [Display(Name = "User_Name")]
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Names { get; set; }


        [Display(Name = "Category_Name")]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Category_Names { get; set; }




        public string Services_Title { get; set; }
       
        public string Services_Create_Date { get; set; }
        public string Services_Update_Date { get; set; }
    }
}