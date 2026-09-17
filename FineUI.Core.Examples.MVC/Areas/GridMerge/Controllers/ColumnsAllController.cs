using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridMerge.Controllers
{
    [Area("GridMerge")]
    public class ColumnsAllController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridMerge/ColumnsAll
        public IActionResult Index()
        {
            return View();
        }


    }
}