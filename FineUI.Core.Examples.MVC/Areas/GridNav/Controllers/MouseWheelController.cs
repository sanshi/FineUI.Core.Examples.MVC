using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridNav.Controllers
{
    [Area("GridNav")]
    public class MouseWheelController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridNav/MouseWheel
        public IActionResult Index()
        {
            return View();
        }


    }
}