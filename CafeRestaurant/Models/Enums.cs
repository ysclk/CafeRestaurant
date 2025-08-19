

namespace CafeRestaurant.Models
{
    public class Enums
    {
        public enum OrderType
        {
            AtTable = 0,
            Package = 1,
            Self = 2
        }

        public enum PaymentStatus
        {
            Paid = 0,
            NotPaid = 1
        }
    }
}
