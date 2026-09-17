using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileTabStrip.Controllers
{
    [Area("MobileTabStrip")]
    public class AnimationController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileTabStrip/Animation
        public IActionResult Index()
        {
            return View();
        }


    }
}