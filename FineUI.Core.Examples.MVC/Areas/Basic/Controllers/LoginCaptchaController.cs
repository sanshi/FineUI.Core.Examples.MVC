using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.Basic.Controllers
{
    [Area("Basic")]
    public class LoginCaptchaController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Basic/LoginCaptcha
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            string imageHTML = InitCaptchaCode();

            ViewBag.ImgCaptchaText = imageHTML;
        }

        /// <summary>
        /// 初始化验证码
        /// </summary>
        private string InitCaptchaCode()
        {
            // 创建一个 6 位的随机数并保存在 Session 对象中
            HttpContext.Session.SetString("CaptchaImageText", GenerateRandomCode());
            
            string imageUrl = Url.Content("~/Basic/LoginCaptcha/CaptchaImage?w=100&h=26&t=" + DateTime.Now.Ticks);

            return String.Format("<img src=\"{0}\" />", imageUrl);
        }

        /// <summary>
        /// 创建一个 6 位的随机数
        /// </summary>
        /// <returns></returns>
        private string GenerateRandomCode()
        {
            string s = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                s += random.Next(10).ToString();
            }
            return s;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult imgCaptcha_Click()
        {
            string imageHTML = InitCaptchaCode();

            UIHelper.LinkButton("imgCaptcha").Text(imageHTML);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnLogin_Click(IFormCollection values)
        {
            if (values["tbxCaptcha"] != HttpContext.Session.GetString("CaptchaImageText"))
            {
                ShowNotify("验证码错误！");
            }
            else
            {
                if (values["tbxUserName"] == "admin" && values["tbxPassword"] == "admin")
                {
                    ShowNotify("成功登录！");
                }
                else
                {
                    ShowNotify("用户名或密码错误！", MessageBoxIcon.Error);
                }
            }

            return UIHelper.Result();
        }


        // 返回验证图片
        public IActionResult CaptchaImage(int w = 200, int h = 300)
        {
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