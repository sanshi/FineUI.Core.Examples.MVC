using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridNav.Controllers
{
    [Area("GridNav")]
    public class VerticalTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridNav/VerticalTab
        public IActionResult Index()
        {
            return View();
        }



    }
}