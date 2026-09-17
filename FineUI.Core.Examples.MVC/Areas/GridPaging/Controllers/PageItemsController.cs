using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class PageItemsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/PageItems
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClearData_Click()
        {
            UIHelper.Grid("Grid1").DataSource(null);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRebindData_Click(string[] fields)
        {
            UIHelper.Grid("Grid1").DataSource(DataSourceUtil.GetDataTable2(), fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSelectAll_Click()
        {
            UIHelper.Grid("Grid1").SelectAllRows();

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClearSelect_Click()
        {
            UIHelper.Grid("Grid1").DeselectAllRows();

            return UIHelper.Result();
        }

    }
}