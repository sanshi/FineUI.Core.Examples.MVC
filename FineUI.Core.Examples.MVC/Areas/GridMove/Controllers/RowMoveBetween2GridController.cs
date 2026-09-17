using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Text;


namespace FineUI.Core.Examples.MVC.Areas.GridMove.Controllers
{
    [Area("GridMove")]
    public class RowMoveBetween2GridController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridMove/RowMoveBetween2Grid
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnCheckSelected_Click(JArray columnNames)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>");
            foreach (JObject item in columnNames)
            {
                sb.AppendFormat("<li>ID:{0} Name:{1}</li>", item.Value<string>("id"), item.Value<string>("name"));
            }
            sb.Append("</ul>");

            ShowNotify(new RawHtml("已选择列表：" + sb.ToString()), MessageBoxIcon.None);

            return UIHelper.Result();
        }

    }
}