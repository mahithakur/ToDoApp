using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Service;

namespace ToDoApp.Web.Controllers
{
    public class TaskController : Controller
    {
        public readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public IActionResult Index()
        {

            List<ToDoApp.Entities.Task> taskList = _taskService.GetAllTasks().ToList();

            var task = taskList.Where(x => x.Id == 1).FirstOrDefault();
            if (task != null)
            {
                task.TaskName = "New task name";
                _taskService.UpdateTask(task);
            }

            List<ToDoApp.Entities.Task> taskList2 = _taskService.GetAllTasks().ToList();
            return View(taskList2);
        }

        [HttpGet]
        public IActionResult DeleteTask()
        {
            return View();
        }

        [Route("Id")]
        public IActionResult DeleteTask(int Id)
        {
            return View(_taskService.DeleteTask(Id));
        }
    }
}
