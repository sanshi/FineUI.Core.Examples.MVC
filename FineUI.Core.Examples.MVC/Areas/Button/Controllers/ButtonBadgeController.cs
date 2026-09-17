using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
	[Area("Button")]
    public class ButtonBadgeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonBadge
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnCustomIcon_Click(string iconUrl)
        {
            var btnCustomIcon = UIHelper.Button("btnCustomIcon");

            if (iconUrl.EndsWith("1.png"))
            {
                btnCustomIcon.IconUrl("~/res/images/16/8.png");
            }
            else
            {
                btnCustomIcon.IconUrl("~/res/images/16/1.png");
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnChangeBadge_Click(string badgeNumber)
        {
            var btnBadgeNumber = UIHelper.Button("btnBadgeNumber");

            btnBadgeNumber.Badge(true, (Convert.ToInt32(badgeNumber) + 1).ToString());

            return UIHelper.Result();
        }


    }
}