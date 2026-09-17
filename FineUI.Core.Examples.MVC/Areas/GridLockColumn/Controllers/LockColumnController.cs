using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridLockColumn.Controllers
{
    [Area("GridLockColumn")]
    public class LockColumnController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridLockColumn/LockColumn
        public IActionResult Index()
        {
            return View();
        }


    }
}