using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    [Area("Message")]
    public class AlertDownloadHideIFrameController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Message/AlertDownloadHideIFrame
        public IActionResult Index()
        {
            return View();
        }

        // GET: Message/AlertDownloadHideIFrame/IFrameWindow
        public IActionResult IFrameWindow()
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
            // 不要在这里调用F.confirm，因为当前页面要被关闭，因此F.confirm的回调函数不能正确执行
            PageContext.RegisterStartupScript(ActiveWindow.GetHideReference() + "parent.showConfirm();");

            return UIHelper.Result();
        }

    }
}