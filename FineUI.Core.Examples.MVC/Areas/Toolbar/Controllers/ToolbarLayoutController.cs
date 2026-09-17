using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class ToolbarLayoutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/ToolbarLayout
        public IActionResult Index()
        {
            return View();
        }

       
    }
}