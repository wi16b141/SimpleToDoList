using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.ViewModels
{
    public class MainViewModel
    {
        public string newTaskDescription { get; set; }
        public ObservableCollection<string> toDoList { get; set; } = new ObservableCollection<string>();

        public MainViewModel()
        {
            toDoList.Add("Some new Task");
        }
    }
}
