using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Form.Controllers
{
    [Area("Form")]
    public class ToolTipController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/ToolTip
        public IActionResult Index()
        {
            return View();
        }

    }
}