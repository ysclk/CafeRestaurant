using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    public class OrderStatusService : BaseService<ORDERSTATUSTYPES>
    {
        public OrderStatusService(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
