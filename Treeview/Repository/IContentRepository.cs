using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treeview.Models;
using System.Threading.Tasks;

namespace Treeview.Repository
{
    interface IContentRepository : IDisposable
    {
        //IEnumerable<Content> All {get;}
        IEnumerable<Content> GetContent();
        Content GetContentByID(int contentID);
        
        //void DeleteContent(int contentID);
        void UpdateContent(Content content);
        void Save();

        void InsertContent(Content content);
    }
}