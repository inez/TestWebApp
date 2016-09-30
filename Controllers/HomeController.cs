using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;
using TestWebApp.ViewModels;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult SimpleForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleForm(UserVM userVM)
        {
            if ( userVM.Name != null ) {
                var context = new TestDbContext();
                context.Database.EnsureCreated(); // create database

                var user = new User { Name = userVM.Name };
                context.Add(user);
                context.SaveChanges();
            }
            return View();
        }
    }
}
