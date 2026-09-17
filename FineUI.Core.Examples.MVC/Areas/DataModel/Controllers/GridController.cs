using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class GridController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/Grid
        public IActionResult Index()
        {
            return View(StudentHelper.GetSimpleStudentList());
        }


    }
}