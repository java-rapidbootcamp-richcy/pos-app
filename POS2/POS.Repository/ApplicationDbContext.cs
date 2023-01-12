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

        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<ProductEntity> ProductEntities => Set<ProductEntity>();
        public DbSet<SupplierEntity> SupplierEntities => Set<SupplierEntity>();
        public DbSet<OrderEntity> OrdersEntities => Set<OrderEntity>();
        public DbSet<CustomerEntity> CustomersEntities => Set<CustomerEntity>();
        public DbSet<OrderDetailEntity> OrderDetailsEntities => Set<OrderDetailEntity>();
        public DbSet<EmployeeEntity> EmployeesEntities => Set<EmployeeEntity>();
    }
}
