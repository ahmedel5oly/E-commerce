
namespace ECommerceApi.Models
{
    public class CartProduct
    {
        public int CartId { get; set; }
        public Cart Cart {get; set;}
        public int ProductId { get; set; } // Foreign key to the Product model
        public Product Product { get; set; } // Navigation property to the Product
        public int Quantity { get; set; } 
    }
}
