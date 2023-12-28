using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    public interface IGenericRepositories<T>: IDisposable where T : class
    {

        IEnumerable<T> GetAll( Expression<Func<T, bool>> filter = null, Func<IQueryable<T> , IOrderedQueryable<T>> orderby =  null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include =null , bool DisabledTracking = true
            );

        T GetById(object Id);

        T GetByIdsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disabledTracking = true);

        void Add (T entity);

        Task<T> AddAsync(T entity);

        void AddRange(List<T> entities);

        void Update(T entity);

        Task<T> UpdateAsync(T entity);




    }
}
