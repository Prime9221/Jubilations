using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilation.Models
{
    public class Blog_Comment
    {
        [Key]
        public int Blog_Comment_Id { get; set; }
        public string Blog_Comment_Name { get; set; }
        public string Blog_Comment_Comment { get; set; }
    }
}