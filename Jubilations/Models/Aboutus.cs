using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class Aboutus
    {
        [Key]
        public int aboutId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Slogan1 { get; set; }
        public string Slogan2 { get; set; }
        public string Slogan3 { get; set; }



    }
}