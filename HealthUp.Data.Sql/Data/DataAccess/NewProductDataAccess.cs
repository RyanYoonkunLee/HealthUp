using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class NewProductDataAccess
    {
        public List<NewProduct> GetNewProduct()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var NewProductList = context.NewProducts.ToList();

            return NewProductList;
        }

        public void Create(NewProduct newProduct)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Add(newProduct);
            context.SaveChanges();
        } 

        public NewProduct FindById(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var item = context.NewProducts.FirstOrDefault(m => m.Id == id);
            return item;
        }

        public void Update(NewProduct newProduct)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.NewProducts.Update(newProduct);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.NewProducts.Remove(FindById(id));
            context.SaveChanges();
        }
    }
}
