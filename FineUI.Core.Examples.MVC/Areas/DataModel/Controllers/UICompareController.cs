using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class UICompareController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/UICompare
        public IActionResult Index()
        {
            var model = new UICompareModel();
            model.StartDate = DateTime.Now;
            model.Number1 = 30;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click([Bind("StartDate", "EndDate", "Password", "ConfirmPassword", "Number1", "Number2")]UICompareModel compareModel)
        {
            if (ModelState.IsValid)
            {
                ShowNotify(new RawHtml("用户提交的数据：<br/><pre>{0}</pre>", EncodeJson(compareModel)));
            }

            return UIHelper.Result();
        }

    }
}