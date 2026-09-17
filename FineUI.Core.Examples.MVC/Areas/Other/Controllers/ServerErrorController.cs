using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class ServerErrorController : FineUI.Core.Examples.MVC.Controllers.BaseController
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
            throw new Exception("服务器异常错误！");
        }

    }
}