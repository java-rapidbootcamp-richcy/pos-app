using Microsoft.EntityFrameworkCore;
using POS.Repository;
using POS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Service
{
    public class OrderService
    {
        private readonly ApplicationDbContext _context;
        private OrderModel EntityToModel(OrderEntity entity)
        {
            OrderModel result = new OrderModel();
            result.Id = entity.Id;
            result.CustomerId = entity.CustomerId;
            result.EmployeeId = entity.EmployeeId;
            result.OrderDate = entity.OrderDate;
            result.RequiredDate = entity.RequiredDate;
            result.ShippedDate = entity.ShippedDate;
            result.ShipVia = entity.ShipVia;
            result.Freight = entity.Freight;
            result.ShipName = entity.ShipName;
            result.ShipAddress = entity.ShipAddress;
            result.ShipCity = entity.ShipCity;
            result.ShipRegion = entity.ShipRegion;
            result.ShipPostalCode = entity.ShipPostalCode;
            result.ShipCountry = entity.ShipCountry;
            return result;
        }

        private void ModelToEntity(OrderModel model, OrderEntity entity)
        {
            entity.CustomerId = model.CustomerId;
            entity.EmployeeId = model.EmployeeId;
            entity.OrderDate = model.OrderDate;
            entity.RequiredDate = model.RequiredDate;
            entity.ShippedDate = model.ShippedDate;
            entity.ShipVia = model.ShipVia;
            entity.Freight = model.Freight;
            entity.ShipName = model.ShipName;
            entity.ShipAddress = model.ShipAddress;
            entity.ShipCity = model.ShipCity;
            entity.ShipRegion = model.ShipRegion;
            entity.ShipPostalCode = model.ShipPostalCode;
            entity.ShipCountry = model.ShipCountry;
        }

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<OrderEntity> Get()
        {
            return _context.ordersEntities.ToList();
        }

        public List<OrderEntity> GetWithOrderDetails()
        {
            return _context.ordersEntities.Include(s => s.orderDetailsEntities).ToList();
        }

        public OrderEntity ViewWithOrderDetails(int? id)
        {
            return _context.ordersEntities.Include(s => s.orderDetailsEntities).FirstOrDefault(s => s.Id == id);
        }

        public void Add(OrderEntity order)
        {
            _context.ordersEntities.Add(order);
            _context.SaveChanges();
        }

        public OrderModel View(int? id)
        {
            var order = _context.ordersEntities.Find(id);
            return EntityToModel(order);
        }

        public void Update(OrderModel order)
        {
            var entity = _context.ordersEntities.Find(order.Id);
            ModelToEntity(order, entity);
            _context.ordersEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.ordersEntities.Find(id);
            _context.ordersEntities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
