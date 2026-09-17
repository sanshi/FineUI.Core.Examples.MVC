using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class AuthenticationTimeoutAsyncController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/AuthenticationTimeoutAsync
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            Response.Redirect(Url.Content("~/?ReturnUrl=%2fOther%2fAuthenticationTimeout"));

            return UIHelper.Result();
        }

    }
}