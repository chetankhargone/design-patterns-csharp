using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace customer.data.contract.Repository
{
    public interface IRepository<T>
        : IDisposable where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        void Save();

        void Update(T entity);

        IQueryable<T> GetQuery();

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T Single(Expression<Func<T, bool>> predicate);
    }
}