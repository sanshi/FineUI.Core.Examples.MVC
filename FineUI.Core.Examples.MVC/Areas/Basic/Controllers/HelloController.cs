using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Basic.Controllers
{
    [Area("Basic")]
    public class HelloController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Basic/Hello
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHello_Click()
        {
            Alert.Show("你好 FineUI！", MessageBoxIcon.Warning);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHello2_Click()
        {
            Alert.ShowInTop("你好 FineUI！", MessageBoxIcon.Information);

            return UIHelper.Result();
        }
    }
}