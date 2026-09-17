using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarDisplayYearController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public static readonly string Calendar1DateFormatString = "yyyy";

        // GET: Calendar/CalendarDisplayYear
        public IActionResult Index()
        {
            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;
            ViewBag.Calendar1Text = DateTime.Now.Year.ToString();
            ViewBag.Button1Text = String.Format("选中{0}", DateTime.Now.AddYears(2).Year);

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
            var text = DateTime.Now.AddYears(2).Year.ToString();
            UIHelper.Calendar("Calendar1").Text(text);

            UpdateResult(text);

            return UIHelper.Result();
        }


        private void UpdateResult(string text)
        {
            UIHelper.Label("labResult").Text(String.Format("选择的年份：{0}", text));
        }
    }
}