using Microsoft.EntityFrameworkCore;
using Passenger.Contract.Context;
using Passenger.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Repositories.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DataContext context { get; set; }
        protected GenericRepository(DataContext context)
        {
            this.context = context;
        }
        public virtual async Task<T> AddAsync(T entity)
        {
            context.Add<T>(entity);
            await SaveAsync();
            return entity;
        }
        public virtual async Task<T> DeleteAsync(T entity)
        {
            context.Remove<T>(entity);
            await SaveAsync();
            return entity;
        }
        public virtual async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
        public virtual async Task<T> FindByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).FirstOrDefaultAsync();
        }
        public virtual async Task<IEnumerable<T>> FindByConditionWithIncludeOtherTable(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).ToListAsync();
        }

        public virtual async Task<T> UpdateAsync(T entity, object key)
        {
            if (entity == null)
                return null;
            T exist = await context.Set<T>().FindAsync(key);

            if (exist != null)
            {
                context.Entry(exist).CurrentValues.SetValues(entity);
                await SaveAsync();
            }
            return exist;
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
