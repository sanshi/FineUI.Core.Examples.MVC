using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FormValidateValidatorController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormValidateValidator
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRegister_Click(string userName, string password)
        {
            ShowNotify(String.Format("用户名：{0} 密码：{1}", userName, password));

            return UIHelper.Result();
        }

    }
}