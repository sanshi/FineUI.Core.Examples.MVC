using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridRowGroup.Controllers
{
    [Area("GridDelayRender")]
    public class Grid1000RowHeightController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridDelayRender/Grid1000RowHeight
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
            for (int i = 0; i <= 82; i++)
            {
                foreach (DataRow row in table.Rows)
                {
                    newtable.ImportRow(row);

                    var newImportedRow = newtable.Rows[newtable.Rows.Count - 1];
                    newImportedRow["Id"] = newtableID;
                    if (i > 0)
                    {
                        newImportedRow["Name"] = String.Format("{0}（{1}）", newImportedRow["Name"], i);
                    }

                    newtableID++;
                }
            }

            ViewBag.Grid1DataSource = newtable;
        }



    }
}