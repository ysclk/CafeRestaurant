using CafeRestaurant.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace CafeRestaurant.Services
{
    internal class ProductService : BaseService<PRODUCT>
    {
        // Özel bir sorgu örneği: Belirli kategoriye ait ürünleri getir
        public List<PRODUCT> GetByCategory(int categoryId)
        {
            return db.PRODUCT.Where(x => x.CATEGORYID == categoryId).ToList();
        }

        public List<ProductDTO> GetAllWithCategory()
        {
            return db.Database.SqlQuery<ProductDTO>("EXEC sp_GetProductsWithCategory").ToList();
        }

        public decimal GetPrice(int productId)
        {
            var price = (from p in db.PRODUCT
                         where (p.PRODUCTID == productId)
                         select p.PRODUCTPRICE).FirstOrDefault();
            return price ?? 0;

        }

        public int GetStock(int productId)
        {
            var stock = (from p in db.PRODUCT
                         where (p.PRODUCTID == productId)
                         select p.STOCK).FirstOrDefault();
            return stock;

        }


        public  virtual void UpdateStock(int productId, int stock)
        {
            var product = db.PRODUCT.FirstOrDefault(p => p.PRODUCTID == productId);

            if (product != null)
            {
                product.STOCK = stock;
                db.SaveChanges();
            }
        }
    }
}
