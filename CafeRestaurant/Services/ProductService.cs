using CafeRestaurant.DTOs;
using System.Collections.Generic;
using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    internal class ProductService : BaseService<PRODUCT>
    {
        /// <summary>
        /// Retrieves all products belonging to a specific category.
        /// </summary>
        public List<PRODUCT> GetByCategory(int categoryId)
        {
            return db.PRODUCT
                     .Where(p => p.CATEGORYID == categoryId)
                     .ToList();
        }

        /// <summary>
        /// Retrieves all products along with their category information
        /// using a stored procedure.
        /// </summary>
        public List<ProductDTO> GetAllWithCategory()
        {
            return db.Database
                     .SqlQuery<ProductDTO>("EXEC sp_GetProductsWithCategory")
                     .ToList();
        }

        /// <summary>
        /// Gets the price of a product by its ID.
        /// Returns 0 if the product is not found.
        /// </summary>
        public decimal GetPrice(int productId)
        {
            var price = db.PRODUCT
                          .Where(p => p.PRODUCTID == productId)
                          .Select(p => p.PRODUCTPRICE)
                          .FirstOrDefault();

            return price ?? 0;
        }

        /// <summary>
        /// Gets the stock quantity of a product by its ID.
        /// Returns 0 if the product is not found.
        /// </summary>
        public int GetStock(int productId)
        {
            var stock = db.PRODUCT
                          .Where(p => p.PRODUCTID == productId)
                          .Select(p => p.STOCK)
                          .FirstOrDefault();

            return stock;
        }

        /// <summary>
        /// Updates the stock quantity of a product.
        /// </summary>
        public virtual void UpdateStock(int productId, int stock)
        {
            var product = db.PRODUCT
                            .FirstOrDefault(p => p.PRODUCTID == productId);

            if (product != null)
            {
                product.STOCK = stock;
                db.SaveChanges();
            }
        }
    }
}