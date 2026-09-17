
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarMinDateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public static readonly string Calendar1DateFormatString = "yyyy/MM/dd";

        // GET: Calendar/CalendarMinDate
        public IActionResult Index()
        {
            ViewBag.Calendar1MinDate = DateTime.Now;
            ViewBag.Calendar1MaxDate = DateTime.Now.AddDays(20);

            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;
            ViewBag.Calendar1SelectedDate = DateTime.Now.AddDays(10);
            ViewBag.Button1Text = String.Format("选中{0}", DateTime.Now.AddDays(2).ToString(Calendar1DateFormatString));

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calendar1_DateSelect(string selectedDate)
        {
            UpdateResult(DateTime.Parse(selectedDate));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            var selectedDate = DateTime.Now.AddDays(2);
            UIHelper.Calendar("Calendar1").SelectedDate(selectedDate);

            UpdateResult(selectedDate);

            return UIHelper.Result();
        }


        private void UpdateResult(DateTime date)
        {
            UIHelper.Label("labResult").Text(String.Format("选择的日期：{0}", date.ToString(Calendar1DateFormatString)));
        }
    }
}