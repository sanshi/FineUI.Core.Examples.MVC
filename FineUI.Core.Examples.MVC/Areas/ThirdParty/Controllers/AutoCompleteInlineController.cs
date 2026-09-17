using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.ThirdParty.Controllers
{
    [Area("ThirdParty")]
    public class AutoCompleteInlineController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: ThirdParty/AutoCompleteInline
        public IActionResult Index()
        {
            return View();
        }


    }
}