using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class FormLongLabelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormLongLabel
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

    }
}