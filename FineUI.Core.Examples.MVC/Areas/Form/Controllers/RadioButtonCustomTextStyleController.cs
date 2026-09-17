using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class RadioButtonCustomTextStyleController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/RadioButton
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectSingleRadio_Click(bool isChecked)
        {
            UIHelper.RadioButton("rbtnSingleRadio").Checked(!isChecked);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectSecondRadio_Click(string checkedRadio)
        {
            String[] radios = new String[] { "rbtnFirst", "rbtnSecond", "rbtnThird" };

            for (int i = 0; i < radios.Length; i++)
            {
                if (radios[i] == checkedRadio)
                {
                    int next = i + 1;
                    if (next >= radios.Length)
                    {
                        next = 0;
                    }

                    UIHelper.RadioButton(radios[next]).Checked(true);

                    break;
                }
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult rbtnAuto_CheckedChanged(string checkedRadio)
        {
            ShowNotify("单选框选中项：" + checkedRadio);

            return UIHelper.Result();
        }

        
    }
}