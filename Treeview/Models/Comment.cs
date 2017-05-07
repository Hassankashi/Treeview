using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Treeview.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int ArticleID { get; set; }

        public string CommentTitle { get; set; }

        [Required (ErrorMessage="Please Enter your Message")]
        public string BodyMsg { get; set; }

        [Required (ErrorMessage = "Please Enter your Name")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
        public decimal Vote { get; set; }
        public string commentDateTime { get; set; }
        public bool Flag { get; set; }
      
    }
}