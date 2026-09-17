using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Editor.Controllers
{
    [Area("Editor")]
    public class UMEditorTabStripController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Editor/UMEditorTabStrip
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string text1, string text2)
        {
            ShowNotify(new RawHtml("编辑器一：{0}<br/>编辑器二：{1}", HttpUtility.HtmlEncode(text1), HttpUtility.HtmlEncode(text2)));

            return UIHelper.Result();
        }

    }
}