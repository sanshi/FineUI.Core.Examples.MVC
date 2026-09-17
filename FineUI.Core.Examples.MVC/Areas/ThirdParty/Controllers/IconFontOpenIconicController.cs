using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class IconFontOpenIconicController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: ThirdParty/IconFontOpenIconic
        public IActionResult Index()
        {
            return View();
        }

       
    }
}