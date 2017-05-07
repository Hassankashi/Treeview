using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Treeview.Models
{
    public class Content
    {
        public int ContentID { get; set; }
       
        public string ContentTitle { get; set; }

        [AllowHtml]
        public string ContentBody { get; set; }

         
        public string Name { get; set; }
        
        public string Email { get; set; }
       
        public string Message { get; set; }
    }
}