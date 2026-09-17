using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Layout.Controllers
{
    [Area("Layout")]
    public class RegionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Layout/Region
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_Click()
        {
            var panelLeftRegion = UIHelper.Panel("panelLeftRegion");

            string newtitle = String.Format("左侧面板（有提示信息） - 更新时间：{0}", DateTime.Now.ToLongTimeString());
            panelLeftRegion.Title(newtitle);
            panelLeftRegion.TitleToolTip(newtitle);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnHideBottomRegion_Click(bool hidden)
        {
            var panelBottomRegion = UIHelper.Panel("panelBottomRegion");

            panelBottomRegion.Hidden(!hidden);

            return UIHelper.Result();
        }

    }
}