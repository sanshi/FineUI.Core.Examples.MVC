using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarDisplayMonthMinDateController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public static readonly string Calendar1DateFormatString = "yyyy/MM";

        // GET: Calendar/CalendarDisplayMonth
        public IActionResult Index()
        {
            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;
            ViewBag.Calendar1Text = DateTime.Now.ToString(Calendar1DateFormatString);

            ViewBag.Calendar1MinDate = DateTime.Now.AddMonths(-5);
            ViewBag.Calendar1MaxDate = DateTime.Now.AddMonths(5);

            ViewBag.Button1Text = String.Format("选中{0}", DateTime.Now.AddMonths(2).ToString(Calendar1DateFormatString));

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
            var text = DateTime.Now.AddMonths(2).ToString(Calendar1DateFormatString);
            UIHelper.Calendar("Calendar1").Text(text);

            UpdateResult(text);

            return UIHelper.Result();
        }


        private void UpdateResult(string text)
        {
            UIHelper.Label("labResult").Text(String.Format("选择的年月：{0}", text));
        }
    }
}