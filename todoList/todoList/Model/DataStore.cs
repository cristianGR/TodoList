using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace todoList.Model
{
    class DataStore
    {
        private ObservableCollection<Task> tasks;
    
        public DataStore(){
            tasks = new ObservableCollection<Task>(); 
        }

        public void Add(string nombre) {
            tasks.Add(new Task { Name = nombre });
        }

        public ObservableCollection<Task> Tasks
        {
            get { return tasks; }
        }

    }
}
