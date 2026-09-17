using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class TreeCheckBoxController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/TreeCheckBox
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetCheckedValues_Click(JArray checkedNodes)
        {
            var labResult = UIHelper.Label("labResult");

            if (checkedNodes.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(_R("复选框选中的节点："));
                sb.Append("<ul>");

                foreach (JObject checkedNode in checkedNodes)
                {
                    sb.Append(_R("<li>{0}（{1}）</li>", checkedNode.Value<string>("text"), checkedNode.Value<string>("id")));
                }

                sb.Append("</ul>");
                
                labResult.Text(sb.ToString());
            }
            else
            {
                labResult.Text(_R("没有复选框选中的节点"));
            }


            return UIHelper.Result();
        }

    }
}