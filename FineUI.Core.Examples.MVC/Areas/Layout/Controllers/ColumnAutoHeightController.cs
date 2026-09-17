using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Layout.Controllers
{
    [Area("Layout")]
    public class ColumnAutoHeightController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Layout/ColumnAutoHeight
        public IActionResult Index()
        {
            return View();
        }


    }
}