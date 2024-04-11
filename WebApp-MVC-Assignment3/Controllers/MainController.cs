using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//custome controller created manually
namespace WebApp_MVC_Assignment3.Controllers
{
    public class MainController : Controller
    {
       //adding the methods for each page
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutPage()
        {
            return View();
        }

        public IActionResult Terms()
        {
            return View();
        }
    }
}

