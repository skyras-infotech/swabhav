using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Repository
{
    interface ISubTaskRepository
    {
        List<SubTask> GetSubTasks(Guid id);
        void AddSubTasks(SubTask tasks);
        void EditSubTasks(SubTask tasks);
        void DeleteSubTasks(Guid id);
        SubTask GetSubTaskByID(Guid id);
    }
}
