using Newtonsoft.Json.Linq;
using System;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class ExcelSelectColumnsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/ExcelSelectColumns
        public IActionResult Index()
        {
            return View();
        }

        #region SelectColumnsIFrame

        // GET: Grid/SelectColumnsIFrame
        public IActionResult SelectColumnsIFrame()
        {
            return View();
        }

        public IActionResult SelectColumnsIFrame_btnSaveContinue_Click(string[] columns)
        {
            // 关闭弹出窗体，然后执行父页面的JavaScript函数（exportToExcel）并传入参数
            ActiveWindow.HideExecuteScript(String.Format("exportToExcel({0});", new JArray(columns).ToString(Newtonsoft.Json.Formatting.None)));

            return UIHelper.Result();
        }

        #endregion
    }
}
