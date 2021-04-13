using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ContactDynamicMVC.ViewModels;

namespace ContactDynamicMVC.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            IEnumerable<AllContactVM> allContacts = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44333/api/");

                //Http Get
                var responseTask = client.GetAsync("home");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AllContactVM>>();
                    readTask.Wait();
                    allContacts = readTask.Result;
                }
                else
                {
                    allContacts = Enumerable.Empty<AllContactVM>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(allContacts);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(AddContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44333/api/");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<AddContactVM>("home", contactVM);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            }
            return View(contactVM);
        }

        public ActionResult UpdateContact(int id)
        {
            EditContactVM editContact = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44333/api/");

                //HTTP GET
                var responseTask = client.GetAsync("home/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<EditContactVM>();
                    readTask.Wait();

                    editContact = readTask.Result;
                }
            }
            return View(editContact);
        }

        [HttpPost]
        public ActionResult UpdateContact(EditContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44333/api/");

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync<EditContactVM>("home", contactVM);
                    putTask.Wait();

                    var result = putTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            }
            return View(contactVM);
        }

        public ActionResult DeleteContact(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44333/api/");

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("home/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }
    }
}