using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridPaging.Controllers
{
    [Area("GridPaging")]
    public class PageItemsPageSizeDatabaseController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridPaging/PageItemsPageSizeDatabase
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        #region BindGrid

        private void LoadData()
        {
            var recordCount = DataSourceUtil.GetTotalCount();

            // 1.设置总项数（特别注意：数据库分页初始化时，一定要设置总记录数RecordCount）
            ViewBag.Grid1RecordCount = recordCount;

            // 2.获取当前分页数据
            ViewBag.Grid1DataSource = DataSourceUtil.GetPagedDataTable(pageIndex: 0, pageSize: 5);

        }

        #endregion


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_ReBindGrid(string[] fields, int pageIndex, int pageSize)
        {
            var grid1 = UIHelper.Grid("Grid1");

            var recordCount = DataSourceUtil.GetTotalCount();

            // 1.设置总项数（数据库分页回发时，如果总记录数不变，可以不设置RecordCount）
            grid1.RecordCount(recordCount);

            // 2. 设置每页显示项数（每页记录数改变时，要设置PageSize）
            grid1.PageSize(pageSize);

            // 3.获取当前分页数据
            var dataSource = DataSourceUtil.GetPagedDataTable(pageIndex: pageIndex, pageSize: pageSize);
            grid1.DataSource(dataSource, fields);

            return UIHelper.Result();
        }

    }
}