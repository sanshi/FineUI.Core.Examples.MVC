using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Partial.Controllers
{
    [Area("Partial")]
    public class PartialController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Partial/Partial
        public IActionResult Index()
        {
            return View();
        }
        
    }
}