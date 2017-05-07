using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Treeview.Models
{
    public class SubSection
    {
        public int SubSectionID { get; set; }
        public int MainSectionID { get; set; }
        public string SubSectionTitle { get; set; }
    }
}