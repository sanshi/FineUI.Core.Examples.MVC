using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class AlertDownloadHideController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/AlertDownloadHide
        public IActionResult Index()
        {
            return View();
        }

        // GET: Message/AlertDownload/DownloadTextFile
        public IActionResult DownloadTextFile()
        {
            return File(Encoding.UTF8.GetBytes("这是下载文件的内容！"), "text/plain", "alert_download.txt");
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
            PageContext.RegisterStartupScript(
                UIHelper.Window("Window1").GetHideReference() + 
                Confirm.GetShowReference("操作成功！点击确定按钮开始下载文件，点取消按钮弹出对话框",
                    String.Empty,
                    MessageBoxIcon.Question,
                    "confirmOKCallback();",
                    "confirmCancelCallback();"));

            return UIHelper.Result();
        }


    }
}