using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class RowDoubleClickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/RowDoubleClick
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_RowDblClick(string rowId, string rowText, int rowIndex, string columnText)
        {
            ShowNotify(String.Format("你双击了第 {0} 行，行ID：{1}，姓名：{2}，列：{3}",
                rowIndex + 1, rowId, rowText, columnText));

            return UIHelper.Result();
        }

    }
}