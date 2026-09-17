using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
	[Area("DataModel")]
    public class TreeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/Tree
        public IActionResult Index()
        {
            return View();
        }


        [BindProperty]
        public JArray CheckedNodes { get; set; }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetCheckedValues_Click()
        {
            var labResult = UIHelper.Label("labResult");

            if (CheckedNodes.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("复选框选中的节点：");
                sb.Append("<ul>");

                foreach (JObject checkedNode in CheckedNodes)
                {
                    sb.AppendFormat("<li>{0}（{1}）</li>", checkedNode.Value<string>("NodeText"), checkedNode.Value<string>("NodeId"));
                }

                sb.Append("</ul>");

                labResult.Text(sb.ToString());
            }
            else
            {
                labResult.Text("没有复选框选中的节点");
            }


            return UIHelper.Result();
        }
    }
}