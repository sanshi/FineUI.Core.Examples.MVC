using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class NumberBoxDecimalPrecisionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/NumberBoxDecimalPrecision
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string number)
        {
            ShowNotify("数字输入框的值：" + number);

            return UIHelper.Result();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click()
        {
            var NumberBox1 = UIHelper.NumberBox("NumberBox1");

            NumberBox1.DecimalPrecision(1);
            NumberBox1.Increment(0.1);
            
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            var NumberBox1 = UIHelper.NumberBox("NumberBox1");

            NumberBox1.DecimalPrecision(2);
            NumberBox1.Increment(0.01);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click()
        {
            var NumberBox1 = UIHelper.NumberBox("NumberBox1");

            NumberBox1.DecimalPrecision(3);
            NumberBox1.Increment(0.001);

            return UIHelper.Result();
        }

    }
}