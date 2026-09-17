using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class StyleColumnClassController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/StyleColumnClass
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button1_Click(string[] fields, string source)
        {
            var grid1 = UIHelper.Grid("Grid1");

            if (source == "source1")
            {
                grid1.DataSource(DataSourceUtil.GetDataTable2(), fields);
                grid1.Attribute("data-source-key", "source2");
            }
            else
            {
                grid1.DataSource(DataSourceUtil.GetDataTable(), fields);
                grid1.Attribute("data-source-key", "source1");
            }

            return UIHelper.Result();
        }

    }
}