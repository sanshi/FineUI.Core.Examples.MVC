using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Button.Controllers
{
    [Area("Button")]
    public class ButtonGroupController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Button/ButtonGroup
        public IActionResult Index()
        {
            return View();
        }


       

    }
}