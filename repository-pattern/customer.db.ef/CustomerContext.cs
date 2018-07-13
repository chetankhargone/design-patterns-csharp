using customer.model;
using System.Data.Entity;

namespace customer.db.ef
{
   public class CustomerContext :
        DbContext, IUnitOfWork
    {
        private DbContextTransaction _dbTransaction;
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void InitTransaction()
        {
            _dbTransaction = this.Database.BeginTransaction();
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }

        public void CommitTransaction()
        {
            _dbTransaction.Commit();
        }

        #region DbSet

        public DbSet<Customer> Customers { get; set; }

        #endregion DbSet
    }
}
