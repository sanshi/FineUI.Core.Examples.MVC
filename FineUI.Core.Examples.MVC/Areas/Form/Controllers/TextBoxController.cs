using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class TextBoxController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/TextBox
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string userName, string password)
        {
            UIHelper.Label("labResult").Text("用户名：" + userName + " 密码：" + password);

            return UIHelper.Result();
        }

    }
}