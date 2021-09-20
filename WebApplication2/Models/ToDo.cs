using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyProject1.Models
{
    public class ToDo
    {
        public string ToDoName { get; set; }
        public int ToDoID { get; set; }
        public bool ToDoStatus { get; set; }
        public string ToDoDescription { get; set; }
        public DateTime ToDoCreationDate { get; set; }
        public DateTime ToDoDueDate { get; set; }


    }
}
