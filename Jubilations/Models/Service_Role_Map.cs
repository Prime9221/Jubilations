using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class Service_Role_Map
    {
        [Key]
        public int Id { get; set; }




        [Display(Name = "Services_Name")]
        public int Services_Id { get; set; }
        [ForeignKey("Services_Id")]
        public virtual Services Services_Namess { get; set; }




        [Display(Name = "Category_Id")]
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Category_Ids { get; set; }
    }
}
