using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Block.Controllers
{
	[Area("Block")]
    public class SameWidthController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Block/SameWidth
        public IActionResult Index()
        {
            return View();
        }

        
    }
}