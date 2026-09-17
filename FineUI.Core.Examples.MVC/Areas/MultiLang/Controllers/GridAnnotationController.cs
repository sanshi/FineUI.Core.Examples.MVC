using FineUI.Core.Examples.MVC.Areas.MultiLang.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.MultiLang.Controllers
{
    [Area("MultiLang")]
    public class GridAnnotationController : FineUI.Core.Examples.MVC.Controllers.BaseMultilangController
    {
        // GET: MultiLang/GridAnnotation
        public IActionResult Index()
        {
            return View(StudentHelper.GetSimpleStudentList());
        }


    }
}