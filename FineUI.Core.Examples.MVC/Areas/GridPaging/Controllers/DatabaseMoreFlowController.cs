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
    public class DatabaseMoreFlowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        private static readonly int PAGESIZE = 5;

        // GET: GridPaging/DatabaseMoreFlow
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        #region BindGrid

        private void LoadData()
        {
            ViewBag.Grid1DataSource = DataSourceUtil.GetPagedDataTable(pageIndex: 0, pageSize: PAGESIZE);

        }

        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnMore_Click(string[] Grid1_fields, int dataIndex)
        {
            var grid1 = UIHelper.Grid("Grid1");

            dataIndex++;

            var pageCount = DataSourceUtil.GetPageCount(PAGESIZE);
            if (dataIndex <= pageCount - 1)
            {
                var dataSource = DataSourceUtil.GetPagedDataTable(pageIndex: dataIndex, pageSize: PAGESIZE);
                grid1.AppendData(dataSource, Grid1_fields); // 追加数据

                grid1.Attribute("data-index", dataIndex.ToString());
            }

            if (dataIndex == pageCount - 1)
            {
                PageContext.RegisterStartupScript("disableMoreButton();");
            }

            return UIHelper.Result();
        }

    }
}