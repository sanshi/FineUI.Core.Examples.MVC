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
    public class FormResetController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/FormReset
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmitForm1_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmitForm2_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmitAll_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }
        
    }
}