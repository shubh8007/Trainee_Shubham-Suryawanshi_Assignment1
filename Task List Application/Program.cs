
namespace Task_List_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Task List Application");
                Console.WriteLine("1. Create a task");
                Console.WriteLine("2. Read tasks");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the title of the task: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the description of the task: ");
                        string description = Console.ReadLine();
                        taskList.CreateTask(title, description);
                        
                        break;
                    case 2:
                        taskList.ReadTasks();

                        
                        break;
                    case 3:
                        Console.Write("Enter the title of the task you want to update: ");
                        string titleToUpdate = Console.ReadLine();
                        Console.Write("Enter the new title of the task: ");
                        string newTitle = Console.ReadLine();
                        Console.Write("Enter the new description of the task: ");
                        string newDescription = Console.ReadLine();
                        taskList.UpdateTask(titleToUpdate, newTitle, newDescription);

                       
                        break;
                    case 4:
                        Console.Write("Enter the title of the task you want to delete: ");
                        string titleToDelete = Console.ReadLine();
                        taskList.DeleteTask(titleToDelete);


                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");

                        break;
                }
            }
        }
    }
}