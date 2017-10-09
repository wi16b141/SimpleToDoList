using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using SimpleToDoList.Commands;
using SimpleToDoList.Models;

namespace SimpleToDoList.ViewModels
{
    public class MainViewModel
    {
        public string NewTaskDescription { get; set; }

        private RelayCommand addBtnClickedCommand;

        public RelayCommand AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }

        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value;  }
        }

        public MainViewModel()
        {
            AddBtnClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            LoadData();
        }

        private bool CanExecute()
        {
            return true;
        }

        private void AddButtonClicked()
        {
            if(NewTaskDescription != null) {
                ToDoList.Add(new ToDoVM(NewTaskDescription, false));
            }
        }

        private void LoadData()
        {
            ToDoList.Add(new ToDoVM("buy whatever", false));
            ToDoList.Add(new ToDoVM("buy something else", true));
        }
    }
}
