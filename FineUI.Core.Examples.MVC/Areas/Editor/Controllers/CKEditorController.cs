using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Editor.Controllers
{
    [Area("Editor")]
    public class CKEditorController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Editor/CKEditor
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                ShowNotify("编辑器内容为空！");
            }
            else
            {
                ShowNotify(text);
            }

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            UIHelper.HtmlEditor("HtmlEditor1").Text("<p><strong>FineUI.Core</strong> - .NET 企业级全栈 UI 框架。</p>");

            return UIHelper.Result();
        }


    }
}