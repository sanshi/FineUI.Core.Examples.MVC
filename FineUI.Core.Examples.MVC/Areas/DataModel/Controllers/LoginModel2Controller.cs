using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class LoginModel2Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/LoginModel
        public IActionResult Index()
        {
            //return View(new User());
            return View(this);
        }

        [BindProperty]
        public User CurrentUser { get; set; }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnLogin_Click()
        {
            if (ModelState.IsValid)
            {
                if (CurrentUser.UserName == "admin" && CurrentUser.Password == "admin888")
                {
                    ShowNotify("成功登录！", MessageBoxIcon.Success);
                }
                else
                {
                    ShowNotify(String.Format("用户名（{0}）或密码（{1}）错误！",
                        CurrentUser.UserName,
                        CurrentUser.Password), MessageBoxIcon.Error);
                }
            }

            return UIHelper.Result();
        }

    }
}