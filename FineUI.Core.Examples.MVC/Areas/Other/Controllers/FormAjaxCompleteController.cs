using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class FormAjaxCompleteController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/FormAjaxComplete
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult onForm1Submit(IFormCollection values)
        {
            // 为了观察前台动画，后台休眠 1 秒钟
            System.Threading.Thread.Sleep(1000);

            ShowNotify(values);

            return UIHelper.Result();
        }


    }
}