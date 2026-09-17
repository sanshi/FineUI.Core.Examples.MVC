using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class IFrameCloseAllController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/IFrameCloseAll
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/IFrameCloseAll/IFrameWindow
        public IActionResult IFrameWindow()
        {
            return View();
        }

        // GET: IFrame/IFrameCloseAll/IFrameWindow2
        public IActionResult IFrameWindow2()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window1_Close()
        {
            UIHelper.Label("labResult").Text("Window1 关闭了，时间：" + DateTime.Now.ToLongTimeString());

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window2_Close()
        {
            UIHelper.Label("labResult").Text("Window2 关闭了，时间：" + DateTime.Now.ToLongTimeString());

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window3_Close()
        {
            UIHelper.Label("labResult").Text("Window3 关闭了，时间：" + DateTime.Now.ToLongTimeString());

            ActiveWindow.HidePostBack();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window4_Close()
        {
            UIHelper.Label("labResult").Text("Window4 关闭了，时间：" + DateTime.Now.ToLongTimeString());

            ActiveWindow.HidePostBack();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnCloseServer_Click()
        {
            ActiveWindow.HidePostBack();

            return UIHelper.Result();
        }

    }
}