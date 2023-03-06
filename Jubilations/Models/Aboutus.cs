using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jubilations.Models
{
    public class Aboutus
    {
        [Key]
        public int aboutId { get; set; }
        public string title { get; set; }

        //public string Pictures { get; set; }
      
        [AllowHtml]
        [UIHint("tinymce_full")]
        public string description { get; set; }


        //public string Name { get; set; }

        [DisplayName("Upload Image")]
        public string Pictures { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        public string ImagePath { get; set; }
        



    }
}