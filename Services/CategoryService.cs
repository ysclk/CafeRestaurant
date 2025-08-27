using CafeRestaurant.Models;
using System.Linq;

namespace CafeRestaurant.Services
{

    public class CategoryService 
    {

        private readonly CafeRestaurantEntities db;

        public CategoryService(CafeRestaurantEntities db)
        {
            this.db = db; 
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
