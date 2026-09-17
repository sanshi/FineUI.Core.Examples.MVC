using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class RowExpanderController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/RowExpander
        public IActionResult Index()
        {
            return View();
        }


    }
}