using ToDoListMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoListMVCApp.Repository
{
    class TasksRepository : ITaskRepository
    {
        public TaskDBContext db;

        public TasksRepository(TaskDBContext db)
        {
            this.db = db;
        }

        public void AddTasks(Tasks tasks)
        {
            db.Tasks.Add(tasks);
            db.SaveChanges();
        }

        public void DeleteTasks(Guid id)
        {
            db.Tasks.Remove(db.Tasks.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditTasks(Tasks tasks)
        {
            Tasks task  = db.Tasks.Where(x => x.ID == tasks.ID).SingleOrDefault();
            task.TaskName = tasks.TaskName;
            task.CreationDate = DateTime.Now;
            task.Status = tasks.Status;
            db.SaveChanges();
        }

        public List<Tasks> GetTasksByUser(Guid id)
        {
            List<Tasks> tasks = db.Tasks.Where(x => x.UsersID == id).ToList();
            foreach (var item in tasks)
            {
                item.SubTasks = db.SubTasks.Where(x => x.TasksID == item.ID).ToList();
            }
            return tasks;
        }

        public Tasks GetTaskByID(Guid id)
        {
            return db.Tasks.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Tasks> GetTasks()
        {
            return db.Tasks.ToList();
        }
    }
}
