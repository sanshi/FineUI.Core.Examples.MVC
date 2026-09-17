using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Partial.Controllers
{
    [Area("Partial")]
    public class LayoutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Partial/Partial
        public IActionResult Index()
        {
            return View();
        }
    }
}