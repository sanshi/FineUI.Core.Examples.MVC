using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class CustomPostbackController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/CustomPostback
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TextBox1_ENTER(string text1)
        {
            var textBox2 = UIHelper.TextBox("TextBox2");

            textBox2.Text(text1);
            textBox2.Focus(true);

            return UIHelper.Result();
        }

    }
}