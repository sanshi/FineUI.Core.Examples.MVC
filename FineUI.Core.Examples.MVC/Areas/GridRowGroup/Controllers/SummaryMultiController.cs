using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridRowGroup
{
    [Area("GridRowGroup")]
    public class SummaryMultiController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridRowGroup/SummaryMulti
        public IActionResult Index()
        {
            return View();
        }
    }
}