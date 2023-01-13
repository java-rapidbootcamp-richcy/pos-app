using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class SupplierService
    {
        private readonly ApplicationDbContext _context;

        public SupplierModel EntityToModel(SupplierEntity supplierEntity)
        {
            SupplierModel result = new SupplierModel();
            result.Id = supplierEntity.Id;
            result.CompanyName = supplierEntity.CompanyName;
            result.ContactName = supplierEntity.ContactName;
            result.ContactTitle = supplierEntity.ContactTitle;
            result.Address = supplierEntity.Address;
            result.City = supplierEntity.City;
            result.Region = supplierEntity.Region;
            result.PostalCode = supplierEntity.PostalCode;
            result.Country = supplierEntity.Country;
            result.Phone = supplierEntity.Phone;
            result.Fax = supplierEntity.Fax;
            result.HomePage = supplierEntity.HomePage;
            return result;
        }

        public void ModelToEntity(SupplierModel model, SupplierEntity entity)
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
            entity.HomePage = model.HomePage;
        }

        public SupplierService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SupplierEntity> Get()
        {
            return _context.supplierEntities.ToList();
        }

        public void Add(SupplierEntity supplier)
        {
            _context.supplierEntities.Add(supplier);
            _context.SaveChanges();
        }

        public SupplierModel View(int? id)
        {
            var supplier = _context.supplierEntities.Find(id);
            return EntityToModel(supplier);
        }

        public void Update(SupplierModel supplier)
        {
            var entity = _context.supplierEntities.Find(supplier.Id);
            ModelToEntity(supplier, entity);
            _context.supplierEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var supplier = _context.supplierEntities.Find(id);
            _context.supplierEntities.Remove(supplier);
            _context.SaveChanges();
        }
    }
}
