using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class WebUploaderTabsController : FineUI.Core.Examples.MVC.Controllers.BaseWebUploaderController
    {
        private static readonly string KEY_FOR_DATASOURCE_1_SESSION = "webuploader.webuploader_tabs.1";
        private static readonly string KEY_FOR_DATASOURCE_2_SESSION = "webuploader.webuploader_tabs.2";

        // GET: ThirdParty/WebUploaderMulti
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = GetSourceData(KEY_FOR_DATASOURCE_1_SESSION);
            ViewBag.Grid2DataSource = GetSourceData(KEY_FOR_DATASOURCE_2_SESSION);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_DeleteRow(string rowId, string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            DeleteRow(KEY_FOR_DATASOURCE_1_SESSION, rowId);
            grid1.DataSource(GetSourceData(KEY_FOR_DATASOURCE_1_SESSION), Grid1_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid2_DeleteRow(string rowId, string[] Grid2_fields)
        {
            var grid2 = UIHelper.Grid("Grid2");

            DeleteRow(KEY_FOR_DATASOURCE_2_SESSION, rowId);
            grid2.DataSource(GetSourceData(KEY_FOR_DATASOURCE_2_SESSION), Grid2_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RebindGrid1(string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            grid1.DataSource(GetSourceData(KEY_FOR_DATASOURCE_1_SESSION), Grid1_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RebindGrid2(string[] Grid2_fields)
        {
            var grid2 = UIHelper.Grid("Grid2");

            grid2.DataSource(GetSourceData(KEY_FOR_DATASOURCE_2_SESSION), Grid2_fields);

            return UIHelper.Result();
        }

    }
}
