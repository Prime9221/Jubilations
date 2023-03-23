using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class Register
    {

        [Key]
        public int Id { get; set; }
        public string Owner_Name { get; set; }
        public string Business_Name { get; set; }
        public string Business_Addres { get; set; }
        public int GST_NO { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Email_ID { get; set; }
        public string Phone_No { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Create_Date { get; set; }
        public string Update_Date { get; set; }
    }
}