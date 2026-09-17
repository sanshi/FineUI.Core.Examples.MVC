using FineUI.Core.Examples.MVC.Areas.MultiLang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class LoginAnnotationController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/LoginAnnotation
        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnLogin_Click([Bind("UserName", "Password")]User user)
        {
            if (ModelState.IsValid)
            {
                if (user.UserName == "admin" && user.Password == "admin888")
                {
                    ShowNotify(_R("成功登录！"), MessageBoxIcon.Success);
                }
                else
                {
                    ShowNotify(_R("用户名（{0}）或密码（{1}）错误！", user.UserName, user.Password), MessageBoxIcon.Error);
                }
            }

            return UIHelper.Result();
        }


        // https://www.dotnetexpertguide.com/2012/12/aspnet-mvc-accessing-base-controller.html
        // In the Model-View-Controller pattern the view should never know about the controller.
        // If your view needs info about the User Role it should be passed to the view from the controller but you should never have your view access your controller.

    }
}