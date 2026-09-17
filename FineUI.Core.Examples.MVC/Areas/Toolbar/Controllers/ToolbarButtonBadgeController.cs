using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class ToolbarButtonBadgeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/ToolbarButtonBadge
        public IActionResult Index()
        {
            return View();
        }


    }
}