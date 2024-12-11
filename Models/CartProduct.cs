
namespace ECommerceApi.Models
{
    public class CartProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Foreign key to the Product model
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product Product { get; set; } // Navigation property to the Product
        public int AppUserId { get; set; } // Foreign key to the AppUser (customer)

        public AppUser AppUser { get; set; } // Navigation property to the AppUser
    }
}
