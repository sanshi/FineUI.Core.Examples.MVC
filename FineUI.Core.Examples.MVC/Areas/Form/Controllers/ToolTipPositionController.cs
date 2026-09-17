using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
	[Area("Form")]
    public class ToolTipPositionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Form/ToolTipPosition
        public IActionResult Index()
        {
            return View();
        }

    }
}