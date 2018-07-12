using customer.data.contract.Repository.Domain;
using customer.model;

namespace customer.db.ef.Repository.Domain
{
    public class CustomerRepository : EntityRepository<CustomerContext, Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext ctx)
            : base(ctx)
        {
        }
    }
}