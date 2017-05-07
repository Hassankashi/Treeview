using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Treeview.Models;

namespace Treeview.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private CosmicVerseEntities context;

        public ArticleRepository(CosmicVerseEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Article> GetArticles()
        {
            return context.Articles.ToList();
        }

        public Article GetArticleByID(int articleID)
        {
            return context.Articles.Find(articleID);
        }

        public void InsertArticle(Article article)
        {
            context.Articles.Add(article);
        }

        public void DeleteArticle(int articleID)
        {
            Article user = context.Articles.Find(articleID);
            context.Articles.Remove(user);
        }

        public void UpdateArticle(Article article)
        {
            context.Entry(article).State = EntityState.Modified;
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




        public IEnumerable<Article> All
        {
            get { return context.Articles.ToList(); }
        }
    }
}