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

        public IEnumerable<Category> GetAllCategories()
        {
            return _db.Categories.ToList();
        }
    }
}
