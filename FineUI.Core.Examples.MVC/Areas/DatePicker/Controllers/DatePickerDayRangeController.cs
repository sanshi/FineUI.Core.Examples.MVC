using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerDayRangeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerDayRange
        public IActionResult Index()
        {
            ViewBag.DatePicker1RangeStartDate = DateTime.Parse("2014-07-30");
            ViewBag.DatePicker1RangeEndDate = DateTime.Parse("2014-08-08");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("日期范围：{0}", values["DatePicker1"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}