using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class HeaderDisableMenuController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/HeaderDisableMenu
        public IActionResult Index()
        {
            return View();
        }


    }
}