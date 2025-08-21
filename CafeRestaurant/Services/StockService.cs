using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class StockService : BaseService<PRODUCTSTOCK>
    {
        public StockService(CafeRestaurantEntities db) : base(db)
        {
        }

        /// <summary>
        /// Get the stock entity by product ID asynchronously
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <returns>PRODUCTSTOCK entity or null if not found</returns>
        public async Task<PRODUCTSTOCK> ProductStockByProductIdAsync(int productId)
        {
            return await db.PRODUCTSTOCK.FirstOrDefaultAsync(t => t.PRODUCT_ID == productId);
        }

        /// <summary>
        /// Update the stock for a specific product asynchronously
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <param name="newStock">New stock value to set</param>
        public async Task UpdateStockAsync(int productId, int newStock)
        {
            var stock = await db.PRODUCTSTOCK.FirstOrDefaultAsync(x => x.PRODUCT_ID == productId);
            if (stock != null)
            {
                stock.STOCK = newStock; // Update stock value
                await db.SaveChangesAsync(); // Save changes asynchronously
            }
        }

        /// <summary>
        /// Get the current stock quantity for a product asynchronously
        /// </summary>
        /// <param name="productId">Product ID</param>
        /// <returns>Stock quantity, 0 if not found</returns>
        public async Task<int> GetStockAsync(int productId)
        {
            var stock = await db.PRODUCTSTOCK
                .Where(i => i.PRODUCT_ID == productId)
                .Select(i => i.STOCK)
                .FirstOrDefaultAsync();

            return stock ?? 0;
        }
    }
}
