using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerIndependentRangePanelsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerIndependentRangePanels
        public IActionResult Index()
        {
            ViewBag.DatePicker1RangeStartDate = DateTime.Parse("2020-03-02");
            ViewBag.DatePicker1RangeEndDate = DateTime.Parse("2026-08-18");

            ViewBag.DatePicker2RangeStartDate = DateTime.Parse("2020-03-01");
            ViewBag.DatePicker2RangeEndDate = DateTime.Parse("2026-08-01");

            ViewBag.DatePicker3RangeStartDate = DateTime.Parse("2001-01-01");
            ViewBag.DatePicker3RangeEndDate = DateTime.Parse("2026-01-01");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("日期范围：{0}<br>月份范围：{1}<br>年份范围：{2}",
                values["DatePicker1"], values["DatePicker2"], values["DatePicker3"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }
    }
}
