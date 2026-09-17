using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeIconFontController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeIconFont
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnGetSelectedNode_Click(JObject selectedNode)
        {
            var labResult = UIHelper.Label("labResult");

            if (selectedNode.Count > 0)
            {
                labResult.Text(String.Format("选中的节点：{0}（{1}）", selectedNode.Value<string>("text"), selectedNode.Value<string>("id")));
            }
            else
            {
                labResult.Text("没有选中节点");
            }

            return UIHelper.Result();
        }

    }
}