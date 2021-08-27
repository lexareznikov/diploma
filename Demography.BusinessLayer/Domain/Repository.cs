using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Demography.Infrastructure.Domain;
using System.Threading.Tasks;
//using Demography.Infrastructure.Model;

namespace Demography.BusinessLayer.Domain
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
            //dbContext.Configuration.LazyLoadingEnabled = true;
        }

        #region IRepository<T> Members

        public override int Count
        {
            get { return _dbSet.Count(); }
        }

        public override IQueryable<T> All()
        {
            return _dbSet.AsQueryable();
        }

        public override IQueryable<T> AsNoTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public override T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public override Task<T> GetByIdAsync(object id)
        {
            return _dbSet.FindAsync(id);
        }

        public override IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (!String.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (string includeProperty in includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).AsQueryable();
            }
            return query.AsQueryable();
        }

        public override IQueryable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable();
        }

        public override IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50)
        {
            int skipCount = index * size;
            IQueryable<T> resetSet = filter != null ? _dbSet.Where(filter).AsQueryable() : _dbSet.AsQueryable();
            resetSet = skipCount == 0 ? resetSet.Take(size) : resetSet.Skip(skipCount).Take(size);
            total = resetSet.Count();
            return resetSet.AsQueryable();
        }

        public override bool Contains(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Count(predicate) > 0;
        }

        public override T Find(params object[] keys)
        {
            return _dbSet.Find(keys);
        }

        public override T Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public override T Create(T entity)
        {
            T newEntry = _dbSet.Add(entity);
            return newEntry;
        }

        public override void Delete(object id)
        {
            T entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public override void Delete(T entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public override void Delete(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> entitiesToDelete = Filter(predicate);
            foreach (T entity in entitiesToDelete)
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _dbSet.Remove(entity);
            }
        }

        public override void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot update a null entity.");
            }

            //_dbSet.Local.Clear();
            //_dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public override void AddOrUpdate(T entity)
        {
            _dbSet.AddOrUpdate(entity);
           
            if (_dbContext.Entry(entity).State != EntityState.Added)
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }

        }

        public override void Reload(T entity)
        {
            _dbContext.Entry(entity).Reload();
        }

        //public override IList<LogModel> GetChanges(T entity)
        //{
        //    _dbContext.Entry(entity).State = EntityState.Modified;
        //    //var tt = _dbContext.ChangeTracker.Entries<_dbContext.Entry(entity)>.Where(p => p.State == EntityState.Modified).ToList();

        //    var ent = _dbContext.Entry(entity);
        //    var changes = new List<LogModel>();

        //    foreach (var propName in ent.CurrentValues.PropertyNames)
        //    {
        //        var originalValue = ent.GetDatabaseValues().GetValue<object>(propName);
        //        var currentValue = ent.CurrentValues.GetValue<object>(propName);

        //        if (originalValue != null && currentValue != null)
        //        {
        //            if (!Equals(originalValue, currentValue))
        //            {
        //                changes.Add(new LogModel
        //                {
        //                    Field = propName,
        //                    ValueOld = originalValue.ToString(),
        //                    ValueNew = currentValue.ToString()
        //                });
        //            }
        //        }
        //        else if (originalValue != null)
        //        {
        //            changes.Add(new LogModel
        //            {
        //                Field = propName,
        //                ValueOld = originalValue.ToString(),
        //                ValueNew = ""
        //            });
        //        }
        //        else if (currentValue != null)
        //        {
        //            changes.Add(new LogModel
        //            {
        //                Field = propName,
        //                ValueOld = "",
        //                ValueNew = currentValue.ToString()
        //            });
        //        }
        //    }
        //    return changes;
        //}

        #endregion
    }
}