using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class Service_Role
    {
        [Key]
        public int Service_Role_Id { get; set; }
        public string Service_Role_Name { get; set; }
    }
}