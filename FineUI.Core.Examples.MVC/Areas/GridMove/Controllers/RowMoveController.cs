using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridMove.Controllers
{
    [Area("GridMove")]
    public class RowMoveController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridMove/RowMove
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            ViewBag.Grid1DataSource = GetSavedDataSource();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_RowMove(JArray rowIds)
        {
            DataTable originalTable = DataSourceUtil.GetDataTable();
            DataTable newTable = originalTable.Clone();

            foreach (string rowId in rowIds)
            {
                DataRow rowInOriginalTable = FindRow(rowId, originalTable);
                if (rowInOriginalTable != null)
                {
                    newTable.ImportRow(rowInOriginalTable);
                }
            }

            HttpContext.Session.SetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION, newTable);

            ShowNotify("数据保存成功！");

            return UIHelper.Result();
        }

        private DataRow FindRow(string rowId, DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row["Id"].ToString() == rowId)
                {
                    return row;
                }
            }
            return null;
        }

        #region Data

        private static readonly string KEY_FOR_DATASOURCE_SESSION = "GridMove.RowMove";

        // 模拟在服务器端保存数据
        // 特别注意：在真实的开发环境中，不要在Session放置大量数据，否则会严重影响服务器性能
        private DataTable GetSavedDataSource()
        {
            if (HttpContext.Session.GetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION) == null)
            {
                HttpContext.Session.SetObject(KEY_FOR_DATASOURCE_SESSION, DataSourceUtil.GetDataTable());
            }
            return HttpContext.Session.GetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION);
        }


        #endregion

    }
}