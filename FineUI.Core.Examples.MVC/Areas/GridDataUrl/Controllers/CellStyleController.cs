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
    public class CellStyleController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDataUrl/CellStyle
        public IActionResult Index()
        {
            return View();
        }


    }
}