using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class RowDataBoundCellClassController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/RowDataBoundCellClass
        public IActionResult Index()
        {
            return View();
        }


    }
}