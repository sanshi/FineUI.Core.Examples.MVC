using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Calendar.Controllers
{
    [Area("Calendar")]
    public class CalendarTimeRangeConfirmButtonController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public static readonly string Calendar1DateFormatString = "HH:mm:ss";

        // GET: Calendar/CalendarTimeRangeConfirmButton
        public IActionResult Index()
        {
            ViewBag.Calendar1DateFormatString = Calendar1DateFormatString;

            ViewBag.Calendar1Text = "14:30:00 - 16:30:00";

            ViewBag.Button1Text = String.Format("选中范围：{0} - {1}", "08:50:00", "11:50:00");

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
            var text = "08:50:00 - 11:50:00";

            UIHelper.Calendar("Calendar1").Text(text);

            return UIHelper.Result();
        }


        private void UpdateResult(string text)
        {
            UIHelper.Label("labResult").Text(String.Format("时间范围：{0}", text));
        }
    }
}