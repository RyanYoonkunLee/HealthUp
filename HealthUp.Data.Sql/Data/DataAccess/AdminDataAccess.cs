using HealthUp.Data.Sql.Data.DataContext;
using HealthUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthUp.Data.Sql.Data.DataAccess
{
    public class AdminDataAccess
    {
        
        public Admin GetAdmin()
        {
            HealthUpDataContext context = new HealthUpDataContext();
            var admin = context.Admins.ToList().First();

            return admin;
        }
    }
}
