using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.IFrame.Controllers
{
    [Area("IFrame")]
    public class GridIFrameController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/GridIFrame
        public IActionResult Index()
        {
            return View();
        }

        private void AutoBindGrid(string Grid1_sourceKey, string[] Grid1_fields)
        {
            var grid1 = UIHelper.Grid("Grid1");

            DataTable source = null;
            if (Grid1_sourceKey == "table1")
            {
                source = DataSourceUtil.GetDataTable2();
                Grid1_sourceKey = "table2";
            }
            else
            {
                source = DataSourceUtil.GetDataTable();
                Grid1_sourceKey = "table1";
            }

            grid1.DataSource(source, Grid1_fields);
            grid1.Attribute("data-source-key", Grid1_sourceKey);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyCustomPostBack(string type, string Grid1_sourceKey, string[] Grid1_fields, JObject typeParams)
        {
            // 重新绑定表格数据（模拟）
            AutoBindGrid(Grid1_sourceKey, Grid1_fields);

            var ttbSearch = UIHelper.TwinTriggerBox("ttbSearch");
            if (type == "trigger1")
            {
                ttbSearch.Text(String.Empty);
                ttbSearch.ShowTrigger1(false);

                ShowNotify("取消检索关键词");
            }
            else if (type == "trigger2")
            {
                ttbSearch.ShowTrigger1(true);

                var triggerValue = typeParams.Value<string>("triggerValue");
                ShowNotify("检索关键词：" + triggerValue);
            }
            else if (type == "dropdownlist")
            {
                var ddlValue = typeParams.Value<string>("ddlValue");
                ShowNotify("检索下拉列表值：" + ddlValue);
            }
            else if (type == "windowclose")
            {
                ShowNotify("窗体关闭了！");
            }
            

            return UIHelper.Result();
        }

        

    }
}