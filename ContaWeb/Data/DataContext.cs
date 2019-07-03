
namespace ContaWeb.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
  
    public class DataContext: DbContext
    {
       
        public DbSet<Purchase> Purchases { get; set; }
        

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

    }
}
