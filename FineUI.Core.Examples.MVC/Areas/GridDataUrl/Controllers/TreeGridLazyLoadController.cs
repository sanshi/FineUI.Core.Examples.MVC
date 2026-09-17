using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridDataUrl.Controllers
{
    [Area("GridDataUrl")]
    public class TreeGridLazyLoadController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/TreeGridLazyLoad
        public IActionResult Index()
        {
            return View();
        }


    }
}