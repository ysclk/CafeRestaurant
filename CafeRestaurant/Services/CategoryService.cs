using CafeRestaurant.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{

    public class CategoryService : BaseService<CATEGORY>
    {
       
        public CategoryService(CafeRestaurantEntities db) : base(db)
        {
        }

        /// <summary>
        /// Returns the category name for a given category ID.
        /// </summary>
        public string categoryName(int categoryId)
        {
            var name = (from i in db.CATEGORY
                        where i.CATEGORYID == categoryId
                        select i.CATEGORYNAME).FirstOrDefault();
            return name;
        }


    }
}
