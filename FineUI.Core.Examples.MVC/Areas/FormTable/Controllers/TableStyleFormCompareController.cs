using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.FormTable.Controllers
{
    [Area("FormTable")]
    public class TableStyleFormCompareController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormTable/TableStyleFormCompare
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