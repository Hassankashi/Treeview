using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treeview.Models;
using System.Data;

namespace Treeview.Repository
{
    public class CommentRepository : ICommentRepository
    {

         private CosmicVerseEntities context;
        
         public CommentRepository(CosmicVerseEntities context)
         {
             this.context = context;
         }

         public IEnumerable<Comment> GetComment()
         {
             return context.Comments.ToList();
         }

         public IEnumerable<Comment> All
         {
             get { return context.Comments.ToList(); }
         }

         public List<Comment> GetCommentByArticleID(int articleid)
         {
            // var querylistC =
               return  (from m in context.Comments
                          where m.ArticleID == articleid && m.Flag == true
                          select m).ToList();
           //  return context.Comments.Select((articleid);
         }

         public void InsertComment(Comment comment)
        {
            context.Comments.Add(comment);
        }

        //public void DeleteContent(int contentID)
        //{
        //    Content user = context.Contents.Find(contentID);
        //    context.Contents.Remove(user);
        //}

        //public void UpdateContent(Content content)
        //{
        //    context.Entry(content).State = Entitystate.Modified;
        //}

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }





       

       

      
    }
}