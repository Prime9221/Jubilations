using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jubilations.Models
{
    public class FeedBackModel
    {
        public int FeedBack_Id { get; set; }
        public string Name { get; set; }
        public string FeedBack_Email { get; set; }
        public string FeedBack_Message { get; set; }
        public string SuccessStory_Create_Date { get; set; }
        public string SuccessStory_Update_Date { get; set; }

        public List<FeedBack> feedbackList { get; set; }
    }
}