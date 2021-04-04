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
    public class TasksController : Controller
    {
        TaskService taskService = TaskService.GetInstance;
        public ActionResult Index()
        {
            AllTasksVM allTasksVM = new AllTasksVM();
            allTasksVM.Tasks = taskService.GetTasks();
            return View(allTasksVM);
        }

        public ActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTask(TasksVM tasksVM)
        {
            if (ModelState.IsValid)
            {
                taskService.AddTask(new Tasks
                {
                    TaskName = tasksVM.TaskName,
                    CreationDate = DateTime.Now,
                    Status = tasksVM.Status
                });
                return RedirectToAction("Index");
            }
            return View(tasksVM);
        }

        public ActionResult UpdateTask(int id)
        {
            UpdateTaskVM taskVM = new UpdateTaskVM();
            taskVM.Tasks = taskService.GetTaskByID(id);
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateTask(UpdateTaskVM taskVM)
        {
            if (ModelState.IsValid)
            {
                taskService.UpdateTask(taskVM.Tasks);
                return RedirectToAction("Index");
            }
            return View(taskVM);
        }

        public ActionResult DeleteTask(int id)
        {
            taskService.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}