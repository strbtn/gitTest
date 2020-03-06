using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitTest.controllers
{
    public class AbcController : Controller
    {
        public IActionResult Index()
        {
            //控制器
            return View();
        }
    }
}