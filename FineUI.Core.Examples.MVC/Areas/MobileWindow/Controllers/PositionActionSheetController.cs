using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileWindow.Controllers
{
    [Area("MobileWindow")]
    public class PositionActionSheetController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileWindow/PositionActionSheet
        public IActionResult Index()
        {
            return View();
        }


    }
}