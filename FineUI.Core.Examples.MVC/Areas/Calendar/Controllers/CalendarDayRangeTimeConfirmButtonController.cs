using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarDayRangeTimeConfirmButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        private DateTime GetStartDate()
        {
            var date = DateTime.Now.AddDays(2);
            return new DateTime(date.Year, date.Month, date.Day, 8, 50, 0);
        }
        private DateTime GetEndDate()
        {
            var date = DateTime.Now.AddDays(20);
            return new DateTime(date.Year, date.Month, date.Day, 11, 50, 0);
        }

        public static readonly string Calendar1DateFormatString = "yyyy/MM/dd HH:mm:ss";

        private string GetRangeText()
        {
            return String.Format("{0} - {1}", GetStartDate().ToString(Calendar1DateFormatString), GetEndDate().ToString(Calendar1DateFormatString));
        }

        // GET: Calendar/CalendarDayRangeTimeConfirmButton
        public IActionResult Index()
        {
            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;

            ViewBag.Calendar1RangeStartDate = DateTime.Parse("2014-07-30 14:30:00");
            ViewBag.Calendar1RangeEndDate = DateTime.Parse("2014-08-08 16:30:00");


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
            UIHelper.Calendar("Calendar1").RangeStartEndDate(GetStartDate(), GetEndDate(), Calendar1DateFormatString);

            UpdateResult(GetRangeText());

            return UIHelper.Result();
        }


        private void UpdateResult(string text)
        {
            UIHelper.Label("labResult").Text(String.Format("日期范围：{0}", text));
        }
    }
}