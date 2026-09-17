using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Window.Controllers
{
    [Area("Window")]
    public class ToolbarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Window/Toolbar
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClose_Click()
        {
            UIHelper.Window("Window1").Hidden(true);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeText_Click()
        {
            PageContext.RegisterStartupScript(String.Format("$('#mylabel').html('{0}')", "这是修改后的值！" + DateTime.Now.ToLongTimeString()));
            
            return UIHelper.Result();
        }

        
    }
}