using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treeview.Models;

namespace Treeview.Repository
{
    interface ICommentRepository : IDisposable
    {
        IEnumerable<Comment> All { get; }
        IEnumerable<Comment> GetComment();
        List<Comment> GetCommentByArticleID(int articleid);
       
        void InsertComment(Comment comment);
        //void DeleteComment(int commentID);
        //void UpdateComment(Comment comment);
        void Save();
    }
}