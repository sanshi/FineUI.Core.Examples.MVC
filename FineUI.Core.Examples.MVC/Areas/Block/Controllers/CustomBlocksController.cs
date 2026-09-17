using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Block.Controllers
{
	[Area("Block")]
    public class CustomBlocksController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Block/CustomBlocks
        public IActionResult Index()
        {
            return View();
        }

        
    }
}