using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public IEnumerable<ToDoApp.Entities.Task> Get()
        {
            return _taskService.GetAllTasks().ToList();
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaskController>
        [HttpPost]
        public void Post([FromBody] ToDoApp.Entities.Task task)
        {
            _taskService.AddTask(task);
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToDoApp.Entities.Task task)
        {
            _taskService.UpdateTask(task);
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _taskService.DeleteTask(id);
        }
    }
}
