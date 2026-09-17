using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class CheckFieldDisableSomeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/CheckFieldDisableSome
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click()
        {
			

            return UIHelper.Result();
        }

    }
}