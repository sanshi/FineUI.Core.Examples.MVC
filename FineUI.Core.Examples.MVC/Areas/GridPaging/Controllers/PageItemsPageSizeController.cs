using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class PageItemsPageSizeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/PageItemsPageSize
        public IActionResult Index()
        {
            return View();
        }


    }
}