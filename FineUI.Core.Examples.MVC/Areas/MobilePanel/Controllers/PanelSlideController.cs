using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobilePanel.Controllers
{
    [Area("MobilePanel")]
    public class PanelSlideController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobilePanel/PanelSlide
        public IActionResult Index()
        {
            return View();
        }


    }
}