using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public string User_PhoneNo { get; set; }
        public string User_DOB { get; set; }
        public string User_Profile_Image { get; set; }


        [Display(Name = "Services_Id")]
        public int Services_Id { get; set; }
        
        [ForeignKey("Services_Id")]
        public virtual Services Services_Ids { get; set; }


        [Display(Name = "Services_Name")]
        public string Services_Name { get; set; }
        [ForeignKey("Services_Id")]
        public virtual Services Services_Names { get; set; }



        [Display(Name = "Category_Name")]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Categorys { get; set; }


        [Display(Name = "City_Name")]
        public int City_Id { get; set; }
        [ForeignKey("City_Id")]
        public virtual City Citys { get; set; }

        public string User_GSTNO { get; set; }
        public string User_ShopName { get; set; }
        public string User_Address { get; set; }
        public string User_PinCode { get; set; }
        public string User_Password { get; set; }
        public string User_Create_Date { get; set; }
        public string User_Update_Date { get; set; }
    }
}