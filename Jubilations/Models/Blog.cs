using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class Blog
    {
        [Key]
        public int Blog_Id { get; set; }
        public string Blog_Name { get; set; }
        public string Blog_Title { get; set; }
        public string Blog_Description { get; set; }
        public string Blog_Image { get; set; }
        public string Blog_Create_Date { get; set; }
        public string Blog_Update_Date { get; set; }
    }
}