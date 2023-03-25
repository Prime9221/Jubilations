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


        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        //public string ImagePath { get; set; }
        public string ImagePath { get; set; }

        public string User_GSTNO { get; set; }
        public string User_ShopName { get; set; }
        public string User_Address { get; set; }
        public string User_PinCode { get; set; }
        public string User_Password { get; set; }
        public string User_Create_Date { get; set; }
        public string User_Update_Date { get; set; }
    }
}