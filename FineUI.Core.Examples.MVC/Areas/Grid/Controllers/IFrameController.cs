using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class IFrameController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/IFrame
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

    }
}