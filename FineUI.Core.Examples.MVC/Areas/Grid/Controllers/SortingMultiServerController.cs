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
    public class SortingMultiServerController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/SortingMultiServer
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

            ViewBag.SortTip = GetSortTip(sortFields);
        }


        private string GetSortFieldTip(string sortField, string sortDirection)
        {
            return String.Format("{0}（{1}）", sortField, sortDirection == "ASC" ? "升序" : "降序");
        }

        private string GetSortTip(string[] sortFields)
        {
            List<string> sortTips = new List<string>();

            // 多列排序
            if (sortFields != null && sortFields.Length > 0)
            {
                for (var i = 0; i < sortFields.Length; i += 2)
                {
                    var sortField = sortFields[i];
                    var sortDirection = sortFields[i + 1];

                    sortTips.Add(GetSortFieldTip(sortField, sortDirection));
                }
            }

            return String.Format("排序字段：{0}", String.Join("，", sortTips));
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_Sort(string[] Grid1_fields, string[] Grid1_sortFields)
        {
            DataTable table;
            // 多列排序
            if (Grid1_sortFields != null && Grid1_sortFields.Length > 0)
            {
                table = GetSortedDataTable(Grid1_sortFields);
            }
            else
            {
                table = DataSourceUtil.GetDataTable();
            }
            // 更新表格数据源
            UIHelper.Grid("Grid1").DataSource(table, Grid1_fields);

            UIHelper.Label("labSortOrderTip").Text(GetSortTip(Grid1_sortFields));

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string[] fields)
        {
            var sortFields = new string[] { "EntranceYear", "ASC", "Name", "DESC" };

            // 更新表格数据源
            UIHelper.Grid("Grid1").DataSource(GetSortedDataTable(sortFields), fields);

            // 设置排序字段和方向
            UIHelper.Grid("Grid1").SortFieldArray(sortFields);


            UIHelper.Label("labSortOrderTip").Text(GetSortTip(sortFields));

            return UIHelper.Result();
        }


    }
}