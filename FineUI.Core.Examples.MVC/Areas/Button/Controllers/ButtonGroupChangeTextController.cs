using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonGroupChangeTextController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonGroupChangeText
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeButtonText_Click(string text)
        {
            UIHelper.Button("Button4").Text(text.Length == 3 ? "按钮四（" + DateTime.Now.ToString() + "）" : "按钮四");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowHideButton_Click(bool hidden)
        {
            UIHelper.Button("Button4").Hidden(!hidden);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeButtonText2_Click(string text)
        {
            UIHelper.Button("Button8").Text(text.Length == 3 ? "按钮八（" + DateTime.Now.ToString() + "）" : "按钮八");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowHideButton2_Click(bool hidden)
        {
            UIHelper.Button("Button8").Hidden(!hidden);

            return UIHelper.Result();
        }

    }
}