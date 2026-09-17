using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class AutoCompleteInlineWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: ThirdParty/AutoCompleteInlineWindow
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string TextBox1)
        {
            ShowNotify(String.Format("用户输入值：{0}", TextBox1));

            return UIHelper.Result();
        }

    }
}