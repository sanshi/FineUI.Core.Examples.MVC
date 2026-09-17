using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
	[Area("Grid")]
    public class HeaderToolTipController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/HeaderToolTip
        public IActionResult Index()
        {
            return View();
        }

        
    }
}