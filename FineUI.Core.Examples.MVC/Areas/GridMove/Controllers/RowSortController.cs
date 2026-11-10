using System;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FineUI.Core.Examples.MVC.Areas.GridMove.Controllers
{
    [Area("GridMove")]
    public class RowSortController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        private const string SavedOrderSessionKey = "GridMove.RowSort";

        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = LoadData(HttpContext.Session.GetObject<string[]>(SavedOrderSessionKey));
            return View();
        }

        private static DataTable LoadData(string[] savedOrder)
        {
            var students = DataSourceUtil.GetDataTable();
            if (savedOrder == null)
            {
                return students;
            }

            // 只保存行 ID。新加入的学生若没有保存位置，按初始顺序追加在已排序学生之后。
            var sortedStudents = students.Clone();
            var sortedRows = students.Rows.Cast<DataRow>().OrderBy(row =>
            {
                int index = Array.IndexOf(savedOrder, row["Id"].ToString());
                return index >= 0 ? index : int.MaxValue;
            });
            foreach (var row in sortedRows)
            {
                sortedStudents.ImportRow(row);
            }
            return sortedStudents;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSaveToDB_Click(JArray rowIds)
        {
            HttpContext.Session.SetObject(SavedOrderSessionKey, rowIds.ToObject<string[]>());
            ShowNotify("数据保存成功！");
            return UIHelper.Result();
        }
    }
}
