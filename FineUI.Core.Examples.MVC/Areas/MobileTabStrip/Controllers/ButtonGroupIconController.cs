using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileTabStrip.Controllers
{
    [Area("MobileTabStrip")]
    public class ButtonGroupIconController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileTabStrip/ButtonGroupIcon
        public IActionResult Index()
        {
            return View();
        }


    }
}