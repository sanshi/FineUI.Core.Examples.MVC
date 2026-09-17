using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class FormWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/FormWindow
        public IActionResult Index()
        {
            return View();
        }


    }
}