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
    public class GridPagingDatabaseBbarController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/GridPagingDatabaseBbar
        public IActionResult Index()
        {
            return View();
        }


    }
}