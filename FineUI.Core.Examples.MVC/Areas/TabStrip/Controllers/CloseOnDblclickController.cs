using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class CloseOnDblclickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/CloseOnDblclick
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowInServer_Click()
        {
            UIHelper.Tab("Tab3").Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnShowActiveInServer_Click()
        {
            UIHelper.Tab("Tab3").Active();

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHideInServer_Click()
        {
            UIHelper.Tab("Tab3").Hide();

            return UIHelper.Result();
        }


    }
}