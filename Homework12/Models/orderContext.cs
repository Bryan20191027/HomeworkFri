using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
            : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Commodit> Commodits { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}