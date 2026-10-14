using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class NotifyAddTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/NotifyAddTab
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnOperation1_Click()
        {
            // 随机生成通知对话框的客户端ID
            string notifyId = Guid.NewGuid().ToString();

            Notify n = new Notify();
            n.ID = notifyId;
            // 通知 ID 是本次生成的 GUID；链接只传数据，由页面的委托事件执行动作。
            n.MessageRawHtml = new RawHtml("<div class=\"addtabcontainer\"><a class=\"addtablink\" href=\"#\" data-notify-id=\"" + notifyId + "\">向父页面添加选项卡</a></div>");
            n.MessageBoxIcon = MessageBoxIcon.None;
            n.PositionX = Position.Right;
            n.PositionY = Position.Bottom;
            n.DisplayMilliseconds = 0;
            n.ShowHeader = false;

            n.Show();

            return UIHelper.Result();
        }

    }
}