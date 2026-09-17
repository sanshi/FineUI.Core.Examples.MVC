using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.FormLayout.Controllers
{
    [Area("FormLayout")]
    public class LayoutContactUsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: FormLayout/LayoutContactUs
        public IActionResult Index()
        {
            return View();
        }

    }
}