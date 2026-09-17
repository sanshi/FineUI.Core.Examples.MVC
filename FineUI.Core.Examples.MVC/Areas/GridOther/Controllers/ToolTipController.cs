using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridOther.Controllers
{
    [Area("GridOther")]
    public class ToolTipController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/ToolTip
        public IActionResult Index()
        {
            // 修改最后一行的数据
            DataTable table = DataSourceUtil.GetDataTable();
            DataRow lastRow = table.Rows[table.Rows.Count - 1];
            lastRow["Major"] = "<b>" + lastRow["Major"] + "&</b>";
            ViewBag.Grid1DataSource = table;

            return View();
        }



    }
}