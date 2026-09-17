using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerDisplayTimeConfirmButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerDisplayTimeConfirmButton
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("开始时间：{0}  结束时间：{1}",
                values["DatePicker1"],
                values["DatePicker2"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}