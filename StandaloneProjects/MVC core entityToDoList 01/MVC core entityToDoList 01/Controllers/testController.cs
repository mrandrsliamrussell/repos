using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_core_entityToDoList_01.Models;

namespace MVC_core_entityToDoList_01.Controllers
{
    public class testController : Controller
    {
       
        public IActionResult Index()
        {
            var instance = new lists();
            instance.stringList = new List<string>() { "one", "two", "three" };

            var instance2 = new lists();
            instance2.intList = new List<int>() { 1, 2, 3 };
            return View(instance);
        }
    }
}