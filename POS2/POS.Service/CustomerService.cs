using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class CustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CustomerEntity> Get()
        {
            return _context.CustomersEntities.ToList();
        }

        public void Add(CustomerEntity entity)
        {
            _context.CustomersEntities.Add(entity);
            _context.SaveChanges();
        }

        public CustomerEntity View(int? id)
        {
            var entity = _context.CustomersEntities.Find(id);
            return entity;
        }

        public void Update(CustomerEntity entity)
        {
            _context.CustomersEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = View(id);

            _context.CustomersEntities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
