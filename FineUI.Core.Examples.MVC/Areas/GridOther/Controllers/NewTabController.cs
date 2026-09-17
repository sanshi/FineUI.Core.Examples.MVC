using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridOther.Controllers
{
    [Area("GridOther")]
    public class NewTabController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/NewTab
        public IActionResult Index()
        {
            return View();
        }

        // GET: GridOther/NewTab/Window
        public IActionResult Window()
        {
            return View();
        }


    }
}