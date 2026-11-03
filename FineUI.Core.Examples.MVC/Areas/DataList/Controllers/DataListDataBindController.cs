using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace FineUI.Core.Examples.MVC.Areas.DataList.Controllers
{
    [Area("DataList")]
    public class DataListDataBindController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            ViewBag.DataListItems = CreateCityItems(false);
            return View();
        }

        private static DataListItem[] CreateCityItems(bool reverse)
        {
            var cities = new[]
            {
                new { Id = "beijing", Name = "北京" },
                new { Id = "shanghai", Name = "上海" },
                new { Id = "guangzhou", Name = "广州" }
            };

            if (reverse)
            {
                Array.Reverse(cities);
            }

            var dataList = new global::FineUI.Core.DataList
            {
                DataTextField = "Name",
                DataValueField = "Id",
                DataSource = cities
            };
            dataList.DataBind();
            return dataList.Items.ToArray();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnReload_Click()
        {
            UIHelper.DataList("DataList1").LoadData(CreateCityItems(true));
            UIHelper.HiddenField("hfAppendCount").Text("0");
            UIHelper.Label("labResult").Text("已重新加载 3 项，顺序为广州、上海、北京。");
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAppend_Click(int appendCount)
        {
            if (appendCount < 0 || appendCount >= 1000)
            {
                UIHelper.Label("labResult").Text("追加批次无效，请重新加载数据后再试。");
                return UIHelper.Result();
            }

            // 每批使用不同的业务值，例如 shenzhen-1、shenzhen-2，连续追加不会产生重复标识。
            int nextBatch = appendCount + 1;
            UIHelper.DataList("DataList1").AppendData(
                new DataListItem("深圳（第" + nextBatch + "批）", "shenzhen-" + nextBatch),
                new DataListItem("杭州（第" + nextBatch + "批）", "hangzhou-" + nextBatch));
            UIHelper.HiddenField("hfAppendCount").Text(nextBatch.ToString());
            UIHelper.Label("labResult").Text("数据数量：" + (3 + nextBatch * 2));
            return UIHelper.Result();
        }
    }
}
