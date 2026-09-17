using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class FormSecondaryPropertyController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/FormSecondaryProperty
        public IActionResult Index()
        {
            var model = new Student
            {
                Id = 101,
                Name = "张萍萍",
                Gender = 0,
                EntranceYear = 2000,
                AtSchool = true,
                Major = "材料科学与工程系",
                Group = 1,
                EntranceDate = DateTime.Parse("2000-09-01"),
                Score = new Score
                {
                    Chinese = 80,
                    Math = 100,
                    Physics = 88,
                    Chemistry = 79
                }
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnResetScore_Click()
        {
            UIHelper.NumberBox("Score_Chinese").Text("100");
            UIHelper.NumberBox("Score_Math").Text("100");
            UIHelper.NumberBox("Score_Physics").Text("100");
            UIHelper.NumberBox("Score_Chemistry").Text("100");

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click([Bind("Id", "Name", "Gender", "Major", "AtSchool", "EntranceDate")]Student model, IFormCollection values)
        {
            if (ModelState.IsValid)
            {
                model.Score = new Score {
                    Chinese = Convert.ToInt32(values["Score.Chinese"]),
                    Math = Convert.ToInt32(values["Score.Math"]),
                    Physics = Convert.ToInt32(values["Score.Physics"]),
                    Chemistry = Convert.ToInt32(values["Score.Chemistry"]),
                };

                model.Group = 1;
                model.EntranceYear = model.EntranceDate.Value.Year;
                
                ShowNotify(new RawHtml("用户提交的数据：<br/><pre>{0}</pre>", EncodeJson(model)));
            }

            return UIHelper.Result();
        }

    }
}