using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.Models
{
    public class ToDo
    {
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private bool isDone;
        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }

        public ToDo(string description, bool isDone)
        {
            this.description = description;
            this.isDone = isDone;
        }

        

    }
}
