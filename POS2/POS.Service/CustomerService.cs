using Microsoft.EntityFrameworkCore.Metadata.Internal;
using POS.Repository;
using POS.ViewModel;
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

        private CustomerModel EntityToModel(CustomerEntity entity)
        {
            CustomerModel result = new CustomerModel();
            result.Id = entity.Id;
            result.CompanyName = entity.CompanyName;
            result.ContactName = entity.ContactName;
            result.ContactTitle = entity.ContactTitle;
            result.Address = entity.Address;
            result.City = entity.City;
            result.Region = entity.Region;
            result.PostalCode = entity.PostalCode;
            result.Country = entity.Country;
            result.Phone = entity.Phone;
            result.Fax = entity.Fax;
            return result;
        }

        private void ModelToEntity(CustomerModel model, CustomerEntity entity)
        {
            entity.ContactName = model.ContactName;
            entity.ContactTitle = model.ContactTitle;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.Region = model.Region;
            entity.PostalCode = model.PostalCode;
            entity.Country = model.Country;
            entity.Phone = model.Phone;
            entity.Fax = model.Fax;
        }

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

        public CustomerModel View(int? id)
        {
            var entity = _context.CustomersEntities.Find(id);
            return EntityToModel(entity);
        }

        public void Update(CustomerModel entity)
        {
            var data = _context.CustomersEntities.Find(entity.Id);
            ModelToEntity(entity, data);
            _context.CustomersEntities.Update(data);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.CustomersEntities.Find(id);

            _context.CustomersEntities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
