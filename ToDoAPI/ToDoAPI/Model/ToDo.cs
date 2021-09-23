using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.Model
{
    public class ToDo
    {
        public int Id { get; set; }
        public string ToDoName { get; set; }
        public bool ToDoStatus { get; set; } = false;
        public string ToDoDescription { get; set; }


    }
}
