using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    internal class StockTransactionService:IStockService
    {
        protected CafeRestaurantEntities db = new CafeRestaurantEntities();

        public StockTransactionService()
        {
           
        }

        public void AddStock(int productId, int quantity, string reason = "Restock")
        {
            var transaction = new STOCKTRANSACTION
            {
                PRODUCTID = productId,
                QUANTITY = quantity,
                REASON = reason,
                TRANSACTIONDATE = DateTime.Now
            };

            db.STOCKTRANSACTION.Add(transaction);
            db.SaveChanges();
        }

        public void DecreaseStock(int productId, int quantity, string reason = "Sale")
        {
            AddStock(productId, -quantity, reason);
        }

        public void IncreaseStock(int productId, int quantity, string reason = "OrderCancelled")
        {
            AddStock(productId, quantity, reason);
        }
        public int GetStock(int productId)
        {
            return db.STOCKTRANSACTION
                .Where(t => t.PRODUCTID == productId)
                .Sum(t => t.QUANTITY);
        }
    }
}
