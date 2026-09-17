using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class ServerErrorCustomTimeoutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/ServerError
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button5_Click()
        {
            // 故意延迟5秒，以便客户端AJAX请求超时
            System.Threading.Thread.Sleep(5000);

            throw new Exception("服务器异常错误！");
        }

    }
}