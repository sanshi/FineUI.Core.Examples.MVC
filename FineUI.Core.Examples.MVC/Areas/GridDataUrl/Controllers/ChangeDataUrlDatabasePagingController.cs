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
    public class ChangeDataUrlDatabasePagingController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/ChangeDataUrlDatabasePaging
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string Grid1_sourceKey)
        {
            var grid1 = UIHelper.Grid("Grid1");

            // 重置为第一页
            grid1.PageIndex(0);

            if (Grid1_sourceKey == "source1")
            {
                grid1.Attribute("data-source-key", "source2");
                grid1.DataUrl(Url.Content("~/GridDataUrl/PagingDatabaseData?data2=true"));
            }
            else
            {
                grid1.Attribute("data-source-key", "source1");
                grid1.DataUrl(Url.Content("~/GridDataUrl/PagingDatabaseData"));
            }

            return UIHelper.Result();
        }

    }
}