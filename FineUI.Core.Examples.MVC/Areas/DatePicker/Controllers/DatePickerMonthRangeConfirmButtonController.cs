using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerMonthRangeConfirmButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerMonthRangeConfirmButton
        public IActionResult Index()
        {
            ViewBag.DatePicker1RangeStartDate = DateTime.Now.AddMonths(0);
            ViewBag.DatePicker1RangeEndDate = DateTime.Now.AddMonths(5);

            ViewBag.DatePicker1MinDate = DateTime.Now.AddMonths(-5);
            ViewBag.DatePicker1MaxDate = DateTime.Now.AddMonths(15);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("月份范围：{0}", values["DatePicker1"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}