using customer.db.ef.Repository.Domain;
using customer.model;
using customer.service.contract;
using System;
using System.Collections.Generic;

namespace customer.core.service
{
    public class CustomerService : BaseService, ICustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public Customer Create(Customer customer)
        {
            _customerRepository.Add(customer);
            _customerRepository.Save();

            return customer;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            return _customerRepository.Single(x => x.Id == id);
        }

        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetAll();
        }

        public bool Update(Customer customer)
        {
            var obj = _customerRepository.Single(x => x.Id == customer.Id);
            obj = customer;

            _customerRepository.Update(obj);
            _customerRepository.Save();

            return true;
        }
    }
}