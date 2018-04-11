﻿using Dryv.Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dryv.Demo.Controllers
{
    public class ExamplesController : Controller
    {
        [HttpPost]
        public IActionResult Example1(Model1 model) => this.View("example1.partial", model);

        [HttpPost]
        public IActionResult Example2(Model2 model) => this.View("example2.partial", model);

        [HttpPost]
        public IActionResult Example3(Model3 model) => this.View("example3.partial", model);

        [HttpPost]
        public IActionResult Example4(Model4 model) => this.View("example4.partial", model);

        [HttpPost]
        public IActionResult Example4(Model6 model) => this.View("example6.partial", model);

        [HttpPost]
        public IActionResult Example5(Model5 model) => this.View("example5.partial", model);

        public IActionResult Index()
        {
            return this.View();
        }
    }
}