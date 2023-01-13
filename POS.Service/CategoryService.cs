using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            return _context.categoryEntities.ToList();
        }

        public void Add(CategoryEntity categoryEntity)
        {
            _context.categoryEntities.Add(categoryEntity);
            _context.SaveChanges();
        }

        public CategoryModel View(int? id)
        {
            var category = _context.categoryEntities.Find(id);
            return EntityToModel(category);
        }

        public void Update(CategoryModel category)
        {
            var entity = _context.categoryEntities.Find(category.Id);
            ModelToEntity(category, entity);
            _context.categoryEntities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int? id)
        {
            var supplier = _context.categoryEntities.Find(id);

            _context.categoryEntities.Remove(supplier);
            _context.SaveChanges();
        }

    }

}

