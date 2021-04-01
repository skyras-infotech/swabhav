﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WelcomeMVCApp.Models;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() 
        { 
        }

        public ActionResult Index() 
        {
            return View();
        }

        public ActionResult Hello() 
        {
            return View();
        }

        public ActionResult WelcomeURL(string name) 
        {
            ViewBag.msg = name;
            return View();
        }

        public ActionResult WelcomeURLPrint5Times(string name)
        {
            ViewBag.msg = name;
            return View();
        }

        public ActionResult PrintNameFromTextbox(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult PrintNameFromTextbox5Times(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult TwoTextBox(string id,string username)
        {
            ViewBag.username = username;
            ViewBag.id = id;
            return View();
        }

        public ActionResult FetchColorFromDropdown(string colors)
        {
            ViewBag.colors = colors;
            return View();
        }

        public ActionResult FetchDeptNoFromDropdown(FormCollection collection)
        {
            if (collection.Count != 0)
            {
                ViewData["Department"] = collection[0];
            }
            return View();
        }

        public ActionResult GetDataFromModel()
        {
            return View();
        }

        public ActionResult PrintDetailsOfUser(Users users)
        {
            return View(users);
        }
    }
}