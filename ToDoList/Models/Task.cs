using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    class Task
    {
        public string TaskText { get; set; }
        public bool Checked { get; set; }

        public Task(string task)
        {
            TaskText = task;
            Checked = false;
        }
    }
}
