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
    public class HideColumnController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/HideColumn
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button3_Click(bool genderHidden)
        {
            var grid1 = UIHelper.Grid("Grid1");
            if (genderHidden)
            {
                grid1.ShowColumn("Gender");
            }
            else
            {
                grid1.HideColumn("Gender");
            }

            return UIHelper.Result();
        }

    }
}