using CafeRestaurant.Models;


namespace CafeRestaurant.Repositories
{
    public class ProductRepository : BaseRepository<PRODUCT>
    {
        public ProductRepository(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
