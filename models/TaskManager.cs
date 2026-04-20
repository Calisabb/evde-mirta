using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_practice.models
{
    internal class TaskManager
    {
        public List<Task> tasks { get; set; } = new List<Task>();

        public void AddTask(Task task)
        { 
            tasks.Add(task);      
        }

        public List<Task> ShowAllTasks()
        { 
            return tasks;
        }

        public void RemoveTask(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Id == id)
                { 
                    tasks.Remove(task);
                    break;
                }
            }
        
        }


    }
}
