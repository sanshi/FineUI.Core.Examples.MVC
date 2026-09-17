using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class SelectProvinceController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/SelectProvince
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/SelectProvince/IFrameWindow
        public IActionResult IFrameWindow()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window1_Close()
        {
            ShowNotify("触发了 Window1 的关闭事件！");

            return UIHelper.Result();
        }

    }
}