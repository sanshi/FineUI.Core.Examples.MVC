using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeSelectMultiSelectableSelectedController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeSelectMultiSelectableSelected
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelectedValues_Click(JArray selectedNodes)
        {
            var labResult = UIHelper.Label("labResult");

            if (selectedNodes.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("选中的节点：");
                sb.Append("<ul>");

                foreach (JObject node in selectedNodes)
                {
                    sb.AppendFormat("<li>{0}（{1}）</li>", node.Value<string>("text"), node.Value<string>("id"));
                }

                sb.Append("</ul>");

                labResult.Text(sb.ToString());
            }
            else
            {
                labResult.Text("没有选中的节点");
            }


            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectOthers_Click(string selectedNodes)
        {
            UIHelper.Tree("Tree1").SelectedNodeIDArray(true, "hefei", "huangshan");

            return UIHelper.Result();
        }

    }
}