using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyProject1.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public int TaskID { get; set; }
        public bool TaskStatus { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskCreationDate { get; set; }
        public DateTime TaskDueDate { get; set; }


    }
}
