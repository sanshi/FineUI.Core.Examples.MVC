using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerDayRangeMinDateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerDayRangeMinDate
        public IActionResult Index()
        {
            ViewBag.DatePicker1MinDate = DateTime.Now;
            ViewBag.DatePicker1MaxDate = DateTime.Now.AddDays(30);

            ViewBag.DatePicker1RangeStartDate = DateTime.Now.AddDays(5);
            ViewBag.DatePicker1RangeEndDate = DateTime.Now.AddDays(10);

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