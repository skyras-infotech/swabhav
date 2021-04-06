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

        public void DeleteTasks(int id)
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

        public List<Tasks> GetTasksByUser(int id)
        {
            return db.Tasks.Where(x => x.UsersID == id).ToList();
        }

        public Tasks GetTaskByID(int id)
        {
            return db.Tasks.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Tasks> GetTasks()
        {
            return db.Tasks.ToList();
        }
    }
}
