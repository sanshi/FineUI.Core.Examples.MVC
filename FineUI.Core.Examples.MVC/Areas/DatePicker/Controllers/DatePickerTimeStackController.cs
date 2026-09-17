using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FineUI.Core.Examples.MVC.Areas.DatePicker.Controllers
{
    [Area("DatePicker")]
    public class DatePickerTimeStackController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DatePicker/DatePickerTimeStack
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(IFormCollection values)
        {
            var result = String.Format("开始日期：{0}  结束日期：{1}",
                values["DatePicker1"],
                values["DatePicker2"]);

            UIHelper.Label("labResult").Text(result);

            return UIHelper.Result();
        }

    }
}
