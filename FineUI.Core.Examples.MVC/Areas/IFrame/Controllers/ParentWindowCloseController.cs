using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class ParentWindowCloseController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/ParentWindowClose
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/ParentWindowClose/IFrameWindow1
        public IActionResult IFrameWindow1()
        {
            return View();
        }

        // GET: IFrame/ParentWindowClose/IFrameWindow2
        public IActionResult IFrameWindow2()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IFrameWindow1_Window1_Close()
        {
            // IFrameWindow1 -> labResult
            UIHelper.Label("labResult").Text(DateTime.Now.ToLongTimeString());

            // 调用父页面定义的函数 updateLabelResult
            PageContext.RegisterStartupScript("parent.updateLabelResult();");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IFrameWindow2_Button1_Click()
        {
            ActiveWindow.HidePostBack();

            return UIHelper.Result();
        }

    }
}