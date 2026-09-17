using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class ClientValidateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/ClientValidate
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRegister_Click(IFormCollection values)
        {
            Alert.Show("表单验证通过！");

            return UIHelper.Result();
        }

    }
}