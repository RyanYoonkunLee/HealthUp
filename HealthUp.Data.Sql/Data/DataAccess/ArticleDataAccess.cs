using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class ArticleDataAccess
    {
        public List<Article> GetArticles()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var list = context.Articles.ToList();

            return list;
        }
       
        public void Create(Article article)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Add(article);
            context.SaveChanges();                        
        }

        public Article FindById(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var foundArticle = context.Articles.FirstOrDefault(m => m.Id == id);
            
            return foundArticle;
        }

        public void Update(Article article)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Articles.Update(article);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var item = FindById(id);
            context.Articles.Remove(item);
            context.SaveChanges();
        }
    }
}
