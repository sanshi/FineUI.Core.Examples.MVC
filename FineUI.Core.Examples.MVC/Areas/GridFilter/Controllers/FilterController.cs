using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.GridFilter.Controllers
{
    [Area("GridFilter")]
    public class FilterController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridFilter/Filter
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_FilterChanged(string[] Grid1_fields, JArray Grid1_filteredData)
        {
            FilteredTable filteredTable = new FilteredTable();
            filteredTable.FilterDataRowItem = FilterDataRowItemImplement;

            DataTable table = filteredTable.GetFilteredTable(Grid1_filteredData);

            UIHelper.Grid("Grid1").DataSource(table, Grid1_fields);

            UIHelper.Label("labResult").Text(String.Format("过滤数据：<pre>{0}</pre>", EncodeJson(Grid1_filteredData)));

            return UIHelper.Result();
        }


        #region FilterDataRowItem

        private bool FilterDataRowItemImplement(object sourceObj, string fillteredOperator, JToken fillteredObj, string column)
        {
            bool valid = false;

            if (column == "Name")
            {
                string sourceValue = sourceObj.ToString();
                string fillteredValue = fillteredObj.Value<string>();

                if (sourceValue.Contains(fillteredValue))
                {
                    valid = true;
                }
            }

            return valid;
        }

        #endregion

    }
}