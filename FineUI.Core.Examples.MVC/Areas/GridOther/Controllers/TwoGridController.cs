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
    public class TwoGridController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridOther/TwoGrid
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            DataTable classTable = DataSourceUtil.GetClassDataTable();
            int selectedRowId = (int)classTable.Rows[0]["Id"];

            ViewBag.Grid2DataSource = classTable;
            ViewBag.Grid2SelectedRowID = selectedRowId.ToString();
            ViewBag.SelectedClassDesc = GetClassDesc(selectedRowId, classTable);

            ViewBag.Grid1DataSource = GetClassDetailTable(selectedRowId);
        }

        private string GetClassDesc(int classId, DataTable classTable)
        {
            foreach (DataRow row in classTable.Rows)
            {
                int currentClassId = (int)row["Id"];
                if (classId == currentClassId)
                {
                    return "班级描述：" + row["Desc"].ToString();
                }
            }

            return String.Empty;
        }

        private DataTable GetClassDetailTable(int classId)
        {
            DataTable table = null;
            if (classId == 101)
            {
                table = DataSourceUtil.GetDataTable();
            }
            else
            {
                table = DataSourceUtil.GetDataTable2();
            }

            return table;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid2_RowSelect(string[] Grid1_fields, int selectedRowId)
        {
            DataTable classTable = DataSourceUtil.GetClassDataTable();
            UIHelper.Label("labelClassDesc").Text(GetClassDesc(selectedRowId, classTable));

            UIHelper.Grid("Grid1").DataSource(GetClassDetailTable(selectedRowId), Grid1_fields);

            return UIHelper.Result();
        }

    }
}