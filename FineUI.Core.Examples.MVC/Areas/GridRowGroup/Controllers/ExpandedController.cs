using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridRowGroup
{
    [Area("GridRowGroup")]
    public class ExpandedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridRowGroup/Expanded
        public IActionResult Index()
        {
            return View();
        }
    }
}