using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class EventOnOffController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/EventOnOff
        public IActionResult Index()
        {
            return View();
        }


    }
}