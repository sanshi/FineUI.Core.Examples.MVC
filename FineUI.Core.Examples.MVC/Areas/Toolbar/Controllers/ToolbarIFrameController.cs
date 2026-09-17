using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class ToolbarIFrameController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/ToolbarIFrame
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            PageContext.RegisterStartupScript(String.Format("updateIFrameUrl('{0}');", Url.Content("~/Basic/Login")));

            return UIHelper.Result();
        }
        
    }
}