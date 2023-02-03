using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jubilation.Models
{
    public class Contact
    {
        [Key]
        public int Contact_Id { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_PhoneNo { get; set; }



        [Display(Name = "City_Name")]
        public int City_Id { get; set; }
        [ForeignKey("City_Id")]
        public virtual City City_Name { get; set; }



        public string Contact_Message { get; set; }
    }
}