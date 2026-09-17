using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeLazyLoadController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeLazyLoad
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Tree1_NodeLazyLoad(string nodeId)
        {
            List<TreeNode> nodes = DynamicAppendNode(nodeId);

            UIHelper.Tree("Tree1").LoadData(nodeId, nodes);

            return UIHelper.Result();
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


        private List<TreeNode> DynamicAppendNode(string nodeId)
        {
            List<TreeNode> nodes = new List<TreeNode>();

            TreeNode node = null;
            switch (nodeId)
            {
                case "zhumadian":
                    node = new TreeNode();
                    node.Text = "遂平县（延迟加载）";
                    node.Leaf = false;
                    node.NodeID = "suiping";
                    nodes.Add(node);

                    node = new TreeNode();
                    node.Text = "西平县";
                    node.Leaf = true;
                    node.NodeID = "xiping";
                    nodes.Add(node);
                    break;
                case "suiping":
                    node = new TreeNode();
                    node.Text = "槐树乡（延迟加载）";
                    node.Leaf = false;
                    node.NodeID = "huaishu";
                    nodes.Add(node);

                    node = new TreeNode();
                    node.Text = "嵖岈山乡";
                    node.Leaf = true;
                    node.NodeID = "chayashan";
                    nodes.Add(node);
                    break;
                case "huaishu":
                    node = new TreeNode();
                    node.Text = "陈庄村";
                    node.Leaf = true;
                    node.NodeID = "chenzhuang";
                    nodes.Add(node);

                    node = new TreeNode();
                    node.Text = "王老庄";
                    node.Leaf = true;
                    node.NodeID = "wanglaozhuang";
                    nodes.Add(node);
                    break;
            }

            return nodes;
        }

    }
}