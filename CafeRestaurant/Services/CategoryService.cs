using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    internal class CategoryService : BaseService<CATEGORY>
    {

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
