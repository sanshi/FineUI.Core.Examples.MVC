using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class LinkButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/LinkButton
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LinkButton3_Click()
        {
            ShowNotify("这是服务器端事件");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeEnable_Click(bool enabled)
        {
            UIHelper.LinkButton("LinkButton1").Enabled(!enabled);
            
            return UIHelper.Result();
        }
        
    }
}