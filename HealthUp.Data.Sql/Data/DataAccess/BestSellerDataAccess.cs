using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class BestSellerDataAccess
    {
        public List<BestSeller> GetBestSellers()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var BestSellers = context.BestSellers.ToList();

            return BestSellers;
        }
        public BestSeller FindById(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var bestSeller = context.BestSellers.First(m => m.Id == id);

            return bestSeller;
        }

        public void Create(BestSeller bestSeller)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Add(bestSeller);
            context.SaveChanges();
        }

        public void Update(BestSeller bestSeller)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Update(bestSeller);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            HealthUpDataContext context = new HealthUpDataContext();
            context.Remove(FindById(id));
            context.SaveChanges(); 
        }
    }
}
