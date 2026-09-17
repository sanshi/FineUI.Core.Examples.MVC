using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridTree.Controllers
{
    [Area("GridTree")]
    public class ContextMenuController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridTree/ContextMenu
        public IActionResult Index()
        {
            return View();
        }


    }
}