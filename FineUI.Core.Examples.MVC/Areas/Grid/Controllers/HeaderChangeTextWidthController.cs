using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class HeaderChangeTextWidthController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/HeaderWrap
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            PageContext.RegisterStartupScript(String.Format("changeColumnTitleAndWidth('入学年份（已修改）', 200);"));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            PageContext.RegisterStartupScript(String.Format("changeColumnTitleAndWidth('入学年份', 120);"));

            return UIHelper.Result();
        }

    }
}