using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmployeeApp.Core.Interface
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity GetById(int id);
		IEnumerable<TEntity> GetAll();
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
		void Add(TEntity entity);
		void AddRange(IEnumerable<TEntity> entities);
		void Remove(TEntity entity);
		void RemoveRange(IEnumerable<TEntity> entities);
		void Update(TEntity entity);
		void UpdateRange(IEnumerable<TEntity> entities);
		bool ValidateById(int id);
		IEnumerable<TEntity> GetAllWithoutGlobalFilters();

		#region generic function for queriable and async call

		IQueryable<TEntity> GetAllQueryable();
		IQueryable<TEntity> FindQueryable(Expression<Func<TEntity, bool>> predicate);
		Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
		IQueryable<TEntity> GetAllWithoutGlobalFiltersQueryable();
		Task<TEntity> GetByIdAsync(int id);

		#endregion
	}
}
