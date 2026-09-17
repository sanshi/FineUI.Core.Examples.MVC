using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
	[Area("TabStrip")]
    public class BeforehideController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/Beforehide
        public IActionResult Index()
        {
            return View();
        }

    }
}