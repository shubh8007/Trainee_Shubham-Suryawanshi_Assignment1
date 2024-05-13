using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List_Application
{
     class TaskList
    {

        private List<Task> tasks;

        public TaskList()
        {
            tasks = new List<Task>();
        }

        public void CreateTask(string title, string description)
        {
            Task task = new Task { Title = title, Description = description };
            tasks.Add(task);
            Console.WriteLine("Task created successfully.");
        }

        public void ReadTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Title: {task.Title}, Description: {task.Description}");
            }
        }

        public void UpdateTask(string title, string newTitle, string newDescription)
        {
            Task taskToUpdate = tasks.Find(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (taskToUpdate != null)
            {
                taskToUpdate.Title = newTitle;
                taskToUpdate.Description = newDescription;
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void DeleteTask(string title)
        {
            Task taskToDelete = tasks.Find(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (taskToDelete != null)
            {
                tasks.Remove(taskToDelete);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }
    }
}
