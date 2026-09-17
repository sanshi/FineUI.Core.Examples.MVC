using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Editor.Controllers
{
    [Area("Editor")]
    public class CKEditorTwoController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Editor/CKEditorTwo
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string title, string text1, string text2)
        {
            if (String.IsNullOrEmpty(text1))
            {
                ShowNotify("文章正文不能为空！");
            }
            else
            {
                ShowNotify(new RawHtml("文章标题：{0}<br/>文章正文：{1}<br/>文章摘要：{2}", HttpUtility.HtmlEncode(title), HttpUtility.HtmlEncode(text1), HttpUtility.HtmlEncode(text2)));
            }

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string text1)
        {
            Regex regex = new Regex(@"<[^>]+>|</[^>]+>");
            string content = regex.Replace(text1, "");
            if (content.Length > 100)
            {
                content = content.Substring(0, 97) + "...";
            }

            UIHelper.HtmlEditor("HtmlEditor2").Text(content);

            return UIHelper.Result();
        }
    }
}