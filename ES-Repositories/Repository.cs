using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EF_Models;
using System.Linq;
using System.Linq.Expressions;

namespace ES_Repositories
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        //protected IObjectSet<T> _objectSet;
        protected DbSet<T> _dbSet;
        public Repository(ESDatabaseContext context)
        {
            //_objectSet = context.CreateObjectSet<T>();
            _dbSet = context.Set<T>();
        }
        #region IRepository<T> Members
        public abstract T GetById(object id);
        public IEnumerable<T> GetAll()
        {
            //return _objectSet;
            return _dbSet;
        }
        public IEnumerable<T> Query(Expression<Func<T, bool>> filter)
        {
            //return _objectSet.Where(filter);
            return _dbSet.Where(filter);
        }
        public void Add(T entity)
        {
            //_objectSet.AddObject(entity);
            _dbSet.Add(entity);
        }
        public void Remove(T entity)
        {
            //_objectSet.DeleteObject(entity);
            _dbSet.Remove(entity);
        }
        #endregion
    }
}
