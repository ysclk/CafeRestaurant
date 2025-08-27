using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    public class MonthlyTotalAmountDTO
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal MonthlyAmount { get; set; }
        public int TotalOrder { get; set; }
    }
}
