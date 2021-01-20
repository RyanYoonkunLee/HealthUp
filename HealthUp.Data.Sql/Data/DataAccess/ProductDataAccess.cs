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
            HealthUpDataContext context = new HealthUpDataContext();

            context.Products.Add(productData);
            context.SaveChanges();
                      
        }

        public List<Product> GetProducts()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var products = context.Products.OrderBy( m => m.CategoryExpose).ThenBy(m => m.ProductExpose).ToList();
            return products;        
        }

        public Product Find(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var find = context.Products.First<Product>(m => m.Id == id);
            return find;         
        }

        public Product FindByName(string name)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var find = context.Products.FirstOrDefault<Product>(m => m.Name == name);
            return find;
        }

        public void Update(Product product)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var find = Find(product.Id);
            find = product;
            context.Entry(find).State = EntityState.Modified;
            context.SaveChanges();                                   
        }

        public List<Product> GetProductByName(string sort)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var result = context.Products.Where(m => EF.Functions.Like(m.Name, $"%{sort}%")).OrderBy(m => m.CategoryExpose).ThenBy(m => m.ProductExpose).ToList();
            return result;
        }

        public List<Product> GetCategoryByName(string sort)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var result = context.Products.Where(m => m.Category.Contains(sort)).OrderBy(m => m.CategoryExpose).ThenBy(m => m.ProductExpose).ToList();
            return result;
        }

        public List<Product> GetFunctionByName(string sort)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var result = context.Products.Where(m => m.Functions.Contains(sort)).OrderBy(m => m.CategoryExpose).ThenBy(m => m.ProductExpose).ToList();
            return result;
        }

        public void Delete(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var find = Find(id);
            context.Products.Remove(find);
            context.SaveChanges();
           
        }

        public List<Category> GetCategories()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var categories = context.Categories.ToList();
            return categories;
        }

        public List<Function> GetFunctions()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var functions = context.Functions.ToList();
            return functions;
        }

        public List<Product> GetRelatedProduct(string ids)
        {
            string[] nameList = ids.Split("\n");

            List<Product> selectedProduct = new List<Product>();

            foreach(var item in nameList)
            {
                var product = FindByName(item);
                selectedProduct.Add(product);
            }

            return selectedProduct;            
        }
    }
}
 