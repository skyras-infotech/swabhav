using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Repository;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Services
{
    public class SubTaskService
    {
        private static SubTaskService _taskService;
        private SubTasksRepository repository = new SubTasksRepository(new TaskDBContext());

        public static SubTaskService GetInstance
        {
            get
            {
                if (_taskService == null)
                {
                    _taskService = new SubTaskService();
                }
                return _taskService;
            }
        }

        public void AddSubTask(SubTask task)
        {
            repository.AddSubTasks(task);
        }

        public void DeleteSubTask(Guid id)
        {
            repository.DeleteSubTasks(id);
        }

        public List<SubTask> GetSubTasks(Guid id)
        {
            return repository.GetSubTasks(id);
        }

        public SubTask GetSubTaskByID(Guid id)
        {
            return repository.GetSubTaskByID(id);
        }

        public void UpdateSubTask(SubTask task)
        {
            repository.EditSubTasks(task);
        }
    }
}