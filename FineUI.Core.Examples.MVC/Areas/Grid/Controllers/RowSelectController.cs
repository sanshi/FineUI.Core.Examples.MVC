using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class RowSelectController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/RowSelect
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_RowSelect(string rowId, string rowText, int rowIndex, string columnText, bool isDeselect)
        {
            string typeName = isDeselect ? "取消选中" : "选中";

            ShowNotify(String.Format("你" + typeName + "了第 {0} 行，行ID：{1}，姓名：{2}，列：{3}",
                rowIndex + 1, rowId, rowText, columnText));

            return UIHelper.Result();
        }

    }
}