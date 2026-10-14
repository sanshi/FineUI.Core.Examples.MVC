using System;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class AlertDownloadController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/AlertDownload
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmCancel()
        {
            ShowNotify("点击了取消按钮！");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnOperation_Click()
        {
            new Confirm
            {
                Message = "操作成功！点击确定按钮开始下载文件，点取消按钮弹出对话框",
                MessageBoxIcon = MessageBoxIcon.Question,
                OkFunction = "confirmOKCallback",
                CancelFunction = "confirmCancelCallback"
            }.Show();

            return UIHelper.Result();
        }
    }
}
