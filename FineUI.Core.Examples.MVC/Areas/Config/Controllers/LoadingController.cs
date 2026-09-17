using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Config.Controllers
{
    [Area("Config")]
    public class LoadingController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Config/Loading
        public IActionResult Index()
        {
            return View();
        }

    }
}