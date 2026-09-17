using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonMenuIDController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonMenuID
        public IActionResult Index()
        {
            return View();
        }

    }
}