using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List_Application
{
   class Task

    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Task() { 
        }
        public Task(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
