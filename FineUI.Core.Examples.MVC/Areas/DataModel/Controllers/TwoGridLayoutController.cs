using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class TwoGridLayoutController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/TwoGridLayout
        public IActionResult Index()
        {
            var students = StudentHelper.GetSimpleStudentList();
            var model = new Tuple<IList<Student>, IList<Student>>(students.Where(m => m.AtSchool).ToList(), students.Where(m => !m.AtSchool).ToList());
            return View(model);
        }


    }
}