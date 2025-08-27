using CafeRestaurant.DTOs;
using System.Collections.Generic;
using System.Linq;
using CafeRestaurant.Models;
using System.Data.Entity;
using System.Threading.Tasks;

    namespace CafeRestaurant.Services
    {
        public class ProductService 
        {

        private readonly CafeRestaurantEntities db;

        public ProductService(CafeRestaurantEntities db)
        {
            this.db = db;
        }

        /// <summary>
        /// Retrieves all products belonging to a specific category asynchronously.
        /// </summary>
        public async Task<List<PRODUCT>> GetByCategoryAsync(int categoryId)
            {
                return await db.PRODUCT
                    .Where(p => p.CATEGORYID == categoryId)
                    .ToListAsync();
            }

            /// <summary>
            /// Retrieves all products along with their category information using a stored procedure asynchronously.
            /// </summary>
            public async Task<List<ProductDTO>> GetAllWithCategoryAsync()
            {
                return await db.Database
                    .SqlQuery<ProductDTO>("EXEC sp_GetProductsWithCategory")
                    .ToListAsync();
            }

            /// <summary>
            /// Gets the price of a product by its ID asynchronously.
            /// Returns 0 if the product is not found.
            /// </summary>
            public async Task<decimal> GetPriceAsync(int productId)
            {
                var price = await db.PRODUCT
                    .Where(p => p.PRODUCTID == productId)
                    .Select(p => p.PRODUCTPRICE)
                    .FirstOrDefaultAsync();

                return price ?? 0;
            }

            /// <summary>
            /// Gets the stock quantity of a product by its ID asynchronously.
            /// Returns 0 if the product is not found.
            /// </summary>
            public async Task<int> GetStockAsync(int productId)
            {
                var stock = await db.PRODUCT
                    .Where(p => p.PRODUCTID == productId)
                    .Select(p => p.STOCK)
                    .FirstOrDefaultAsync();

                return stock;
            }

            /// <summary>
            /// Updates the stock quantity of a product asynchronously.
            /// </summary>
            public async Task UpdateStockAsync(int productId, int stock)
            {
                var product = await db.PRODUCT
                    .FirstOrDefaultAsync(p => p.PRODUCTID == productId);

                if (product != null)
                {
                    product.STOCK = stock;
                    await db.SaveChangesAsync();
                }
            }
        }
    }
   