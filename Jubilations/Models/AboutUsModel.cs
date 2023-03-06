using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Jubilations.Models
{
    public class AboutUsModel
    {
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }

        public int aboutId { get; set; }
        public string title { get; set; }

        public string Pictures { get; set; }

        [AllowHtml]
        [UIHint("tinymce_full")]
        public string description { get; set; }

        public Aboutus aboutus { get; set; }
        public List<Aboutus> aboutusList { get; set; }
    }
}