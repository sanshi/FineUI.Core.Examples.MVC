using FineUI.Core.Examples.MVC.Areas.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FineUI.Core.Examples.MVC.Areas.DataModel.Controllers
{
    [Area("DataModel")]
    public class GridSortingQuickSortFieldController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: DataModel/GridSortingQuickSortField
        public IActionResult Index()
        {
            string sortField = "Gender";
            string sortDirection = "ASC";

            ViewBag.Grid1SortField = sortField;
            ViewBag.Grid1SortDirection = sortDirection;

            var students = GetSortedDataTable(sortField, sortDirection);

            return View(students);
        }
		
        private IList<Student> GetSortedDataTable(string sortField, string sortDirection)
        {
            var students = StudentHelper.GetSimpleStudentList().ToList();
            students.Sort((left, right) =>
            {
                if (sortField == "Name")
                {
                    return sortDirection == "ASC" ? left.Name.CompareTo(right.Name) : right.Name.CompareTo(left.Name);
                }
                else if (sortField == "Gender")
                {
                    return sortDirection == "ASC" ? left.Gender.CompareTo(right.Gender) : right.Gender.CompareTo(left.Gender);
                }
                else if (sortField == "EntranceYear")
                {
                    return sortDirection == "ASC" ? left.EntranceYear.CompareTo(right.EntranceYear) : right.EntranceYear.CompareTo(left.EntranceYear);
                }
                else if (sortField == "AtSchool")
                {
                    return sortDirection == "ASC" ? left.AtSchool.CompareTo(right.AtSchool) : right.AtSchool.CompareTo(left.AtSchool);
                }
                return 0;
            });

            return students;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_Sort(string[] Grid1_fields, string Grid1_sortField, string Grid1_sortDirection)
        {
            // 更新表格数据源
            UIHelper.Grid("Grid1").DataSource(GetSortedDataTable(Grid1_sortField, Grid1_sortDirection), Grid1_fields);

            return UIHelper.Result();
        }


    }
}