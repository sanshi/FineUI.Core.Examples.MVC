using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class FormWindowCellEditController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/FormWindowCellEdit
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            ViewBag.Grid1DataSource = GetSourceData();
        }


        // 保存数据：客户端的改动一次性提交上来，按行状态分别处理
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSaveAll_Click(string[] Grid1_fields, JArray Grid1_modifiedData)
        {
            if (Grid1_modifiedData.Count == 0)
            {
                UIHelper.Label("labResult").Text("");
                ShowNotify("表格数据没有变化！");

                return UIHelper.Result();
            }

            DataTable source = GetSourceData();

            // 修改与删除先处理；新增行要等删除处理完，行序才与客户端一致
            foreach (JObject modifiedRow in Grid1_modifiedData)
            {
                string status = modifiedRow.Value<string>("status");

                if (status == "modified")
                {
                    int rowId = Convert.ToInt32(modifiedRow.Value<string>("id"));
                    DataRow rowData = FindRowByID(source, rowId);

                    UpdateDataRow(modifiedRow, rowData);
                }
                else if (status == "deleted")
                {
                    DeleteRowByID(source, Convert.ToInt32(modifiedRow.Value<string>("id")));
                }
            }


            // 新增行：客户端把它放在第几行，回发数据的 index 就是几，服务端照着插
            // （前提是表格不分页、也没在客户端排过序，否则 index 与数据源的行序对不上）
            foreach (JObject modifiedRow in Grid1_modifiedData)
            {
                if (modifiedRow.Value<string>("status") == "newadded")
                {
                    source.Rows.InsertAt(CreateNewData(source, modifiedRow), modifiedRow.Value<int>("index"));
                }
            }

            UIHelper.Label("labResult").Text(String.Format("用户修改的数据：<pre>{0}</pre>", EncodeJson(Grid1_modifiedData)));

            SaveSourceData(source);

            UIHelper.Grid("Grid1").DataSource(source, Grid1_fields);

            ShowNotify("数据保存成功！（表格数据已重新绑定）");

            return UIHelper.Result();
        }


        // 把一行改动过的单元格写进数据行（列名与表格列的 ColumnID 一致）
        private DataRow CreateNewData(DataTable source, JObject modifiedRow)
        {
            DataRow rowData = source.NewRow();

            // 设置行ID（模拟数据库的自增长列）
            rowData["Id"] = GetNextRowID(source);
            UpdateDataRow(modifiedRow, rowData);

            return rowData;
        }

        private void UpdateDataRow(JObject modifiedRow, DataRow rowData)
        {
            Dictionary<string, object> rowDict = modifiedRow.Value<JObject>("values").ToObject<Dictionary<string, object>>();

            UpdateDataRow("Name", rowDict, rowData);
            UpdateDataRow("Gender", rowDict, rowData);
            UpdateDataRow("EntranceYear", rowDict, rowData);
            UpdateDataRow("EntranceDate", rowDict, rowData);
            UpdateDataRow("AtSchool", rowDict, rowData);
            UpdateDataRow("Major", rowDict, rowData);
        }


        #region Data

        private static readonly string KEY_FOR_DATASOURCE_SESSION = "Grid.FormWindowCellEdit";

        // 模拟在服务器端保存数据
        // 特别注意：在真实的开发环境中，不要在Session放置大量数据，否则会严重影响服务器性能
        private DataTable GetSourceData()
        {
            if (HttpContext.Session.GetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION) == null)
            {
                HttpContext.Session.SetObject(KEY_FOR_DATASOURCE_SESSION, DataSourceUtil.GetDataTable());
            }
            return HttpContext.Session.GetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION);
        }

        private void SaveSourceData(DataTable source)
        {
            HttpContext.Session.SetObject<DataTable>(KEY_FOR_DATASOURCE_SESSION, source);
        }

        #endregion

    }
}
