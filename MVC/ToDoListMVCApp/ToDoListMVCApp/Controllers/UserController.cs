using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListMVCApp.Services;
using ToDoListMVCApp.ViewModels;
using ToDoListMVCApp.Models;
using System.Web.Security;

namespace ToDoListMVCApp.Controllers
{
    public class UserController : Controller
    {
        UserService userService = UserService.GetInstance;

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            AllUsersVM allUsersVM = new AllUsersVM();
            allUsersVM.Users = userService.GetUsers();
            return View(allUsersVM);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserVM userVM)
        {
            if (ModelState.IsValid)
            {
                userService.AddUser(new Users
                {
                    Username = userVM.User.Username,
                    Password = userVM.User.Password,
                    Role = userVM.User.Role,
                });
                return RedirectToAction("LoginUser");
            }
            return View(userVM);
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                foreach (var user in userService.GetUsers())
                {
                    if (loginVM.Username == user.Username && loginVM.Password == user.Password)
                    {
                        FormsAuthentication.SetAuthCookie(loginVM.Username, loginVM.RememberMe);
                        if (user.Role == "Admin")
                        {
                            return RedirectToAction("Index");
                        }
                        return RedirectToAction("Index", "Tasks", new { id = user.ID });
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username and password");
            return View(loginVM);
        }

        public ActionResult DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return RedirectToAction("Index");
        }

        public ActionResult Logout() 
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginUser");
        }
    }
}