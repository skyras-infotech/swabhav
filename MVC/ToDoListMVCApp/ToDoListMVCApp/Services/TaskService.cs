using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Repository;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Services
{
    public class TaskService
    {
        private static TaskService _taskService;
        private TasksRepository repository = new TasksRepository(new TaskDBContext());

        public static TaskService GetInstance
        {
            get
            {
                if (_taskService == null)
                {
                    _taskService = new TaskService();
                }
                return _taskService;
            }
        }

        public void AddTask(Tasks task)
        {
            repository.AddTasks(task);
        }

        public void DeleteTask(Guid id)
        {
            repository.DeleteTasks(id);
        }

        public List<Tasks> GetTasks()
        {
            return repository.GetTasks();
        }

        public List<Tasks> GetTasksByUser(Guid id)
        {
            return repository.GetTasksByUser(id);
        }

        public Tasks GetTaskByID(Guid id)
        {
            return repository.GetTaskByID(id);
        }

        public void UpdateTask(Tasks task)
        {
            repository.EditTasks(task);
        }
    }
}