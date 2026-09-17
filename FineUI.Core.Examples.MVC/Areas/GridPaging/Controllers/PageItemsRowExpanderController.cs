using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class PageItemsRowExpanderController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/PageItemsRowExpander
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowRowExpanders_Click(bool expanded)
        {
            var grid1 = UIHelper.Grid("Grid1");
            if (expanded)
            {
                grid1.CollapseRowExpanders();
            }
            else
            {
                grid1.ExpandRowExpanders();
            }

            return UIHelper.Result();
        }

    }
}