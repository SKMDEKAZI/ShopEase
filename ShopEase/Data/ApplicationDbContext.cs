using Microsoft.EntityFrameworkCore;
using ShopEase.Models;

namespace ShopEase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerRequest> CustomerRequest { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ShopEase.Models.Aisle> Aisle { get; set; } = default!;


    }
}