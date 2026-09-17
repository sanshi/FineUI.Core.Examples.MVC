using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class ColorPickerController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: ThirdParty/ColorPicker
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string dateValue, string textValue)
        {
            ShowNotify(String.Format("日期一：{0} 颜色值：{1}", dateValue, textValue));

            return UIHelper.Result();
        }

    }
}