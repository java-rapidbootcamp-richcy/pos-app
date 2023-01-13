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

        public CustomerModel EntityToModel(CustomersEntity customersEntity)
        {
            CustomerModel result = new CustomerModel();
            result.Id = customersEntity.Id;
            result.CompanyName = customersEntity.CompanyName;
            result.ContactName = customersEntity.ContactName;
            result.ContactTitle = customersEntity.ContactTitle;
            result.Address = customersEntity.Address;
            result.City = customersEntity.City;
            result.Region = customersEntity.Region;
            result.PostalCode = customersEntity.PostalCode;
            result.Country = customersEntity.Country;
            result.Phone = customersEntity.Phone;
            result.Fax = customersEntity.Fax;
            return result;
        }

        public void ModelToEntity(CustomerModel model, CustomersEntity entity)
        {
            entity.CompanyName = model.CompanyName;
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

        public List<CustomersEntity> Get()
        {
            return _context.customersEntities.ToList();
        }

        public void Add(CustomersEntity customers)
        {
            _context.customersEntities.Add(customers);
            _context.SaveChanges();
        }

        public CustomerModel View(int? id)
        {
            var customers = _context.customersEntities.Find(id);
            return EntityToModel(customers);
        }

        public void Update(CustomerModel customers)
        {
            var entity = _context.customersEntities.Find(customers.Id);
            ModelToEntity(customers, entity);
            _context.customersEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var customers = _context.customersEntities.Find(id);
            _context.customersEntities.Remove(customers); 
            _context.SaveChanges();
        }


    }
}
