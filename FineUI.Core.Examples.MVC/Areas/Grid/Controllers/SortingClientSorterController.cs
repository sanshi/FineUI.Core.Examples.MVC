using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class SortingClientSorterController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/SortingClientSorter
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = DataSourceUtil.GetDataTable();

            return View();
        }

    }
}