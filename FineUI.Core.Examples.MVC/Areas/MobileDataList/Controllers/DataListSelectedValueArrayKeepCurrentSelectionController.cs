using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.MobileDataList.Controllers
{
    [Area("MobileDataList")]
    public class DataListSelectedValueArrayKeepCurrentSelectionController : FineUI.Core.Examples.MVC.Controllers.BaseMobileController
    {
        // GET: MobileDataList/DataListSelectedValueArrayKeepCurrentSelection
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
                listItem.TextRawHtml = new RawHtml(DATALIST_SIMPLE_ITEM_TEMPLATE,
                    Url.Content("~/res/icon/flag_" + row["Image"] + ".png"),
                    row["Name"]);
                listItem.Value = row["Id"].ToString();

                items.Add(listItem);
            }

            ViewBag.DataList1Items = items.ToArray();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnSubmit_Click(string[] selected)
        {
            Alert.Show("选中项：" + String.Join(", ", selected));

            return UIHelper.Result();
        }

    }
}