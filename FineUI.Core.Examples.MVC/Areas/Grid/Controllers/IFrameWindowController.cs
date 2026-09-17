using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class IFrameWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/IFrameWindow
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSaveClose_Click()
        {
            // 1. 这里放置保存窗体中数据的逻辑

            // 2. 关闭本窗体（触发窗体的关闭事件）
            PageContext.RegisterStartupScript(ActiveWindow.GetHidePostBackReference());

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSaveHideRefresh_Click()
        {
            // 1. 这里放置保存窗体中数据的逻辑

            // 2. 隐藏本窗体，然后刷新父窗体
            PageContext.RegisterStartupScript(ActiveWindow.GetHideRefreshReference());

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSaveCloseTab_Click()
        {
            // 1. 这里放置保存窗体中数据的逻辑

            // 2. 隐藏本窗体，然后执行JavaScript脚本（关闭当前激活的选项卡）
            PageContext.RegisterStartupScript(ActiveWindow.GetHideExecuteScriptReference("parent.removeActiveTab();"));

            return UIHelper.Result();
        }


    }
}