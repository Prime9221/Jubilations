using Jubilation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Jubilations.Models
{
    public class FeedBack
    {

        [Key]
        public int FeedBack_Id { get; set; }
        public string FeedBack_Email { get; set; }
        public string FeedBack_Message { get; set; }
        public string SuccessStory_Create_Date { get; set; }
        public string SuccessStory_Update_Date { get; set; }
    }
}