using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;
using ToDoApp.Data;
using System.Linq;

namespace ToDoApp.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ToDoAppContext _db;

        public CategoryService(ToDoAppContext db)
        {
            _db = db;
        }

        public bool DeleteCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if (category == null)
                return false;

            _db.Categories.Remove(category);
            _db.SaveChanges();
            return true;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }

        public Category GetById(int id)
        {
           var category = _db.Categories.Find(id);
            if (category == null)
                return null;

            return category;
        }
    }
}
