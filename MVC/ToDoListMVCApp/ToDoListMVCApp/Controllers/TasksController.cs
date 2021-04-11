using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListMVCApp.Services;
using ToDoListMVCApp.ViewModels;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        TaskService taskService = TaskService.GetInstance;

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Index(Guid id)
        {
            AllTasksVM allTasksVM = new AllTasksVM();
            allTasksVM.Tasks = taskService.GetTasksByUser(id);
            allTasksVM.UserID = id;
            return View(allTasksVM);
        }

        public ActionResult AddTask(Guid id, TasksVM tasksVM)
        {
            tasksVM.UserID = id;
            return View(tasksVM);
        }

        [HttpPost]
        public ActionResult AddTask(TasksVM tasksVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                taskService.AddTask(new Tasks
                {
                    TaskName = tasksVM.TaskName,
                    CreationDate = DateTime.Now,
                    Status = tasksVM.Status,
                    UsersID = id
                });
                return RedirectToAction("Index", new { id = id });
            }
            return View(tasksVM);
        }

        public ActionResult UpdateTask(Guid id, Guid userid)
        {
            UpdateTaskVM taskVM = new UpdateTaskVM();
            taskVM.Tasks = taskService.GetTaskByID(id);
            taskVM.UserID = userid;
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateTask(UpdateTaskVM taskVM)
        {
            if (ModelState.IsValid)
            {
                taskService.UpdateTask(taskVM.Tasks);
                return RedirectToAction("Index", new { id = taskVM.UserID });
            }
            return View(taskVM);
        }

        public ActionResult DeleteTask(Guid id, Guid userid)
        {
            taskService.DeleteTask(id);
            return RedirectToAction("Index", new { id = userid });
        }
    }
}