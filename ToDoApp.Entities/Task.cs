using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string TaskName { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
