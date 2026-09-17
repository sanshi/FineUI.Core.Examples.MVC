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
    public class FormWindowCellEditController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/FormWindowCellEdit
        public IActionResult Index()
        {
            return View();
        }


    }
}