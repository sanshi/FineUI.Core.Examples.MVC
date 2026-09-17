using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridOther.Controllers
{
    [Area("GridOther")]
    public class NewTabSameTabConfirmController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/NewTabSameTabConfirm
        public IActionResult Index()
        {
            return View();
        }


    }
}