using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class NumberBoxRateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/NumberBoxRate
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Button1_Click(int currentNum)
        {
            currentNum++;
            if (currentNum > 5)
            {
                currentNum = 0;
            }

            UIHelper.NumberBox("NumberBox12").Text(currentNum.ToString());

            return UIHelper.Result();
        }

    }
}