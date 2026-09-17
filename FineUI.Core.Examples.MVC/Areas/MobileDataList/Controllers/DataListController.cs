using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileDataList.Controllers
{
    [Area("MobileDataList")]
    public class DataListController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileDataList/DataList
        public IActionResult Index()
        {
            return View();
        }


    }
}