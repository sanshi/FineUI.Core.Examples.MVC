using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Other.Controllers
{
    [Area("Other")]
    public class FieldLabelStyleController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Other/FieldLabelStyle
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSwitchClass_Click(bool hasClassRed)
        {
            var tbxUserName = UIHelper.TextBox("tbxUserName");
            var tbxPassword = UIHelper.TextBox("tbxPassword");

            if (hasClassRed)
            {
                tbxUserName.RemoveCssClass("red");
                tbxPassword.RemoveCssClass("red");

                tbxUserName.AddCssClass("blue");
                tbxPassword.AddCssClass("blue");
            }
            else
            {
                tbxUserName.RemoveCssClass("blue");
                tbxPassword.RemoveCssClass("blue");

                tbxUserName.AddCssClass("red");
                tbxPassword.AddCssClass("red");
            }

            return UIHelper.Result();
        }

    }
}