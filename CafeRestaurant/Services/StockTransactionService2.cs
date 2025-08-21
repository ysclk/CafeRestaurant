using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    public class StockTransactionService2 : BaseService<STOCKTRANSACTION>
    {
        public StockTransactionService2(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
