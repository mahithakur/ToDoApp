using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;

namespace ToDoApp.Service
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }
}
