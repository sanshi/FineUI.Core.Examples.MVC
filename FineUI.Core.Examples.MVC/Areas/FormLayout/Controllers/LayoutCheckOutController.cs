using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.FormLayout.Controllers
{
    [Area("FormLayout")]
    public class LayoutCheckOutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormLayout/LayoutCheckOut
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult cbxSameAsContactAddress_CheckedChanged(bool isChecked)
        {
            UIHelper.TextBox("tbxBillingAddress").Enabled(!isChecked);
            UIHelper.TextBox("tbxBillingProvince").Enabled(!isChecked);
            UIHelper.TextBox("tbxBillingCity").Enabled(!isChecked);
            UIHelper.TextBox("tbxBillingPostCode").Enabled(!isChecked);

            return UIHelper.Result();
        }

    }
}