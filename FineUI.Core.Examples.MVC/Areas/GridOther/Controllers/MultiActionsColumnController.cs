using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridOther.Controllers
{
    [Area("GridOther")]
    public class MultiActionsColumnController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/MultiActionsColumn
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window1_Close()
        {
            Alert.Show("触发了窗体的关闭事件！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_CustomDelete(int rowIndex, string rowId, string rowText)
        {
            ShowNotify(String.Format("你点击了第 {0} 行的删除按钮，行ID：{1}，姓名：{2}", rowIndex + 1, rowId, rowText));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_CustomEdit(int rowIndex, string rowId, string rowText)
        {
            ShowNotify(String.Format("你点击了第 {0} 行的编辑按钮，行ID：{1}，姓名：{2}", rowIndex + 1, rowId, rowText));

            return UIHelper.Result();
        }
        

    }
}