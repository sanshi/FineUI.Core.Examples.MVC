using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuHideOnClickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/MenuHideOnClick
        public IActionResult Index()
        {
            return View();
        }

       
    }
}