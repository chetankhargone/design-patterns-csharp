using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace customer.db.ef.Repository
{
    public class EntityRepository<C, T> : BaseRepository<C, T>
        where C : CustomerContext
        where T : class
    {
        protected DbSet<T> DataSet
        {
            get
            {
                return _ctx.Set<T>();
            }
        }

        public EntityRepository(C ctx)
            : base(ctx)
        {
        }

        public override IQueryable<T> GetQuery()
        {
            return DataSet;
        }

        public override void Add(T entity)
        {
            DataSet.Add(entity);
        }

        public override void Save()
        {
            _ctx.SaveChanges();
        }

        public override void Delete(T entity)
        {
            DataSet.Remove(entity);
        }

        public override IEnumerable<T> GetAll()
        {
            return DataSet.ToList<T>();
        }

        public override IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return GetQuery().Where(predicate).ToList<T>();
        }

        public override T Single(Expression<Func<T, bool>> predicate)
        {
            return GetQuery().Where(predicate).SingleOrDefault();
        }

        public override void Update(T entity)
        {
            _ctx.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}