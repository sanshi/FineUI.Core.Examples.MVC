using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;
using ChartRow = FineUI.Core.Examples.MVC.Areas.Chart.ChartDataRows.ChartRow;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class AreaController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Basic()
        {
            return View(new[]
            {
                new { Category = "Mon", Value = 820 },
                new { Category = "Tue", Value = 932 },
                new { Category = "Wed", Value = 901 },
                new { Category = "Thu", Value = 934 },
                new { Category = "Fri", Value = 1290 },
                new { Category = "Sat", Value = 1330 },
                new { Category = "Sun", Value = 1320 }
            });
        }

        public IActionResult Stacked()
        {
            return View(new[]
            {
                new
                {
                    Category = "Mon",
                    Email = 120, UnionAds = 220, VideoAds = 150, Direct = 320, SearchEngine = 820
                },
                new
                {
                    Category = "Tue",
                    Email = 132, UnionAds = 182, VideoAds = 232, Direct = 332, SearchEngine = 932
                },
                new
                {
                    Category = "Wed",
                    Email = 101, UnionAds = 191, VideoAds = 201, Direct = 301, SearchEngine = 901
                },
                new
                {
                    Category = "Thu",
                    Email = 134, UnionAds = 234, VideoAds = 154, Direct = 334, SearchEngine = 934
                },
                new
                {
                    Category = "Fri",
                    Email = 90, UnionAds = 290, VideoAds = 190, Direct = 390, SearchEngine = 1290
                },
                new
                {
                    Category = "Sat",
                    Email = 230, UnionAds = 330, VideoAds = 330, Direct = 330, SearchEngine = 1330
                },
                new
                {
                    Category = "Sun",
                    Email = 210, UnionAds = 310, VideoAds = 410, Direct = 320, SearchEngine = 1320
                }
            });
        }

        public IActionResult GradientStacked()
        {
            return View(new[]
            {
                new { Category = "Mon", Line1 = 140, Line2 = 120, Line3 = 320, Line4 = 220, Line5 = 220 },
                new { Category = "Tue", Line1 = 232, Line2 = 282, Line3 = 132, Line4 = 402, Line5 = 302 },
                new { Category = "Wed", Line1 = 101, Line2 = 111, Line3 = 201, Line4 = 231, Line5 = 181 },
                new { Category = "Thu", Line1 = 264, Line2 = 234, Line3 = 334, Line4 = 134, Line5 = 234 },
                new { Category = "Fri", Line1 = 90, Line2 = 220, Line3 = 190, Line4 = 190, Line5 = 210 },
                new { Category = "Sat", Line1 = 340, Line2 = 340, Line3 = 130, Line4 = 230, Line5 = 290 },
                new { Category = "Sun", Line1 = 250, Line2 = 310, Line3 = 220, Line4 = 120, Line5 = 150 }
            });
        }

        public IActionResult FillColor()
        {
            return View(new[]
            {
                new { Category = "A", First = 10, Second = 25 },
                new { Category = "B", First = 22, Second = 14 },
                new { Category = "C", First = 28, Second = 23 },
                new { Category = "D", First = 23, Second = 35 },
                new { Category = "E", First = 19, Second = 10 }
            });
        }

        public IActionResult StackAll()
        {
            return View(new[]
            {
                new { Category = "1", Baseline = 3, Change = 1 },
                new { Category = "2", Baseline = 1, Change = 1 },
                new { Category = "3", Baseline = 2, Change = 1 },
                new { Category = "4", Baseline = -1, Change = 1 },
                new { Category = "5", Baseline = -3, Change = 1 },
                new { Category = "6", Baseline = 1, Change = 1 },
                new { Category = "7", Baseline = 3, Change = 1 },
                new { Category = "8", Baseline = -3, Change = -1 },
                new { Category = "9", Baseline = -1, Change = -1 },
                new { Category = "10", Baseline = -2, Change = -1 },
                new { Category = "11", Baseline = 1, Change = -1 },
                new { Category = "12", Baseline = 3, Change = -1 },
                new { Category = "13", Baseline = -1, Change = -1 },
                new { Category = "14", Baseline = -3, Change = -1 }
            });
        }

        public IActionResult RegionFilter()
        {
            var totals = RegionSalesData.RegionTrend("east");
            ViewData["Rows"] = totals;
            ViewData["Scope"] = AreaSummary(totals);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult cblRegions_SelectedIndexChanged(string[] selected)
        {
            var totals = RegionSalesData.RegionTrend(selected);
            UIHelper.Chart("ChartAreaSales").LoadData(JArray.FromObject(totals));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(AreaSummary(totals));
            return UIHelper.Result();
        }

        public IActionResult Cumulative()
        {
            var rows = AreaAmounts(false);
            ViewData["Rows"] = rows;
            ViewData["Scope"] = AreaModeSummary(false);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult cbxCumulative_CheckedChanged(bool cumulative)
        {
            var rows = AreaAmounts(cumulative);
            UIHelper.Chart("ChartCumulativeSales").LoadData(JArray.FromObject(rows));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(AreaModeSummary(cumulative));
            return UIHelper.Result();
        }

        private static string AreaSummary(ChartRow[] rows)
        {
            return rows.Length == 0 ? "请选择至少一个区域" : $"所选区域销售额合计 {rows.Sum(row => row.Amount)} 元";
        }

        private static ChartRow[] AreaAmounts(bool cumulative)
        {
            var rows = RegionSalesData.RegionTrend();
            if (!cumulative)
            {
                return rows;
            }

            // 截至当月包含之前各月。比如 5 月的累计值是 4 月和 5 月的销售额之和。
            int total = 0;
            return rows.Select(row =>
            {
                total += row.Amount;
                return new ChartRow(row.Id, row.Category, total);
            }).ToArray();
        }

        private static string AreaModeSummary(bool cumulative)
        {
            return cumulative ? "统计口径：截至当月累计" : "统计口径：本月金额";
        }
    }
}
