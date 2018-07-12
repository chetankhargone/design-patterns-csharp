namespace customer.data.contract.Repository
{
    public interface IUnitOfWork
    {
        void InitTransaction();

        void Rollback();

        void CommitTransaction();
    }
}