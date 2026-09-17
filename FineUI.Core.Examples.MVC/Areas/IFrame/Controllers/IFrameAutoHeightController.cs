using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class IFrameAutoHeightController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/IFrameAutoHeight
        public IActionResult Index()
        {
            return View();
        }


    }
}