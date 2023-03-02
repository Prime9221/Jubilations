using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class SuccessStory
    {
        [Key]
        public int SuccessStory_Id { get; set; }


        [Display(Name = "User_Id")]
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public virtual User User_Ids { get; set; }


        //[Display(Name = "User_Profile_Image")]
        //public string SuccessStory_User_Profile_Image { get; set; }
        //[ForeignKey("User_Id")]
        //public virtual User User_Profile_Images { get; set; }




        public string SuccessStory_Images { get; set; }
        public string SuccessStory_Message { get; set; }
        public string SuccessStory_Create_Date { get; set; }
        public string SuccessStory_Update_Date { get; set; }
    }
}