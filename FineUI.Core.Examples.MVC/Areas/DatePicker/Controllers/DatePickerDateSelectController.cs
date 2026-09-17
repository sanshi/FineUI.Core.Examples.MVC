using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerDateSelectController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerDateSelect
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DatePicker1_TextChanged(string DatePicker1)
        {
            var datePicker1 = DateUtil.ToDateTime(DatePicker1, "yyyy/MM/dd");
            if (datePicker1.HasValue)
            {
                UIHelper.DatePicker("DatePicker2").SelectedDate(datePicker1.Value.AddDays(3));
            }

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DatePicker3_DateSelect(string DatePicker3)
        {
            var datePicker3 = DateUtil.ToDateTime(DatePicker3, "yyyy/MM/dd");
            if (datePicker3.HasValue)
            {
                UIHelper.DatePicker("DatePicker4").SelectedDate(datePicker3.Value.AddDays(3));
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string DatePicker1, string DatePicker2)
        {
            UIHelper.Label("labResult1").Text(String.Format("开始日期：{0}  结束日期：{1}", DatePicker1, DatePicker2));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string DatePicker3, string DatePicker4)
        {
            UIHelper.Label("labResult2").Text(String.Format("开始日期：{0}  结束日期：{1}", DatePicker3, DatePicker4));

            return UIHelper.Result();
        }

    }
}