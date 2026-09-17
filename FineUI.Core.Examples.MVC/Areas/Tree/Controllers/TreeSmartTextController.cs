using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
	[Area("Tree")]
    public class TreeSmartTextController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeSmartText
        public IActionResult Index()
        {
            return View();
        }

    }
}