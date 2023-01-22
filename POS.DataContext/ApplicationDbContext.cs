using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CategoryEntity> categoryEntities => Set<CategoryEntity>();
        public DbSet<ProductEntity> productEntities => Set<ProductEntity>();
        public DbSet<SupplierEntity> supplierEntities => Set<SupplierEntity>();
        public DbSet<OrderEntity> ordersEntities => Set<OrderEntity>();
        public DbSet<CustomerEntity> customersEntities => Set<CustomerEntity>();
        public DbSet<OrderDetailEntity> orderDetailsEntities => Set<OrderDetailEntity>();
        public DbSet<EmployeeEntity> employeesEntities => Set<EmployeeEntity>();
        public DbSet<ShipperEntity> shipperEntities => Set<ShipperEntity>();
    }
}
