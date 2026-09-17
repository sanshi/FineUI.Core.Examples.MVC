using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
	[Area("DataModel")]
    public class ComplexColumnClientController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/ComplexColumnClient
        public IActionResult Index()
        {
            return View(StudentHelper.GetSimpleStudentList<StudentExtended>());
        }


    }
}