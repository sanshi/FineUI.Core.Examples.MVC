using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/Menu
        public IActionResult Index()
        {
            return View();
        }

       
    }
}