using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class HtmlEditorController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/HtmlEditor
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string content)
        {
            UIHelper.TextArea("TextArea1").Text(content);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string content)
        {
            UIHelper.HtmlEditor("HtmlEditor1").Text(content);

            return UIHelper.Result();
        }

    }
}