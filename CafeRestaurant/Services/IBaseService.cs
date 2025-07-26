using System.Collections.Generic;
using System.Deployment.Internal;
using System.Runtime.InteropServices;

namespace CafeRestaurant.Services
{
    internal interface IBaseService<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id );
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
    }
}
