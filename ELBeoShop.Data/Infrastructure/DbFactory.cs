using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELBeoShop.Data.Infrastructure
{
    public class DbFactory : Disposable , IDbFactory
    {
        ELBeoShopDbContext dbContext;
        public ELBeoShopDbContext Init()
        {
            return dbContext ?? (dbContext = new ELBeoShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
