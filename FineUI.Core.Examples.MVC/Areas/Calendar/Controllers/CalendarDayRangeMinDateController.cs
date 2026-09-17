using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarDayRangeMinDateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        private DateTime startDate = DateTime.Now.AddDays(2);
        private DateTime endDate = DateTime.Now.AddDays(20);

        private string GetRangeText()
        {
            return String.Format("{0} - {1}", startDate.ToString(Calendar1DateFormatString), endDate.ToString(Calendar1DateFormatString));
        }

        public static readonly string Calendar1DateFormatString = "yyyy/MM/dd";

        // GET: Calendar/CalendarDayRangeMinDate
        public IActionResult Index()
        {
            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;

            ViewBag.Calendar1MinDate = DateTime.Now;
            ViewBag.Calendar1MaxDate = DateTime.Now.AddDays(30);

            ViewBag.Calendar1RangeStartDate = DateTime.Now.AddDays(5);
            ViewBag.Calendar1RangeEndDate = DateTime.Now.AddDays(10);

            ViewBag.Button1Text = String.Format("选中范围：{0}", GetRangeText());

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calendar1_DateSelect(string text)
        {
            UpdateResult(text);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            UIHelper.Calendar("Calendar1").RangeStartEndDate(startDate, endDate, Calendar1DateFormatString);

            UpdateResult(GetRangeText());

            return UIHelper.Result();
        }


        private void UpdateResult(string text)
        {
            UIHelper.Label("labResult").Text(String.Format("日期范围：{0}", text));
        }
    }
}