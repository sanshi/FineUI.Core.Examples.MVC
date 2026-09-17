using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class NumberBoxTriggerTypeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/NumberBoxTriggerType
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