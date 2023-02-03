using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilation.Models
{
    public class City
    {
        [Key]
        public int City_Id { get; set; }
        public string City_Name { get; set; }     
    }
}