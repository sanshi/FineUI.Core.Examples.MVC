using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileAnimation.Controllers
{
    [Area("MobileAnimation")]
    public class PopController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileAnimation/Pop
        public IActionResult Index()
        {
            return View();
        }


    }
}