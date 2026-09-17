using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class PagingServerController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/Paging
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_PageIndexChanged(int pageIndex)
        {
            UIHelper.Grid("Grid1").LoadPageData(pageIndex);

            return UIHelper.Result();
        }

    }
}