using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Panel.Controllers
{
    [Area("Panel")]
    public class PanelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Panel/Panel
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(bool collapsed)
        {
            ShowNotify(String.Format("面板处于{0}状态", collapsed ? "折叠" : "展开"));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click(bool collapsed)
        {
            UIHelper.Panel("Panel2").Collapsed(!collapsed);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_Click()
        {
            UIHelper.Panel("Panel1").Title(String.Format("面板（{0}）", DateTime.Now.ToLongTimeString()));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button5_Click()
        {
            UIHelper.ToolbarText("ToolbarText1").Text(String.Format("工具条文本一（{0}）", DateTime.Now.ToLongTimeString()));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button6_Click(bool textHidden, bool separatorHidden)
        {
            UIHelper.ToolbarText("ToolbarText1").Hidden(!textHidden);
            UIHelper.ToolbarSeparator("ToolbarSeparator1").Hidden(!separatorHidden);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button7_Click()
        {
            UIHelper.Toolbar("Toolbar1").Hidden(true);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button8_Click()
        {
            UIHelper.Toolbar("Toolbar1").Hidden(false);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button9_Click(string iconFont)
        {
            var panel = UIHelper.Panel("Panel1");

            if (iconFont == "f-iconfont-volume-up")
            {
                panel.IconFont(IconFont._VolumeDown);
            }
            else if (iconFont == "f-iconfont-volume-down")
            {
                panel.IconFont(IconFont._VolumeOff);
            }
            else
            {
                panel.IconFont(IconFont._VolumeUp);
            }

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button10_Click()
        {
            UIHelper.Panel("Panel1").IconFont(IconFont.None);

            return UIHelper.Result();
        }

    }
}