
using System;
using System.Collections.Generic;

namespace ECommerceApi.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } // Hashed password for security

        // Optional: You can include roles or any other user-specific data here

        public ICollection<Order> Orders { get; set; } // One user can have many orders
    }
}
