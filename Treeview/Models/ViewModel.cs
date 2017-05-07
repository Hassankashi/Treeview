using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Treeview.Models
{
    public class ViewModel
    {
        //public IEnumerable<Article> allArticle { get; set; }
        //public List<Article> allArticles { get; set; }
        //public List<Comment> allComment { get; set; }
        //public List<MainSection> allMainSection { get; set; }
        //public List<SubSection> allSubSection { get; set; }

        //Article
        public int ArticleID { get; set; }
        public int MainSectionID { get; set; }
        public int SubSectionID { get; set; }

        public string ArticleTitle { get; set; }
        public string ShortDesc { get; set; }
        public string ArticleDateTime { get; set; }
        public string Author { get; set; }
        public decimal VoteAvg { get; set; }
        public string FilePath { get; set; }
        public string Tag { get; set; }

       [AllowHtml]
        public string Body { get; set; }



        //comment
        public int CommentID { get; set; }
       
        public string CommentTitle { get; set; }

        [Required(ErrorMessage = "Please Enter your Message")]
        public string BodyMsg { get; set; }

        [Required(ErrorMessage = "Please Enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Email")]
        public string Email { get; set; }
        public decimal Vote { get; set; }
        public string commentDateTime { get; set; }
        public bool Flag { get; set; }

        //MainSection
        public string MainSectionTitle { get; set; }

        //SubSection
        public string SubSectionTitle { get; set; }

        public IEnumerable<Comment> allComment { get; set; }
        public IEnumerable<Treeview.Comment> allComments { get; set; }
    }
}