using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class IconFontFontAwesomeController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: ThirdParty/IconFontFontAwesome
        public IActionResult Index()
        {
            return View();
        }

       
    }
}