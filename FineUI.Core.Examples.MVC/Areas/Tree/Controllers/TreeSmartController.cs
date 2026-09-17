using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Tree.Controllers
{
    [Area("Tree")]
    public class TreeSmartController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Tree/TreeSmart
        public IActionResult Index()
        {
            return View();
        }


    }
}