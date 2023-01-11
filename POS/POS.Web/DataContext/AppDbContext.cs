using Microsoft.EntityFrameworkCore;
using POS.Repository;

namespace POS.Web.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categories> CategoryEntities => Set<Categories>();
        public DbSet<Customers> CustomerEntities => Set<Customers>();
        public DbSet<Employees> EmployeeEntities => Set<Employees>();
        public DbSet<Orders> OrderEntities => Set<Orders>();
        public DbSet<OrderDetails> OrderDetailsEntities => Set<OrderDetails>();
        public DbSet<Products> ProductEntities => Set<Products>();
        public DbSet<Suppliers> SupplierEntities => Set<Suppliers>();
    }
}
