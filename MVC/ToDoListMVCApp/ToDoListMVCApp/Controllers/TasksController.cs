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
        public ActionResult Index(int id)
        {
            AllTasksVM allTasksVM = new AllTasksVM();
            allTasksVM.Tasks = taskService.GetTasksByUser(id);
            allTasksVM.UserID = id;
            return View(allTasksVM);
        }

        public ActionResult AddTask(int id, TasksVM tasksVM)
        {
            tasksVM.UserID = id;
            return View(tasksVM);
        }

        [HttpPost]
        public ActionResult AddTask(TasksVM tasksVM,int id)
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

        public ActionResult UpdateTask(int id, int userid)
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

        public ActionResult DeleteTask(int id,int userid)
        {
            taskService.DeleteTask(id);
            return RedirectToAction("Index", new { id = userid });
        }
    }
}