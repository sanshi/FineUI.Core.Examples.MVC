using FineUI.Core.Examples.MVC.Areas.MultiLang.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class UICompareAnnotationController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/UICompareAnnotation
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
                ShowNotify(_R("SuccessMessage", JsonConvert.SerializeObject(compareModel, Formatting.Indented)));
            }

            return UIHelper.Result();
        }

    }
}