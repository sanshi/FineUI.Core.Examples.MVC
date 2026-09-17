using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
	[Area("TabStrip")]
    public class BeforehideFConfirmController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/BeforehideFConfirm
        public IActionResult Index()
        {
            return View();
        }

    }
}