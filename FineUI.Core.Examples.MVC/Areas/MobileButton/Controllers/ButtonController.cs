using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileButton.Controllers
{
    [Area("MobileButton")]
    public class ButtonController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileButton/Button
        public IActionResult Index()
        {
            return View();
        }

        

    }
}