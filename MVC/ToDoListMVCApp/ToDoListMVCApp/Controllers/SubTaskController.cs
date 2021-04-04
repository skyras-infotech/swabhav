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
    public class SubTaskController : Controller
    {
        SubTaskService taskService = SubTaskService.GetInstance;
        public ActionResult Index(int id)
        {
            AllSubTasksVM subTasksVM = new AllSubTasksVM();
            subTasksVM.SubTasks = taskService.GetSubTasks(id);
            subTasksVM.TaskID = id;
            return View(subTasksVM);
        }

       public ActionResult AddSubTask(int id,SubTasksVM tasksVM)
       {
            tasksVM.TaskID = id;
            return View(tasksVM);
       }

        [HttpPost]
        public ActionResult AddSubTask(SubTasksVM tasksVM,int id)
        {
            if (ModelState.IsValid)
            {
                taskService.AddSubTask(new SubTask
                {
                    SubTaskName = tasksVM.SubTask.SubTaskName,
                    CreationDate = DateTime.Now,
                    TasksID = id,
                    Status = tasksVM.SubTask.Status
                });
                return RedirectToAction("Index", new { id = id});
            }
            return View(tasksVM);
        }

        public ActionResult UpdateSubTask(int id,int taskid)
        {
            UpdateSubTaskVM taskVM = new UpdateSubTaskVM();
            taskVM.SubTask = taskService.GetSubTaskByID(id);
            taskVM.TaskID = taskid;
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateSubTask(UpdateSubTaskVM taskVM)
        {
            if (ModelState.IsValid)
            {
                taskService.UpdateSubTask(taskVM.SubTask);
                return RedirectToAction("Index", new { id = taskVM.TaskID });
            }
            return View(taskVM);
        }

        public ActionResult DeleteSubTask(int id, int taskid)
        {
            taskService.DeleteSubTask(id);
            return RedirectToAction("Index", new { id = taskid});
        }
    }
}