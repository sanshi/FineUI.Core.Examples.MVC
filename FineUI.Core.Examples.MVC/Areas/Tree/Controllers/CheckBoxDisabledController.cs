using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class CheckBoxDisabledController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/CheckBoxDisabled
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
                sb.Append("复选框选中的节点：");
                sb.Append("<ul>");

                foreach (JObject checkedNode in checkedNodes)
                {
                    sb.AppendFormat("<li>{0}（{1}）</li>", checkedNode.Value<string>("text"), checkedNode.Value<string>("id"));
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
