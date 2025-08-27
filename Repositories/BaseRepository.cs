using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly CafeRestaurantEntities db;

        public BaseRepository(CafeRestaurantEntities db)
        {
            this.db = db;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
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
    }
}
