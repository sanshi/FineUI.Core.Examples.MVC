using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class CheckBoxListRadioAtLeastOneController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/CheckBoxListRadioAtLeastOne
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckBoxList1_Change(string selected)
        {
            ShowNotify(String.Format("列表一的选中项：{0}", selected));

            return UIHelper.Result();
        }

    }
}