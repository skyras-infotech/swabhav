using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Repository
{
    interface ITaskRepository
    {
        List<Tasks> GetTasks();
        List<Tasks> GetTasksByUser(Guid id);
        void AddTasks(Tasks tasks);
        void EditTasks(Tasks tasks);
        void DeleteTasks(Guid id);
        Tasks GetTaskByID(Guid id);
    }
}
