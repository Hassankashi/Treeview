using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Treeview.Models;
using System.Data;


namespace Treeview.Repository
{
    public class ContentRepository : IContentRepository
    {
         private CosmicVerseEntities context;

         public ContentRepository(CosmicVerseEntities context)
         {
             this.context = context;
         }

         public IEnumerable<Content> GetContent()
         {
             return context.Contents.ToList();
         }

         public Content GetContentByID(int contentid)
         {
             return context.Contents.Find(contentid);
         }

        public void InsertContent(Content content)
        {
            context.Contents.Add(content);
        }

        //public void DeleteContent(int contentID)
        //{
        //    Content user = context.Contents.Find(contentID);
        //    context.Contents.Remove(user);
        //}

        public void UpdateContent(Content content)
        {
            context.Entry(content).State = System.Data.EntityState.Modified;
        }

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
        
        //public IEnumerable<Content> All
        //{
        //    get { return context.Contents.ToList(); }
        //}
    }
}