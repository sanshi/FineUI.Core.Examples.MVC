using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class ClearSelectionBeforePagingDetailsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/ClearSelectionBeforePagingDetails
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