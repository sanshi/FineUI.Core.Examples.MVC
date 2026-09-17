using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.FormTable.Controllers
{
    [Area("FormTable")]
    public class TableStyleFormController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormTable/TableStyleForm
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmitForm_Click(IFormCollection values)
        {
            ShowNotify(values);

            return UIHelper.Result();
        }

    }
}