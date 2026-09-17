using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.FormTable.Controllers
{
    [Area("FormTable")]
    public class TableStyleLayoutInfoController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormTable/TableStyleLayoutInfo
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