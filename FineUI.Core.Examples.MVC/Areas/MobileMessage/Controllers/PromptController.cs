using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileMessage.Controllers
{
    [Area("MobileMessage")]
    public class PromptController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileMessage/Prompt
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            Prompt prompt = new Prompt();
            prompt.Message = "请输入你的姓名？";
            prompt.Title = "请输入";
            prompt.OkScript = "notifyit(arguments[0]);";
            prompt.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            Prompt prompt = new Prompt();
            prompt.Message = "请输入你的姓名？";
            prompt.Title = "请输入";
            prompt.OkScript = "notifyit(arguments[0]);";
            prompt.TitleAlign = TextAlign.Center;
            prompt.EnableClose = false;
            prompt.ButtonFill = true;
            prompt.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            Prompt prompt = new Prompt();
            prompt.Message = "请输入你的姓名？";
            prompt.Title = "请输入";
            prompt.OkScript = "notifyit(arguments[0]);";
            prompt.TitleAlign = TextAlign.Center;
            prompt.EnableClose = false;
            prompt.ButtonPlain = true;
            prompt.CancelButtonAhead = true;
            prompt.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button4_Click()
        {
            Prompt prompt = new Prompt();
            prompt.Message = "请输入你的密码？";
            prompt.Title = "请输入";
            prompt.OkScript = "notifyit(arguments[0]);";
            prompt.TitleAlign = TextAlign.Center;
            prompt.EnableClose = false;
            prompt.ButtonPlain = true;
            prompt.TextMode = TextMode.Password;
            prompt.Show();

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button5_Click()
        {
            Prompt prompt = new Prompt();
            prompt.Message = "请输入你的姓名？";
            prompt.Title = "请输入";
            prompt.OkScript = "notifyit(arguments[0]);";
            prompt.TitleAlign = TextAlign.Center;
            prompt.EnableClose = false;
            prompt.ButtonPlain = true;
            prompt.Show();

            return UIHelper.Result();
        }

    }
}