using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Basic.Controllers
{
    [Area("Basic")]
    public class MainController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Basic/Main
        public IActionResult Index()
        {
            return View();
        }

    }
}