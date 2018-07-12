using customer.data.contract.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace customer.db.ef.Repository
{
    public abstract class BaseRepository<C, T> : IRepository<T>
        where T : class
        where C : DbContext
    {
        protected readonly C _ctx;
        private bool disposed;

        public BaseRepository(C ctx)
        {
            _ctx = ctx;
        }

        ~BaseRepository()
        {
        }

        public void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(true);
        }

        public abstract void Add(T entity);

        public abstract void Delete(T entity);

        public abstract IEnumerable<T> GetAll();

        public abstract IQueryable<T> GetQuery();

        public abstract void Save();

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            else
            {
                if (disposing)
                {
                    _ctx.Dispose();
                }
                disposed = true;
            }
        }

        public abstract IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        public abstract T Single(Expression<Func<T, bool>> predicate);

        public abstract void Update(T entity);
    }
}