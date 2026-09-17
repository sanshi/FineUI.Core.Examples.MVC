using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridRowHeight.Controllers
{
    [Area("GridRowHeight")]
    public class GridFixedRowHeightController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/Grid
        public IActionResult Index()
        {
            return View();
        }



    }
}