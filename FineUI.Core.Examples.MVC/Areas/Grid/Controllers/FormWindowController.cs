using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.Grid.Controllers
{
    [Area("Grid")]
    public class FormWindowController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Grid/FormWindow
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            ViewBag.Grid1DataSource = GetSourceData();
        }


        // 删除选中行：行标识由客户端随自定义回发送上来，不用再让服务端从回发状态里反推
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_DeleteRows(string[] Grid1_fields, string[] selectedRows)
        {
            DataTable source = GetSourceData();

            foreach (string rowId in selectedRows)
            {
                DeleteRowByID(source, Convert.ToInt32(rowId));
            }

            SaveSourceData(source);

            UIHelper.Grid("Grid1").DataSource(source, Grid1_fields);

            ShowNotify("删除数据成功!（表格数据已重新绑定）");

            return UIHelper.Result();
        }


        // 保存数据：表单里带行标识就是编辑，不带就是新增
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSave_Click(string[] Grid1_fields, IFormCollection values)
        {
            DataTable source = GetSourceData();

            string strRowID = values["hfFormID"];
            DataRow rowData;
            if (String.IsNullOrEmpty(strRowID))
            {
                // 新增
                rowData = source.NewRow();

                // 设置行ID（模拟数据库的自增长列）
                rowData["Id"] = GetNextRowID(source);

                source.Rows.Add(rowData);
            }
            else
            {
                // 编辑
                rowData = FindRowByID(source, Convert.ToInt32(strRowID));
            }

            // 把表单字段写回数据行
            // 姓名
            rowData["Name"] = values["tbxFormUserName"].ToString().Trim();
            // 性别
            rowData["Gender"] = Convert.ToInt32(values["rblFormGender"]);
            // 入学年份
            rowData["EntranceYear"] = Convert.ToInt32(values["nbFormEntranceYear"]);
            // 入学日期
            rowData["EntranceDate"] = values["dpFormEntranceDate"].ToString();
            // 是否在校
            rowData["AtSchool"] = Convert.ToBoolean(values["cbFormAtSchool"]);
            // 所学专业
            rowData["Major"] = values["ddlFormMajor"].ToString();

            SaveSourceData(source);

            // 重绑表格必须带上表格的字段列表（客户端随回包一起发上来的 Grid1_fields）：
            // 服务端要靠它把数据行投影成 JSON，缺了它客户端收到的每一行都是空的
            UIHelper.Grid("Grid1").DataSource(source, Grid1_fields);

            // 重新绑定表格，选中刚保存的那一行，并关闭弹出窗体
            RegisterStartupScript(String.Format("F.ui.Grid1.selectRow('{0}');", rowData["Id"]));
            UIHelper.Window("Window1").Hide();

            return UIHelper.Result();
        }


        #region Data

        private static readonly string KEY_FOR_DATASOURCE_SESSION = "Grid.FormWindow";

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
