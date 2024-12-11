
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [MaxLength(100)]
        public int CategoryId {get; set;}
        public Category Category {get; set;}
        public ICollection<CartProduct> CartProducts {get; set;}
    }
}