using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace FineUI.Core.Examples.MVC.Areas.Message.Controllers
{
    // 独立 HTTP 响应入口：不渲染 FineUI 页面，也不初始化页面主题等配置。
    [Area("Message")]
    [Route("/Message/AlertDownloadHide/DownloadTextFile")]
    public class AlertDownloadHideFileController : Controller
    {
        public IActionResult DownloadTextFile()
        {
            return File(Encoding.UTF8.GetBytes("这是下载文件的内容！"), "text/plain", "alert_download.txt");
        }
    }
}
