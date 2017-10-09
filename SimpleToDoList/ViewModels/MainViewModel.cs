using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using SimpleToDoList.Models;

namespace SimpleToDoList.ViewModels
{
    public class MainViewModel
    {
        public string NewTaskDescription { get; set; }

        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value;  }
        }

        public MainViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            ToDoList.Add(new ToDoVM("buy whatever", false));
            ToDoList.Add(new ToDoVM("buy something else", true));
        }
    }
}
