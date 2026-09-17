using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
	[Area("Form")]
    public class TriggerBoxClearIconController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/TriggerBoxClearIcon
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string box1Value)
        {
            Alert.Show("文本框的输入值：" + box1Value);

            return UIHelper.Result();
        }

    }
}