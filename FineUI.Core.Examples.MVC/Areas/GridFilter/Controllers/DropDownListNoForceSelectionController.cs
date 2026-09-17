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
    public class DropDownListNoForceSelectionController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridFilter/DropDownListNoForceSelection
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grid1_FilterChanged(string[] Grid1_fields, JArray Grid1_filteredData)
        {
            FilteredTable filteredTable = new FilteredTable();
            filteredTable.NewFilterDataRowItem = NewFilterDataRowItemImplement;

            DataTable table = filteredTable.GetFilteredTable(Grid1_filteredData);

            UIHelper.Grid("Grid1").DataSource(table, Grid1_fields);

            UIHelper.Label("labResult").Text(String.Format("过滤数据：<pre>{0}</pre>", EncodeJson(Grid1_filteredData)));

            return UIHelper.Result();
        }


        #region FilterDataRowItem

        private bool NewFilterDataRowItemImplement(object sourceObj, string itemOperator, JToken itemValue, string itemText, string column)
        {
            bool valid = false;

            if (column == "Major")
            {
                string sourceValue = sourceObj.ToString();

                // 下拉列表的值是数组，并且数组不为空
                if (itemValue is JArray && (itemValue as JArray).Count > 0)
                {
                    JArray fillteredValue = (JArray)itemValue;

                    foreach (string filltereditem in fillteredValue)
                    {
                        if (filltereditem == sourceValue)
                        {
                            valid = true;
                            break;
                        }
                    }
                }
                else
                {
                    // 下拉列表，用户输入值
                    //string fillteredValue = fillteredObj.Value<string>();
                    if (sourceValue.Contains(itemText))
                    {
                        valid = true;
                    }
                }

            }

            return valid;
        }

        #endregion

    }
}