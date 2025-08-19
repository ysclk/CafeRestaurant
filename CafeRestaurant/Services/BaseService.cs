using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected CafeRestaurantEntities db = new CafeRestaurantEntities();

        public virtual List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public virtual void Insert(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = db.Set<T>().Find(id);
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                db.SaveChanges();
            }
        }

        public virtual void Update(T entity)
        {
            db.Set<T>().Attach(entity);  // context'e nesneyi ekle, takibe al
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

    }
}
