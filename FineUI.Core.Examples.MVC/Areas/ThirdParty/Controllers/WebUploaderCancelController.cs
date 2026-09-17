using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class WebUploaderCancelController : FineUI.Core.Examples.MVC.Controllers.BaseWebUploaderController
    {
        private static readonly string KEY_FOR_DATASOURCE_SESSION = "webuploader.webuploader_cancel";

        // GET: ThirdParty/WebUploader
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = GetSourceData(KEY_FOR_DATASOURCE_SESSION);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_DeleteRow(string rowId, string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            DeleteRow(KEY_FOR_DATASOURCE_SESSION, rowId);
            grid1.DataSource(GetSourceData(KEY_FOR_DATASOURCE_SESSION), Grid1_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_DeleteRows(string[] deletedRowIDs, string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            foreach (var rowId in deletedRowIDs)
            {
                DeleteRow(KEY_FOR_DATASOURCE_SESSION, rowId);
            }

            grid1.DataSource(GetSourceData(KEY_FOR_DATASOURCE_SESSION), Grid1_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RebindGrid(string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            grid1.DataSource(GetSourceData(KEY_FOR_DATASOURCE_SESSION), Grid1_fields);

            return UIHelper.Result();
        }

    }
}
