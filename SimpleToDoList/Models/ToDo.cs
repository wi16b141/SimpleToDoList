using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.Models
{
    public class ToDo
    {
        public string Description { get; set; }
        public bool isDone { get; set; }

        public ToDo(string description, bool isDone)
        {
            Description = description;
            this.isDone = isDone;
        }

    }
}
