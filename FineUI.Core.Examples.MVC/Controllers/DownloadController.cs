using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace FineUI.Core.Examples.MVC.Controllers
{
    // 独立 HTTP 响应入口：不渲染 FineUI 页面，也不初始化页面主题等配置。
    [Route("/Home/Download")]
    public class DownloadController : Controller
    {
        [HttpGet]
        public IActionResult Download(string file, string inline)
        {
            if (String.IsNullOrEmpty(file))
            {
                return NotFound();
            }

            // 安全①：只取文件名部分，剥离任何目录信息，防止路径穿越（如 ..\..\appsettings.json）
            string safeName = Path.GetFileName(file);
            if (safeName != file)
            {
                return BadRequest();
            }

            string fullPath = UploadStorage.GetUploadFilePath(safeName);
            if (!System.IO.File.Exists(fullPath))
            {
                return NotFound();
            }

            // 禁止浏览器嗅探内容改写 Content-Type
            Response.Headers["X-Content-Type-Options"] = "nosniff";

            // 安全②：只有白名单内的图片、且调用方明确要求内联时，才按 image/xxx 输出。
            string imageContentType = UploadStorage.IsInlineRequested(inline) ? UploadStorage.GetImageContentType(safeName) : null;
            if (imageContentType != null)
            {
                // 不写 Content-Disposition，浏览器默认即内联
                return PhysicalFile(fullPath, imageContentType);
            }

            // 其余一律以附件下载：传上来的 .html / .svg 等不会被渲染，从根上杜绝存储型 XSS。
            // 传了 fileDownloadName，框架会自动写出 Content-Disposition（含支持 UTF-8 文件名的
            // filename*，中文名不乱码）。
            return PhysicalFile(fullPath, "application/octet-stream", safeName);
        }
    }
}
