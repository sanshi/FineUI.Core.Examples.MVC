using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class CheckFieldRadioController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/CheckFieldRadio
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