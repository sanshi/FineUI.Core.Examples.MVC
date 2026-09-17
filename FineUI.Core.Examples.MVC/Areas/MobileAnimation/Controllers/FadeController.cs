using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileAnimation.Controllers
{
    [Area("MobileAnimation")]
    public class FadeController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileAnimation/Fade
        public IActionResult Index()
        {
            return View();
        }


    }
}