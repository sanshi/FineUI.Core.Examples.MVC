using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridEditor.Controllers
{
    [Area("GridEditor")]
    public class SelectFromWindowIFrameWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridEditor/SelectFromWindowIFrameWindow
        public IActionResult Index()
        {
            return View();
        }

    }
}