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
    public class FormPrefixSuffixController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormPrefixSuffix
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(Microsoft.AspNetCore.Http.IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

    }
}