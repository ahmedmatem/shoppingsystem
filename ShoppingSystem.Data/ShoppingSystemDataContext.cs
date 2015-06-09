namespace ShoppingSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShoppingSystem.Data.Migrations;
    using ShoppingSystem.Models;
    using System.Data.Entity;

    public class ShoppingSystemDataContext : IdentityDbContext<ApplicationUser>
    {
        public ShoppingSystemDataContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ShoppingSystemDataContext Create()
        {
            return new ShoppingSystemDataContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShoppingSystemDataContext, Configuration>());

            base.OnModelCreating(modelBuilder);
        }

        public virtual IDbSet<Product> Products { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }
    }
}
