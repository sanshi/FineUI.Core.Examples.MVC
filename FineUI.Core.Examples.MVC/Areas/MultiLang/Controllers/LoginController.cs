using FineUI.Core.Examples.MVC.Areas.MultiLang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class LoginController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/Login
        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnLogin_Click(IFormCollection values)
        {
            var userName = values["UserName"];
            var password = values["Password"];

            if (userName == "admin" && password == "admin888")
            {
                ShowNotify(_R("成功登录！"), MessageBoxIcon.Success);
            }
            else
            {
                ShowNotify(_R("用户名（{0}）或密码（{1}）错误！", userName, password), MessageBoxIcon.Error);
            }

            return UIHelper.Result();
        }


    }
}