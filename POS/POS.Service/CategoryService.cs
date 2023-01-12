using POS.DataContext;

namespace POS.Service
{
    public class CategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public List<Categories> GetCategories()
        {
            return _context.CategoryEntities.ToList();
        }
    }
}