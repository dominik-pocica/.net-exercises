using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestRepository repository;

        public TestController(ITestRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public string StringValue()
        {
            return "Hello World!";
        }
        public IActionResult RedirectToGoogle()
        {
            return Redirect("http://www.google.com/");
        }
        public IActionResult GetJson()
        {
            return Json(new { Name = "Jan", Surname = "Kowalski" });
        }
        public IActionResult TestModel()
        {
            var model = repository.GetItems();
            return View(model);
        }
    }
}