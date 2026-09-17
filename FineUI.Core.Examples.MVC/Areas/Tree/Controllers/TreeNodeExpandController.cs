using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeNodeExpandController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeNodeExpand
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Tree1_NodeExpand(JObject nodeInfo)
        {
            UIHelper.Label("labResult").Text(String.Format("展开节点：{0}（{1}）", nodeInfo.Value<string>("id"), nodeInfo.Value<string>("text")));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Tree1_NodeCollapse(JObject nodeInfo)
        {
            UIHelper.Label("labResult").Text(String.Format("折叠节点：{0}（{1}）", nodeInfo.Value<string>("id"), nodeInfo.Value<string>("text")));

            return UIHelper.Result();
        }

    }
}