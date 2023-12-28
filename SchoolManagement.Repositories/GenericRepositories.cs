using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    public class GenericRepositories<T> : IDisposable, IGenericRepositories<T> where T : class
    {

        private readonly ApplicationDbContext _context;
        internal DbSet<T> Dbset;
        public GenericRepositories(ApplicationDbContext context)
        {
            _context = context;
             Dbset = _context.Set<T>();
        }
        private bool disposed = false;


        public void Dispose()
        {
            disposed = true;
            GC.SuppressFinalize(this);
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> AddAsync(T entity)
        {

            Dbset.Add(entity);
            return entity;
        }

        public void AddRange(List<T> entities)
        {
            Dbset.AddRange(entities);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool DisabledTracking = true)
        {
            throw new NotImplementedException();
        }

        public T GetById(object Id)
        {
            throw new NotImplementedException();
        }

        public T GetByIdsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool disabledTracking = true)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T entity)
        {
           Dbset.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
