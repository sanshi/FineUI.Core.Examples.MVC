using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class TextBoxTextChangedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/TextBoxTextChanged
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TextBox1_TextChanged(string text)
        {
            UIHelper.Label("labResult1").Text("文本框一：" + text);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TextBox2_Blur(string text)
        {
            UIHelper.Label("labResult2").Text("文本框二：" + text);

            return UIHelper.Result();
        }

    }
}