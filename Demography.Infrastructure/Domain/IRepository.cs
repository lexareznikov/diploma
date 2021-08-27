using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
//using Demography.Infrastructure.Model;

namespace Demography.Infrastructure.Domain
{
    public abstract class IRepository<T> where T : class
    {
        public virtual int Count { get; private set; }

        public abstract IQueryable<T> All();

        public abstract IQueryable<T> AsNoTracking();

        public abstract T GetById(object id);

        public abstract Task<T> GetByIdAsync(object id);

        public abstract IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        public abstract IQueryable<T> Filter(Expression<Func<T, bool>> predicate);

        public abstract IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);

        public abstract bool Contains(Expression<Func<T, bool>> predicate);

        public abstract T Find(params object[] keys);

        public abstract T Find(Expression<Func<T, bool>> predicate);

        public abstract T Create(T entity);

        public abstract void Delete(object id);

        public abstract void Delete(T entity);
        public abstract void Reload(T entity);

        public abstract void Delete(Expression<Func<T, bool>> predicate);

        public abstract void Update(T entity);

        public abstract void AddOrUpdate(T entity);

        //public abstract IList<LogModel> GetChanges(T entity);
    }
}