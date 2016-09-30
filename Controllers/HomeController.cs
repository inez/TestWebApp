using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new TestDbContext();
            context.Database.EnsureCreated(); // create database

            var user = new User { Name = "Test: " + DateTime.Now.ToString() };
            context.Add(user);
            context.SaveChanges();

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
    }
}
