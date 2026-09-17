using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class MenuIconController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/MenuIcon
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string icon)
        {
            var MenuHyperLink1 = UIHelper.MenuHyperLink("MenuHyperLink1");

            if (icon.EndsWith("accept.png"))
            {
                MenuHyperLink1.Icon(Icon.None);
            }
            else
            {
                MenuHyperLink1.Icon(Icon.Accept);
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string icon)
        {
            var MenuHyperLink2 = UIHelper.MenuHyperLink("MenuHyperLink2");

            if (icon.EndsWith("accept.png"))
            {
                MenuHyperLink2.Icon(Icon.Application);
            }
            else
            {
                MenuHyperLink2.Icon(Icon.Accept);
            }

            return UIHelper.Result();
        }

    }
}