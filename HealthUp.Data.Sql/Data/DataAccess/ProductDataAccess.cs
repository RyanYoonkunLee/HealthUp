using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class ProductDataAccess 
    {       
        public ProductDataAccess()
        {
            
        }

        public void Create(Product productData)
        {
            ProductDataContext context = new ProductDataContext();

            context.Products.Add(productData);
            context.SaveChanges();
                      
        }

        public List<Product> GetProducts()
        {
            ProductDataContext context = new ProductDataContext();
            return context.Products.ToList();          
        }

        public Product Find(Guid id)
        {
            ProductDataContext context = new ProductDataContext();
            var find = context.Products.First<Product>(m => m.id == id);
            return find;         
        }

        public void Update(Product product)
        {
            ProductDataContext context = new ProductDataContext();
            var find = Find(product.id);
            find.name = product.name;
            context.Entry(find).State = EntityState.Modified;
            context.SaveChanges();                                   
        }

        public void Delete(Guid id)
        {
            ProductDataContext context = new ProductDataContext();
            var find = Find(id);
            context.Products.Remove(find);
            context.SaveChanges();
           
        }


    }
}
 