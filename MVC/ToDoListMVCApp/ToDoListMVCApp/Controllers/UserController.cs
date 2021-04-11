using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoListMVCApp.Services;
using ToDoListMVCApp.ViewModels;
using ToDoListMVCApp.Models;
using System.Web.Security;
using CaptchaMvc.HtmlHelpers;

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

        public ActionResult Start()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Tasks");
            }
            return View();
        }

        public ActionResult AddUser()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Tasks");
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(UserVM userVM)
        {
            if (ModelState.IsValid && this.IsCaptchaValid(""))
            {
                userService.AddUser(new Users
                {
                    Username = userVM.User.Username,
                    Password = userVM.User.Password,
                    Role = userVM.User.Role,
                });
                return RedirectToAction("LoginUser");
            }
            else
            {
                ViewBag.ErrorMessage = "Captcha is not valid";
            }
            return View(userVM);
        }

        public ActionResult LoginUser()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Home", "Tasks");
            }
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(LoginVM loginVM)
        {
            if (ModelState.IsValid && this.IsCaptchaValid(""))
            {
                foreach (var user in userService.GetUsers())
                {
                    if (loginVM.Username == user.Username && loginVM.Password == user.Password)
                    {
                        FormsAuthentication.SetAuthCookie(user.Username + "," + user.ID, loginVM.RememberMe);
                        if (loginVM.LoginType == "Admin")
                        {
                            return RedirectToAction("Index");
                        }
                        return RedirectToAction("Home", "Tasks");
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid username and password");
                ViewBag.ErrorMessage = "Captcha is not valid";
            }
            return View(loginVM);
        }

        public ActionResult DeleteUser(Guid id)
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