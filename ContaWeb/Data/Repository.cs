

namespace ContaWeb.Data
{
    using ContaWeb.Data.Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Repository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Purchase> GetPurchases()
        {
            return this.context.Purchases.OrderBy(p => p.Date);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync()>0;
        }


    }
}
