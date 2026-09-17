using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Window.Controllers
{
    [Area("Window")]
    public class HeightAutoSizeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Window/HeightAutoSize
        public IActionResult Index()
        {
            return View();
        }


    }
}