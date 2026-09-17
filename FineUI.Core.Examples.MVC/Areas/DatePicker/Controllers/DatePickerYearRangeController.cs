using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerYearRangeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerYearRange
        public IActionResult Index()
        {
            ViewBag.DatePicker1RangeStartDate = DateTime.Now.AddYears(0);
            ViewBag.DatePicker1RangeEndDate = DateTime.Now.AddYears(5);

            ViewBag.DatePicker1MinDate = DateTime.Now.AddYears(-5);
            ViewBag.DatePicker1MaxDate = DateTime.Now.AddYears(15);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("年份范围：{0}", values["DatePicker1"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}