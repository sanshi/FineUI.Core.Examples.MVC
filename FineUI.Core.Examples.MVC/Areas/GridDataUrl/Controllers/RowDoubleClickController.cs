using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridDataUrl.Controllers
{
    [Area("GridDataUrl")]
    public class RowDoubleClickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/RowDoubleClick
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_RowDblClick(int rowIndex, string rowId, string rowText)
        {
            ShowNotify(String.Format("你双击了第 {0} 行，行ID：{1}，姓名：{2}", rowIndex + 1, rowId, rowText));

            return UIHelper.Result();
        }

    }
}