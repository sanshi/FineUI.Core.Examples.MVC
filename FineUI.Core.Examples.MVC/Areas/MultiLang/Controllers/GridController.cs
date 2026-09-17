using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class GridController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/Grid
        public IActionResult Index()
        {
            return View();
        }



    }
}