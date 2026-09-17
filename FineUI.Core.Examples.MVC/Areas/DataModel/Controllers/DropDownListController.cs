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
    public class DropDownListController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/DropDownList
        public IActionResult Index()
        {
            var listItems = new List<ListItem>
            {
                new ListItem {
	                Text = "可选项1",
                    Value = "Value1"
                },
                new ListItem {
	                Text = "可选项2（不可选择）",
                    Value = "Value2",
	                EnableSelect = false
                },
                new ListItem {
	                Text = "可选项3（不可选择）",
                    Value = "Value3",
	                EnableSelect = false
                },
                new ListItem {
	                Text = "可选项4",
                    Value = "Value4"
                },
                new ListItem {
	                Text = "可选项5",
                    Value = "Value5"
                },
                new ListItem {
	                Text = "可选项6",
                    Value = "Value6"
                },
                new ListItem {
	                Text = "可选择项7",
                    Value = "Value7"
                },
                new ListItem {
	                Text = "可选择项8",
                    Value = "Value8"
                },
                new ListItem {
	                Text = "普通型1 < L > 1.5",
                    Value = "Value9"
                },
                new ListItem {
	                Text = "一个很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长很长的可选择项",
                    Value = "Value10"
                }
            };

            var model = new DropDownListModel();
            model.DropDownList1 = "Value5";
            model.DropDownList1Items = listItems;


            model.DropDownList2 = new string[] { "Value1", "Value5" };
            model.DropDownList2Items = listItems;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click([Bind("DropDownList1", "DropDownList2")]DropDownListModel model)
        {
            if (ModelState.IsValid)
            {
                ShowNotify(new RawHtml("用户提交的数据：<br/><pre>{0}</pre>", EncodeJson(model)));
            }

            return UIHelper.Result();
        }

    }
}