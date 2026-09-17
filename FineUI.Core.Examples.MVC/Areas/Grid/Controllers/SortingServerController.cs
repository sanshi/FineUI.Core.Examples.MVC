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
    public class SortingServerController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/SortingServer
        public IActionResult Index()
        {
            return View();
        }

        private DataView GetSortedDataView(string sortField, string sortDirection)
        {
            // 模拟数据排序
            DataTable table = DataSourceUtil.GetDataTable();
            DataView view1 = table.DefaultView;
            view1.Sort = String.Format("{0} {1}", sortField, sortDirection);

            return view1;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_Sort(string[] Grid1_fields, string Grid1_sortField, string Grid1_sortDirection)
        {
            // 更新表格数据源
            UIHelper.Grid("Grid1").DataSource(GetSortedDataView(Grid1_sortField, Grid1_sortDirection), Grid1_fields);

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Button2_Click(string[] fields)
        {
            var sortDirection = "DESC";
            var sortField = "EntranceYear";

            // 更新表格数据源
            UIHelper.Grid("Grid1").DataSource(GetSortedDataView(sortField, sortDirection), fields);

            // 设置排序字段和方向
            UIHelper.Grid("Grid1").SortField(sortField, sortDirection);

            return UIHelper.Result();
        }

    }
}