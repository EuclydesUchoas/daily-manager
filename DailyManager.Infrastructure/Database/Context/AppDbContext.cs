using System.Data.Entity;

namespace DailyManager.Infrastructure.Database.Context
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
            // Configuration settings can be set here if needed
            // For example, to disable lazy loading or proxy creation
            /*this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;*/
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
