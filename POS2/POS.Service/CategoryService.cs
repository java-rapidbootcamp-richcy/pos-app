using POS.Repository;
using POS.ViewModel;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _context;

        private CategoryModel EntityToModel(CategoryEntity entity)
        {
            CategoryModel result = new CategoryModel();
            result.Id = entity.Id;
            result.CategoryName = entity.CategoryName;
            result.Description = entity.Description;
            return result;
        }

        private void ModelToEntity(CategoryModel model, CategoryEntity entity)
        {
            entity.CategoryName = model.CategoryName;
            entity.Description = model.Description;
        }
        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<CategoryEntity> Get()
        {
            return _context.CategoryEntities.ToList();
        }

        public void Add(CategoryEntity entity)
        {
            _context.CategoryEntities.Add(entity);
            _context.SaveChanges();
        }

        public CategoryModel View(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);
            return EntityToModel(entity);
        }

        public void Update(CategoryModel entity)
        {
            var data = _context.CategoryEntities.Find(entity.Id);
            ModelToEntity(entity, data);
            _context.CategoryEntities.Update(data);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);

            _context.CategoryEntities.Remove(entity);
            _context.SaveChanges();
        }

    }
}