using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeNodeClickContextMenuController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeNodeClickContextMenu
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Tree1_NodeClick(string nodeId, string nodeText)
        {
            UIHelper.Label("labResult").Text(String.Format("你点击了树节点：{0}（{1}）", nodeId, nodeText));

            return UIHelper.Result();
        }

    }
}