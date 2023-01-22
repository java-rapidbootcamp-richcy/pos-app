using POS.Repository;
using POS.ViewModel;

namespace POS.Service
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeModel EntityToModel(EmployeeEntity employeeEntity)
        {
            EmployeeModel result = new EmployeeModel();
            result.Id = employeeEntity.Id;
            result.LastName = employeeEntity.LastName;
            result.FirstName = employeeEntity.FirstName;
            result.Title = employeeEntity.Title;
            result.TitleOfCourtesy = employeeEntity.TitleOfCourtesy;
            result.BirthDate = employeeEntity.BirthDate;
            result.HireDate = employeeEntity.HireDate;
            result.Address = employeeEntity.Address;
            result.City = employeeEntity.City;
            result.Region = employeeEntity.Region;
            result.PostalCode = employeeEntity.PostalCode;
            result.Country = employeeEntity.Country;
            result.HomePhone = employeeEntity.HomePhone;
            result.Extension = employeeEntity.Extension;
            result.Notes = employeeEntity.Notes;
            result.ReportsTo = employeeEntity.ReportsTo;
            result.PhotoPath = employeeEntity.PhotoPath;
            return result;
        }
        public void ModelToEntity(EmployeeModel model, EmployeeEntity entity)
        {
            entity.LastName = model.LastName;
            entity.FirstName = model.FirstName;
            entity.Title = model.Title;
            entity.TitleOfCourtesy = model.TitleOfCourtesy;
            entity.BirthDate = model.BirthDate;
            entity.HireDate = model.HireDate;
            entity.Address = model.Address;
            entity.City = model.City;
            entity.Region = model.Region;
            entity.PostalCode = model.PostalCode;
            entity.Country = model.Country;
            entity.HomePhone = model.HomePhone;
            entity.Extension = model.Extension;
            entity.Notes = model.Notes;
            entity.ReportsTo = model.ReportsTo;
            entity.PhotoPath = model.PhotoPath;
        }

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<EmployeeEntity> Get()
        {
            return _context.employeesEntities.ToList();
        }

        public void Add(EmployeeEntity employee)
        {
            _context.employeesEntities.Add(employee);
            _context.SaveChanges();
        }

        public EmployeeModel View(int? id)
        {
            var employee = _context.employeesEntities.Find(id);
            return EntityToModel(employee);
        }

        public void Update(EmployeeModel employee)
        {
            var entity = _context.employeesEntities.Find(employee.Id);
            ModelToEntity(employee, entity);
            _context.employeesEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var employee = _context.employeesEntities.Find(id);
            _context.employeesEntities.Remove(employee);
            _context.SaveChanges();
        }
    }
}