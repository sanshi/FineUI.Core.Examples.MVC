using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Basic.Controllers
{
    // 独立 HTTP 响应入口：不渲染 FineUI 页面，也不初始化页面主题等配置。
    [Area("Basic")]
    [Route("/Basic/LoginCaptcha/CaptchaImage")]
    public class LoginCaptchaImageController : Controller
    {
        public IActionResult CaptchaImage(int w = 200, int h = 300)
        {
            // 原示例的图片生成尚未启用，保留现有响应行为。
            byte[] imageBytes = null;

            //// 从 Session 中读取验证码，并创建图片
            //using (CaptchaImage.CaptchaImage ci = new CaptchaImage.CaptchaImage(HttpContext.Session["CaptchaImageText"].ToString(), w, h, "Consolas"))
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        ci.Image.Save(ms, ImageFormat.Jpeg);
            //        imageBytes = ms.ToArray();
            //    }
            //}

            return File(imageBytes, "image/jpeg");
        }
    }
}
