using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class SortingClientMultiController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/SortingClientMulti
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            string[] sortFields = new string[] { "Gender", "ASC" };

            ViewBag.Grid1DataSource = GetSortedDataTable(sortFields);

            ViewBag.Grid1SortFields = sortFields;
        }

        private DataTable GetSortedDataTable(string[] sortFields)
        {
            List<string> sortItems = new List<string>();
            for (var i = 0; i < sortFields.Length; i += 2)
            {
                sortItems.Add(String.Format("{0} {1}", sortFields[i], sortFields[i + 1]));
            }

            DataTable table = DataSourceUtil.GetDataTable();
            DataView view1 = table.DefaultView;
            view1.Sort = String.Join(", ", sortItems);

            return view1.ToTable();
        }


    }
}