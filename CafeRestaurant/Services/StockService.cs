using System;
using System.Collections.Generic;
using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    internal class StockService: BaseService<PRODUCTSTOCK>
    {
       
        public PRODUCTSTOCK ProductStockByProductid(int productId)
        {
            return db.PRODUCTSTOCK.FirstOrDefault(t => t.PRODUCT_ID == productId);
        }

        public virtual void UpdateStock(int productId) 
           {
            var stock = db.PRODUCTSTOCK.FirstOrDefault(x => x.PRODUCT_ID == productId);
            if (stock != null)
            {
               
                db.SaveChanges();
            }
        }

        public int GetStock(int productId)
        {
            return (from i in db.PRODUCTSTOCK
            where i.PRODUCT_ID == productId
            select i.STOCK).FirstOrDefault() ?? 0;
        }
    }
}
