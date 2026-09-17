using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Window.Controllers
{
    [Area("Window")]
    public class MaximizedScriptController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Window/MaximizedScript
        public IActionResult Index()
        {
            return View();
        }


    }
}