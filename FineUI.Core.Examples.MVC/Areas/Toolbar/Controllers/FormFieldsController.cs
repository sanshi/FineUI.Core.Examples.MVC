using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.Toolbar.Controllers
{
    [Area("Toolbar")]
    public class FormFieldsController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Toolbar/FormFields
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClearDate_Click(string[] Grid1_fields)
        {
            UIHelper.DatePicker("dpStartDate").Reset();
            UIHelper.DatePicker("dpEndDate").Reset();

            // 清空记录时保留字段定义，确保下一次查询仍能按姓名、性别等字段显示数据。
            UIHelper.Grid("Grid1").DataSource(dataSource: null, fields: Grid1_fields);

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSearch_Click(string[] Grid1_fields)
        {
            UIHelper.Grid("Grid1").DataSource(DataSourceUtil.GetDataTable(), Grid1_fields);

            return UIHelper.Result();
        }
        
       
    }
}
