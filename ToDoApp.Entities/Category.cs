using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
