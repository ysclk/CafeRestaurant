using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    public class DailyTotalAmountDTO
    {
        public DateTime OrderDate { get; set; }
        public decimal DailyAmount { get; set; }
        public int TotalOrder { get; set; }
    }
}
