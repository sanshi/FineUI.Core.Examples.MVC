using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileMessage.Controllers
{
    [Area("MobileMessage")]
    public class NotifyController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileMessage/Notify
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            Notify notify = new Notify();
            notify.Message = "数据保存成功！";
            notify.Title = "通知";
            notify.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            Notify notify = new Notify();
            notify.Message = "正在加载...";
            notify.MessageBoxIcon = MessageBoxIcon.None;
            notify.ShowHeader = false;
            notify.ShowLoading = true;
            notify.PositionX = Position.Center;
            notify.PositionY = Position.Center;
            notify.MinWidth = 0;
            notify.IsModal = true;
            notify.HideOnMaskClick = true;
            notify.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            Notify notify = new Notify();
            notify.CssClass = "mynotify-notext";
            notify.MessageBoxIcon = MessageBoxIcon.None;
            notify.ShowHeader = false;
            notify.ShowLoading = true;
            notify.PositionX = Position.Center;
            notify.PositionY = Position.Center;
            notify.MinWidth = 0;
            notify.IsModal = true;
            notify.HideOnMaskClick = true;
            notify.DisplayMilliseconds = 1000000;
            notify.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_Click()
        {
            Notify notify = new Notify();
            notify.CssClass = "mynotify";
            notify.MessageRawHtml = new RawHtml("<div class=\"f-loading\"><div class=\"f-loading-img\"><img src=\"{0}\"/></div></div><div class=\"f-loading-message\">正在加载</div>",
                FineUI.Core.PageContext.ResolveUrl("~/res/images/loading/loading_32.gif"));
            notify.MessageBoxIcon = MessageBoxIcon.None;
            notify.ShowHeader = false;
            notify.PositionX = Position.Center;
            notify.PositionY = Position.Center;
            notify.MinWidth = 0;
            notify.IsModal = true;
            notify.HideOnMaskClick = true;
            notify.DisplayMilliseconds = 1000000;
            notify.Show();

            return UIHelper.Result();
        }

    }
}