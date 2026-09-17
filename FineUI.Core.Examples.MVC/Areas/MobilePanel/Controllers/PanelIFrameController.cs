using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobilePanel.Controllers
{
    [Area("MobilePanel")]
    public class PanelIFrameController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobilePanel/PanelIFrame
        public IActionResult Index()
        {
            return View();
        }


    }
}