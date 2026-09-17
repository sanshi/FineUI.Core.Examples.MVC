using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using FineUI.Core.Examples.MVC.Areas.DataModel.Models;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
	[Area("DataModel")]
    public class TreeNodeInfoController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/TreeNodeInfo
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetCheckedValues_Click(IList<TreeNodeInfo> checkedNodes)
        {
            var labResult = UIHelper.Label("labResult");

            if (checkedNodes != null && checkedNodes.Count() > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("复选框选中的节点：");
                sb.Append("<ul>");

                foreach (TreeNodeInfo checkedNode in checkedNodes)
                {
                    sb.AppendFormat("<li>{0}（{1}）</li>", checkedNode.NodeText, checkedNode.NodeId);
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