﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;

namespace Jubilations.Models
{
    public class Vender_CatalogModel
    {


        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
        
        public int Catalog_Id { get; set; }


        [Display(Name = "User_Name")]
        public List<User> UserNameList { get; set; }
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Name { get; set; }


        [Display(Name = "Category_Name")]

        public List<Category> CategoryList { get; set; }
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public virtual Category Category_Names { get; set; }

        [Display(Name = "Services_Name")]
        public List<Services> ServicesList { get; set; }
        public int Services_Id { get; set; }
        [ForeignKey("Services_Id")]
        public virtual Services Services_Name { get; set; }


        public string Product_image { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full")]
        public string Description { get; set; }

        public string Price { get; set; }

        public string Status { get; set; }

        public string Create_Date { get; set; }
        public string Update_Date { get; set; }

        public Vender_Catalog Vender_Catalogs { get; set; }
        public List<Vender_Catalog> CatalogList { get; set; }
    }
}