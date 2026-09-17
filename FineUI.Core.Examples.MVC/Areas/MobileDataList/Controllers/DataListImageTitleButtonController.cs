using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileDataList.Controllers
{
    [Area("MobileDataList")]
    public class DataListImageTitleButtonController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileDataList/DataListImageTitleButton
        public IActionResult Index()
        {
            LoadData();

            return View();
        }

        protected static readonly string DATALIST_ITEM_TEMPLATE_ACTIONS = "<table class=\"item-table\"><tr><td><img class=\"item-img\" src=\"{0}\"><div class=\"item-text\">{1}</div><div class=\"item-desc\">{2}</div></td><td class=\"actions\"></td></tr></table>";

        private void LoadData()
        {
            DataTable source = DataSourceUtil.GetCountryTable();

            List<DataListItem> items = new List<DataListItem>();
            foreach (DataRow row in source.Rows)
            {
                DataListItem listItem = new DataListItem();
                listItem.TextRawHtml = new RawHtml(DATALIST_ITEM_TEMPLATE_ACTIONS,
                    Url.Content("~/res/icon/flag_" + row["Image"] + ".png"),
                    HttpUtility.HtmlEncode(row["Name"]),
                    HttpUtility.HtmlEncode(row["Desc"]));

                items.Add(listItem);
            }

            ViewBag.DataList1Items = items.ToArray();
        }

    }
}