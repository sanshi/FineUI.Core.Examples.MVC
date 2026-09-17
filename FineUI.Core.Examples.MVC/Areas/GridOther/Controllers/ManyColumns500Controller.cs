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
    public class ManyColumns500Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/ManyColumns
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            DataTable table = DataSourceUtil.GetDataTable();

            int newtableID = 101;
            DataTable newtable = table.Clone();
            for (int i = 0; i <= 41; i++)
            {
                foreach (DataRow row in table.Rows)
                {
                    row["Id"] = newtableID;
                    newtable.ImportRow(row);

                    newtableID++;
                }
            }

            ViewBag.Grid1DataSource = newtable;
        }



    }
}