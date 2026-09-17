using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class GroupController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Panel/Group
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(bool collapsed)
        {
            UIHelper.GroupPanel("GroupPanel2").Collapsed(!collapsed);

            return UIHelper.Result();
        }

    }
}