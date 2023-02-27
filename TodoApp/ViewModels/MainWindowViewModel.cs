using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Models;

namespace TodoApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }

        public TodoListViewModel List { get; }
    }
}
