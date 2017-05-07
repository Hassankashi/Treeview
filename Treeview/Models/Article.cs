using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treeview.Models
{
    public class Article
    {
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
        public string Body { get; set; }
        
    }
}