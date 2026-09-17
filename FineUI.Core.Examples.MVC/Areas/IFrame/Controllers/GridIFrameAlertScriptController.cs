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
    public class GridIFrameAlertScriptController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: IFrame/GridIFrameAlertScript
        public IActionResult Index()
        {
            return View();
        }

        // GET: IFrame/GridIFrameAlertScript/IFrameWindow
        public IActionResult IFrameWindow()
        {
            return View();
        }


        private void AutoBindGrid(string Grid1_sourceKey, string[] Grid1_fields, string Window1_closeArgument)
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

            grid1.Title("表格 - 回发参数：" + Window1_closeArgument);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyCustomPostBack(string type, string Grid1_sourceKey, string[] Grid1_fields, string Window1_closeArgument)
        {
            // 重新绑定表格数据（模拟）
            AutoBindGrid(Grid1_sourceKey, Grid1_fields, Window1_closeArgument);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnUpdateParentGrid_Click()
        {
            // 1. 这里放置保存窗体中数据的逻辑

            
            // 2. 先弹出提示对话框，再回发父窗体
            string scripts = String.Format("doCustomPostBack('{0}');", "参数 - " + DateTime.Now.Millisecond);
            Alert.ShowInTop("保存成功！", String.Empty, MessageBoxIcon.Success, ActiveWindow.GetHideExecuteScriptReference(scripts));


            return UIHelper.Result();
        }

    }
}