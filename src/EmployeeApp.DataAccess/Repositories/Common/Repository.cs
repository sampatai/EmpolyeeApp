using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using EmployeeApp.Core.Interface;

namespace EmployeeApp.DataAccess.Repositories.Common
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().UpdateRange(entities);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public bool ValidateById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id) != null;
        }

        public IEnumerable<TEntity> GetAllWithoutGlobalFilters()
        {
            return _dbContext.Set<TEntity>().IgnoreQueryFilters();
        }

        public IEnumerable<TEntity> FindWithoutGlobalFilters(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().IgnoreQueryFilters().Where(predicate);
        }

        #region New functions for async and Queryable fetch

        public IQueryable<TEntity> GetAllQueryable()
        {
            return _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> FindQueryable(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();
        }

        public IQueryable<TEntity> GetAllWithoutGlobalFiltersQueryable()
        {
            return _dbContext.Set<TEntity>().IgnoreQueryFilters();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        #endregion

    }
}
