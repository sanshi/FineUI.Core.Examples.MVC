using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Layout.Controllers
{
    [Area("Layout")]
    public class ColumnScrollBarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Layout/ColumnScrollBar
        public IActionResult Index()
        {
            return View();
        }


    }
}