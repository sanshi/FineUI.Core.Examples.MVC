using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace FineUI.Core.Examples.MVC.Areas.GridFilter.Controllers
{
    [Area("GridFilter")]
    public class InlineFilterComplexController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridFilter/InlineFilterComplex
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        private void LoadData()
        {
            List<ListItem> items = new List<ListItem>();
            for (int i = 1; i <= 5; i++)
            {
                ListItem item = new ListItem();
                item.Value = i.ToString();
                item.Text = String.Format("分组{0}", i);
                item.Display = String.Format("<img src=\"{0}\">&nbsp;{1}", Url.Content("~/res/images/16/" + i.ToString() + ".png"), item.Text);

                items.Add(item);
            }

            ViewBag.groupListItems = items.ToArray();
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
                if (fillteredOperator == "equal")
                {
                    if (sourceValue == fillteredValue)
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "contain")
                {
                    if (sourceValue.Contains(fillteredValue))
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "start")
                {
                    if (sourceValue.StartsWith(fillteredValue))
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "end")
                {
                    if (sourceValue.EndsWith(fillteredValue))
                    {
                        valid = true;
                    }
                }
            }
            else if (column == "EntranceYear")
            {
                int sourceValue = Convert.ToInt32(sourceObj);
                int fillteredValue = fillteredObj.Value<int>();

                if (fillteredOperator == "greater")
                {
                    if (sourceValue > fillteredValue)
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "less")
                {
                    if (sourceValue < fillteredValue)
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "equal")
                {
                    if (sourceValue == fillteredValue)
                    {
                        valid = true;
                    }
                }

            }
            else if (column == "LogTime")
            {
                // 时间比较时要去掉数据源中的时分秒！
                DateTime sourceDate = Convert.ToDateTime(sourceObj);
                DateTime sourceValue = new DateTime(sourceDate.Year, sourceDate.Month, sourceDate.Day);

                DateTime fillteredValue = fillteredObj.Value<DateTime>();

                if (fillteredOperator == "greater")
                {
                    if (sourceValue > fillteredValue)
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "less")
                {
                    if (sourceValue < fillteredValue)
                    {
                        valid = true;
                    }
                }
                else if (fillteredOperator == "equal")
                {
                    if (sourceValue == fillteredValue)
                    {
                        valid = true;
                    }
                }

            }
            else if (column == "Major" || column == "Group")
            {
                string sourceValue = sourceObj.ToString();
                JArray fillteredValue = (JArray)fillteredObj;

                foreach (string filltereditem in fillteredValue)
                {
                    if (filltereditem == sourceValue)
                    {
                        valid = true;
                        break;
                    }
                }
            }
            else if (column == "AtSchool")
            {
                bool sourceValue = Convert.ToBoolean(sourceObj);
                bool fillteredValue = fillteredObj.Value<bool>();

                if (sourceValue == fillteredValue)
                {
                    valid = true;
                }
            }
            else if (column == "Gender")
            {
                int sourceValue = Convert.ToInt32(sourceObj);
                int fillteredValue = fillteredObj.Value<int>();

                if (sourceValue == fillteredValue)
                {
                    valid = true;
                }
            }


            return valid;
        }

        #endregion


    }
}
