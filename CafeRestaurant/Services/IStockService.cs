
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    internal interface IStockService
    {
        void AddStock(int productId, int quantity, string reason = "Restock");
        void DecreaseStock(int productId, int quantity, string reason = "Sale");
        void IncreaseStock(int productId, int quantity, string reason = "OrderCancelled");
    }
}
