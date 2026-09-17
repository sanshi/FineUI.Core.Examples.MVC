using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileButton.Controllers
{
    [Area("MobileButton")]
    public class ButtonGroupController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileButton/ButtonGroup
        public IActionResult Index()
        {
            return View();
        }


    }
}