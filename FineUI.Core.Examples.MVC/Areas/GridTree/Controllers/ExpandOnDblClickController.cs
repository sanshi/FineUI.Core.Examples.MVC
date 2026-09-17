using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridTree.Controllers
{
    [Area("GridTree")]
    public class ExpandOnDblClickController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridTree/ExpandOnDblClick
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_RowDoubleClick(JObject rowInfo)
        {
            ShowNotify(String.Format("你双击了第 {0} 行，行ID：{1}，名称：{2}",
                rowInfo.Value<int>("index"),
                rowInfo.Value<string>("id"),
                rowInfo.Value<string>("text")));

            return UIHelper.Result();
        }

    }
}