using System.Collections.Generic;

namespace customer.service.contract
{
    public interface IService<T>
    {
        T Create(T entity);

        bool Update(T entity);

        bool Delete(int id);

        T Get(int id);

        IEnumerable<T> Get();
    }
}