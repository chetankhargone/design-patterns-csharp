using customer.model;
using System.Data.Entity;

namespace customer.db.ef
{
    public class CustomerContext :
        DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #region DbSet

        public DbSet<Customer> Customers { get; set; }

        #endregion DbSet
    }
}