using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class ProductRangeDataAccess
    {
        public List<ProductRange> GetProductRange()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var ProductRange = context.ProductRanges.ToList();

            return ProductRange;
        }
    }
}
