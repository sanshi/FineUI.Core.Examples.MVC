using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class NumberBoxTextChangedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/NumberBoxTextChanged
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult NumberBox3_TextChanged(string text)
        {
            ShowNotify("数字输入框的值（NumberBox3_TextChanged）：" + text);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string text)
        {
            ShowNotify("数字输入框的值（btnSubmit_Click）：" + text);

            return UIHelper.Result();
        }


    }
}