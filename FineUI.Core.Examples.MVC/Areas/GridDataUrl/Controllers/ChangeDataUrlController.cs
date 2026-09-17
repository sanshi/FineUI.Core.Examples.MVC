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
    public class ChangeDataUrlController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/ChangeDataUrl
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string Grid1_sourceKey)
        {
            var grid1 = UIHelper.Grid("Grid1");

            if (Grid1_sourceKey == "source1") {
                grid1.Attribute("data-source-key", "source2");
                grid1.DataUrl(Url.Content("~/GridDataUrl/GridDataUrlData?data2=true"));
            } else {
                grid1.Attribute("data-source-key", "source1");
                grid1.DataUrl(Url.Content("~/GridDataUrl/GridDataUrlData"));
            }

            return UIHelper.Result();
        }

    }
}