using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileWindow.Controllers
{
    [Area("MobileWindow")]
    public class PositionController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileWindow/Position
        public IActionResult Index()
        {
            return View();
        }


    }
}