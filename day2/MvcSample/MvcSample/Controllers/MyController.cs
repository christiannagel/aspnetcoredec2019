using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSample.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Hello(string id)
        {
            return $"<h1>Hello, {id}</h1>";
        }

        public int Add(int x, int y) => x + y;

        public IActionResult PassDataToView()
        {
            // ViewData["MyData"] = 42;
            ViewBag.MyData = 42;
            return View();
        }

        public IActionResult MyPartialView()
        {
            return PartialView();
        }



    }
}
