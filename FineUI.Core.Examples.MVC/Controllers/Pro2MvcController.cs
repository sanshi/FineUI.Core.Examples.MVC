using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace FineUI.Core.Examples.MVC.Controllers
{
    public class Pro2MvcController : Controller
    {
        // GET: Pro2Mvc
        public IActionResult Index()
        {
            return View();
        }
    }
}