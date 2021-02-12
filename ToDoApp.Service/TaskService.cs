using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoApp.Data;
using ToDoApp.Entities;

namespace ToDoApp.Service
{
    public class TaskService : ITaskService
    {
        private readonly ToDoAppContext _db;

        public TaskService(ToDoAppContext db)
        {
            _db = db;
        }
        public void AddTask(Task task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        public bool DeleteTask(int Id)
        {
            var task = _db.Tasks.Find(Id);
            if (task == null)
                return false;

            _db.Tasks.Remove(task);
            _db.SaveChanges();
            return true;
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _db.Tasks.ToList();
        }

        public Task UpdateTask(Task task)
        {
            _db.Entry(task).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();

            return task;
        }
    }
}
