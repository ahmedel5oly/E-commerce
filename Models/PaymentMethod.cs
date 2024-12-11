
namespace ECommerceApi.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; } // e.g., "Credit Card", "PayPal", etc.
        public string Description { get; set; }

        public ICollection<Order> Orders { get; set; } // A payment method can be associated with multiple orders
    }
}
