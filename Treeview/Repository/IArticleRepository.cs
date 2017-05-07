using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treeview.Models;

namespace Treeview.Repository
{
    interface IArticleRepository : IDisposable
    {
        IEnumerable<Article> All{get;}
        IEnumerable<Article> GetArticles();
        Article GetArticleByID(int articleID);
        void InsertArticle(Article article);
        void DeleteArticle(int articleID);
        void UpdateArticle(Article article);
        void Save();
    }
}
