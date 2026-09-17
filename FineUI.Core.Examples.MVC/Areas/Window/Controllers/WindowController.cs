using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Window.Controllers
{
    [Area("Window")]
    public class WindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Window/Window
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Window1_Close()
        {
            Alert.Show("触发了窗体的关闭事件！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowInServer_Click()
        {
            UIHelper.Window("Window1").Show();

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHideInServer_Click()
        {
            UIHelper.Window("Window1").Hide();

            return UIHelper.Result();
        }

    }
}