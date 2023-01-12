using POS.Repository;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _context;
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

        public CategoryEntity View(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);
            return entity;
        }

        public void Update(CategoryEntity entity)
        {
            _context.CategoryEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var entity = View(id);

            _context.CategoryEntities.Remove(entity);
            _context.SaveChanges();
        }

    }
}