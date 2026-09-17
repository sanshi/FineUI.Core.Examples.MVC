using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class WindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/Window
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/Window/IFrameWindow
        public IActionResult IFrameWindow()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClosePostBack_Click()
        {
            // 首先保存数据

            // 然后关闭本窗体
            var panel1 = UIHelper.Panel("Panel1");
            PageContext.RegisterStartupScript(panel1.GetClearDirtyReference() + ActiveWindow.GetHideReference());

            return UIHelper.Result();
        }

    }
}