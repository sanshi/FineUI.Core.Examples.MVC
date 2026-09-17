using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.MobileWindow.Controllers
{
    [Area("MobileWindow")]
    public class WindowController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileWindow/Window
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnLogin_Click(IFormCollection values)
        {
            if (values["tbxUserName"] == "admin" && values["tbxPassword"] == "admin")
            {
                ShowNotify("成功登录！", MessageBoxIcon.Success);
            }
            else
            {
                ShowNotify("用户名或密码错误！", MessageBoxIcon.Error);
            }

            return UIHelper.Result();
        }

    }
}