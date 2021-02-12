using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Entities;

namespace ToDoApp.Service
{
    public interface ITaskService
    {
        void AddTask(Task task);
        IEnumerable<Task> GetAllTasks();
        Task UpdateTask(Task task);
        bool DeleteTask(int Id);
    }
}
