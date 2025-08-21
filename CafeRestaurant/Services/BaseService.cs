using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{

    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected CafeRestaurantEntities db = new CafeRestaurantEntities();

        public BaseService(CafeRestaurantEntities db)
        {
            this.db = db;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            var context = new CafeRestaurantEntities();
            return await context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }

        public virtual async Task InsertAsync(T entity)
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id);
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                await db.SaveChangesAsync();
            }
        }

        public virtual async Task UpdateAsync(T entity)
        {
            db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public Task<List<T>> GetAllAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
