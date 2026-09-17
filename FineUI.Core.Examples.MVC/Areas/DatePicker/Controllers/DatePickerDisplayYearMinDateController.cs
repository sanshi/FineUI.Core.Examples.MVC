using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerDisplayYearMinDateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerDisplayYearMinDate
        public IActionResult Index()
        {
            ViewBag.DatePicker1SelectedDate = DateTime.Now;
            ViewBag.DatePicker1MinDate = DateTime.Now.AddYears(-5);
            ViewBag.DatePicker1MaxDate = DateTime.Now.AddYears(5);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("开始年份：{0}  结束年份：{1}",
                values["DatePicker1"],
                values["DatePicker2"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}