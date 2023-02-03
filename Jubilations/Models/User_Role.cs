using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilation.Models
{
    public class User_Role
    {
        [Key]
        public int UserRole_Id { get; set; }
        public string UserRole_Name { get; set; }

    }
}