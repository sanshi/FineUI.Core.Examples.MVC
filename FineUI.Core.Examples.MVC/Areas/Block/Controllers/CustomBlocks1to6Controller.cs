using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Block.Controllers
{
    [Area("Block")]
    public class CustomBlocks1to6Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Block/CustomBlocks1to6
        public IActionResult Index()
        {
            return View();
        }

        
    }
}