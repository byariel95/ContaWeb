
namespace ContaWeb.Data
{
    using Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
  
    public class DataContext: IdentityDbContext<User>
    {
       
        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet <Client> Clients { get; set; }

        public DbSet<ShoppingBook> ShoppingBooks { get; set; }

        public DbSet<PurchaseDetail> purchaseDetails { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

    }
}
