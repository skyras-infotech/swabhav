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
    public class SubTaskController : Controller
    {
        SubTaskService taskService = SubTaskService.GetInstance;
        public ActionResult Index(Guid id,Guid userid)
        {
            AllSubTasksVM subTasksVM = new AllSubTasksVM();
            subTasksVM.SubTasks = taskService.GetSubTasks(id);
            subTasksVM.TaskID = id;
            subTasksVM.UserID = userid;
            return View(subTasksVM);
        }

       public ActionResult AddSubTask(Guid id, Guid userid,SubTasksVM tasksVM)
       {
            tasksVM.TaskID = id;
            tasksVM.UserID = userid;
            return View(tasksVM);
       }

        [HttpPost]
        public ActionResult AddSubTask(SubTasksVM tasksVM,Guid id,Guid userid)
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
                return RedirectToAction("Index", new { id = id, userid = userid });
            }
            return View(tasksVM);
        }

        public ActionResult UpdateSubTask(Guid id,Guid taskid,Guid userid)
        {
            UpdateSubTaskVM taskVM = new UpdateSubTaskVM();
            taskVM.SubTask = taskService.GetSubTaskByID(id);
            taskVM.TaskID = taskid;
            taskVM.UserID = userid;
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateSubTask(UpdateSubTaskVM taskVM, Guid userid)
        {
            if (ModelState.IsValid)
            {
                taskService.UpdateSubTask(taskVM.SubTask);
                return RedirectToAction("Index", new { id = taskVM.TaskID, userid = userid });
            }
            return View(taskVM);
        }

        public ActionResult DeleteSubTask(Guid id, Guid taskid, Guid userid)
        {
            taskService.DeleteSubTask(id);
            return RedirectToAction("Index", new { id = taskid, userid = userid});
        }
    }
}