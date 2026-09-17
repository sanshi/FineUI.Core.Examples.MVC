using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class CheckFieldPostBackController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/CheckFieldPostBack
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_CheckFieldChanged(string rowId, string rowText, bool isChecked)
        {
            ShowNotify(String.Format("你点击了的行ID：{0}，姓名：{1}，是否在校：{2}", rowId, rowText, isChecked ? "是" : "否"));

            return UIHelper.Result();
        }

    }
}