using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class ShipperService
    {
        private readonly ApplicationDbContext _context;

        public ShipperService(ApplicationDbContext context)
        {
            _context = context;
        }

        private ShipperModel EntityToModel(ShipperEntity entity)
        {
            var model = new ShipperModel();
            model.Id = entity.Id;
            model.CompanyName = entity.CompanyName;
            model.Phone = entity.Phone;
            return model;
        }

        private void ModelToEntity(ShipperModel model, ShipperEntity entity)
        {
            entity.CompanyName = model.CompanyName;
            entity.Phone = model.Phone;
        }

        public List<ShipperEntity> Get()
        {
            return _context.shipperEntities.ToList();
        }

        public void Add(ShipperEntity newShipper)
        {
            _context.shipperEntities.Add(newShipper);
            _context.SaveChanges();
        }

        public ShipperModel View(int? id)
        {
            var shipper = _context.shipperEntities.Find(id);
            return EntityToModel(shipper);
        }

        public void Update(ShipperModel shipper)
        {
            var entity = _context.shipperEntities.Find(shipper.Id);
            ModelToEntity(shipper, entity);
            _context.shipperEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.shipperEntities.Find(id);

            _context.shipperEntities.Remove(entity);
            _context.SaveChanges();
        }
    }

}