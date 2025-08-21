using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAllAsync(CancellationToken ct = default);
        Task<T> GetByIdAsync(int id, CancellationToken ct = default); // null dönecekse class zaten nullable
        Task InsertAsync(T entity, CancellationToken ct = default);
        Task DeleteAsync(int id, CancellationToken ct = default);
        Task UpdateAsync(T entity, CancellationToken ct = default);



    }
}

