using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string taskname, status;
            int id;
            string y = "y";
            List<Task> listOfTasks = new List<Task>();
            Console.WriteLine("--------- Welcome to the ToDo List App ---------");
            while (y.Equals("y") || y.Equals("Y"))
            {
                Console.WriteLine("\nEnter 1 : to Add Task");
                Console.WriteLine("Enter 2 : to Update Task");
                Console.WriteLine("Enter 3 : to Delete Task");
                Console.WriteLine("Enter 4 : to Display Task list\n");
                Console.Write("Enter your choice ==> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter ID ==> ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Task Name  ==> ");
                        taskname = Console.ReadLine();
                        Console.Write("Enter Task Status (Complete/Pending) ==> ");
                        status = Console.ReadLine();
                        listOfTasks.Add(new Task(id, taskname, DateTime.Now, status));
                        break;
                    case 2:
                        Console.Write("\nEnter id to update a Task ==> ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Task Name  ==> ");
                        taskname = Console.ReadLine();
                        Console.Write("Enter Task Status (Complete/Pending) ==> ");
                        status = Console.ReadLine();
                        Task task = listOfTasks.Where(x => x.ID == id).SingleOrDefault();
                        task.Tasks = taskname.Equals("") ? task.Tasks : taskname;
                        task.CreationDate = DateTime.Now;
                        task.Complete = status.Equals("") ? task.Complete : status;
                        Console.WriteLine("Task Updated..");
                        break;
                    case 3:
                        Console.Write("\nEnter id to delete a Task ==> ");
                        id = int.Parse(Console.ReadLine());
                        listOfTasks.Remove(listOfTasks.Where(x => x.ID == id).SingleOrDefault());
                        Console.WriteLine("Task Deleted..");
                        break;
                    case 4:
                        Console.WriteLine("\n------- Your Task List ------\n");
                        foreach (var item in listOfTasks)
                        {
                            Console.WriteLine("ID           :  " + item.ID);
                            Console.WriteLine("Task         :  " + item.Tasks);
                            Console.WriteLine("Created Date :  " + item.CreationDate);
                            Console.WriteLine("Status       :  " + item.Complete);
                            Console.WriteLine();
                        }
                        break;
                }
                Console.Write("\nPress y for continue! -- ");
                y = Console.ReadLine();
            }
        }
    }
}
