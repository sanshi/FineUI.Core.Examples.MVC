using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.FormLayout.Controllers
{
    [Area("FormLayout")]
    public class LayoutPanelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormLayout/LayoutPanel
        public IActionResult Index()
        {
            return View();
        }

       

    }
}