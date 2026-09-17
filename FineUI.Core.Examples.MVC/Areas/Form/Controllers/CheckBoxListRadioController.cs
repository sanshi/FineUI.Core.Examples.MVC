using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class CheckBoxListRadioController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/CheckBoxListRadio
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckBoxList1_Change(string selected)
        {
            if (!String.IsNullOrEmpty(selected))
            {
                ShowNotify(String.Format("列表一的选中项：{0}", selected));
            }
            else
            {
                ShowNotify("列表一没有选中项！");
            }

            return UIHelper.Result();
        }

    }
}