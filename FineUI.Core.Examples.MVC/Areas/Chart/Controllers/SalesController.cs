using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class SalesController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartSales_PointClick(string seriesKey, string dataKey)
        {
            if (seriesKey == "sales" && ChartSamples.HasMonth(dataKey))
            {
                BindOrders(dataKey);
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnRecent_Click()
        {
            UIHelper.Chart("ChartSales").LoadData(JArray.FromObject(ChartSamples.Months(true)));
            BindOrders(recent: true);
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnReset_Click()
        {
            UIHelper.Chart("ChartSales").LoadData(JArray.FromObject(ChartSamples.Months()));
            BindOrders();
            return UIHelper.Result();
        }

        private static void BindOrders(string month = null, bool recent = false)
        {
            var orders = ChartSamples.Details(month, recent);
            UIHelper.Grid("GridOrders").DataSource(orders, new[] { "Number", "Customer", "Month", "Amount" });
            UIHelper.ToolbarText("ToolbarTextOrderScope").Text(ChartSamples.OrderScope(month, recent, orders.Length));
        }
    }
}
