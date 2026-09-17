using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridLockColumn.Controllers
{
    [Area("GridLockColumn")]
    public class GroupFieldController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridLockColumn/GroupField
        public IActionResult Index()
        {
            return View();
        }

        

    }
}