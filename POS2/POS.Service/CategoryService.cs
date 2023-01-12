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
            return _context.categoryEntities.ToList();
        }

        public void Add(CategoryEntity category)
        {
            _context.categoryEntities.Add(category);
            _context.SaveChanges();
        }

        public CategoryEntity View(int? id)
        {
            var category = _context.categoryEntities.Find(id);
            return category;
        }

        public void Update(CategoryEntity category)
        {
            _context.categoryEntities.Update(category);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var category = View(id);

            _context.categoryEntities.Remove(category);
            _context.SaveChanges();
        }

    }
}