using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Config.Controllers
{
    [Area("Config")]
    public class IconsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Config/Icons
        public IActionResult Index()
        {
            return View();
        }

    }
}