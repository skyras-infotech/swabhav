using ToDoListMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoListMVCApp.Repository
{
    class SubTasksRepository : ISubTaskRepository
    {
        public TaskDBContext db;

        public SubTasksRepository(TaskDBContext db)
        {
            this.db = db;
        }

        public void AddSubTasks(SubTask tasks)
        {
            db.SubTasks.Add(tasks);
            db.SaveChanges();
        }

        public void DeleteSubTasks(Guid id)
        {
            db.SubTasks.Remove(db.SubTasks.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditSubTasks(SubTask tasks)
        {
            SubTask task  = db.SubTasks.Where(x => x.ID == tasks.ID).SingleOrDefault();
            task.SubTaskName = tasks.SubTaskName;
            task.CreationDate = DateTime.Now;
            task.Status = tasks.Status;
            db.SaveChanges();
        }

        public SubTask GetSubTaskByID(Guid id)
        {
            return db.SubTasks.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<SubTask> GetSubTasks(Guid id)
        {
            return db.SubTasks.Where(x => x.Tasks.ID == id).ToList();
        }
    }
}
