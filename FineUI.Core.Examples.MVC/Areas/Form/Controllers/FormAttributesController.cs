using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FormAttributesController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormAttributes
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeTip1_Click()
        {
            UIHelper.Label("Label1").ToolTip("改变后的提示信息（ToolTip）");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnChangeTip2_Click()
        {
            UIHelper.Label("Label2").Attribute("data-qtip", "改变后的提示信息（Attributes）");

            return UIHelper.Result();
        }

    }
}