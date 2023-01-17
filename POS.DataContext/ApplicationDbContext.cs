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
        public DbSet<OrdersEntity> ordersEntities => Set<OrdersEntity>();
        public DbSet<CustomersEntity> customersEntities => Set<CustomersEntity>();
        public DbSet<OrderDetailsEntity> orderDetailsEntities => Set<OrderDetailsEntity>();
        public DbSet<EmployeeEntity> employeesEntities => Set<EmployeeEntity>();
    }
}
