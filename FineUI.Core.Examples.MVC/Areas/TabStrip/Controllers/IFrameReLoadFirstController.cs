using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.TabStrip.Controllers
{
    [Area("TabStrip")]
    public class IFrameReLoadFirstController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: TabStrip/IFrameReLoadFirst
        public IActionResult Index()
        {
            return View();
        }

        // GET: TabStrip/IFrameReLoadFirst/EmptyPage
        public IActionResult EmptyPage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            

            ShowNotify(values);

            return UIHelper.Result();
        }

    }
}