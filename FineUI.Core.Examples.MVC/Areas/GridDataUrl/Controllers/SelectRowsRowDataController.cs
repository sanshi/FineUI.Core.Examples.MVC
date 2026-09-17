using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridDataUrl.Controllers
{
    [Area("GridDataUrl")]
    public class SelectRowsRowDataController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/SelectRowsRowData
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click()
        {
            UIHelper.Grid("Grid1").SelectedRowIDArray("102", "106", "108");

            return UIHelper.Result();
        }

    }
}