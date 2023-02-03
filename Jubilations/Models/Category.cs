using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilation.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string Category_Status { get; set; }
        public string Category_Create_Date { get; set; }
        public string Category_Update_Date { get; set; }
    }
}