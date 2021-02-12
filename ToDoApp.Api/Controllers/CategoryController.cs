using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Service;

namespace ToDoApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Entities.Category> Get()
        {
            var categoryList = _categoryService.GetAllCategories().ToList();

            return categoryList;
        }

        [HttpGet("{id}")]
        public Entities.Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _categoryService.DeleteCategory(id);
        }
    }
}
