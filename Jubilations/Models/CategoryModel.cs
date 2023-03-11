using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class CategoryModel
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string Category_Status { get; set; }
        public string Category_Create_Date { get; set; }
        public string Category_Update_Date { get; set; }


        public Category Categorys { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}