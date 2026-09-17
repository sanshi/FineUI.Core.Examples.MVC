using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class Grid2Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/Grid2
        public IActionResult Index()
        {
            Students = StudentHelper.GetSimpleStudentList();

            return View(this);
        }


        public IList<Student> Students { get; set; }

    }
}