using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileDataList.Controllers
{
    [Area("MobileDataList")]
    public class DataListLinkToPanelController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileDataList/DataListLinkToPanel
        public IActionResult Index()
        {
            LoadData();

            return View();
        }


        private void LoadData()
        {
            DataTable source = DataSourceUtil.GetCountryTable();

            List<DataListItem> items = new List<DataListItem>();
            foreach (DataRow row in source.Rows)
            {
                DataListItem listItem = new DataListItem();
                listItem.TextRawHtml = new RawHtml(DATALIST_ITEM_TEMPLATE,
                    Url.Content("~/res/icon/flag_" + row["Image"] + ".png"),
                    HttpUtility.HtmlEncode(row["Name"]),
                    HttpUtility.HtmlEncode(row["Desc"]));

                listItem.NavigateUrl = "javascript:;";
                listItem.ShowArrow = true;


                items.Add(listItem);
            }

            ViewBag.DataList1Items = items.ToArray();
        }

    }
}