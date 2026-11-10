using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class PieController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult Index()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }

        public IActionResult Doughnut()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }

        public IActionResult HalfDoughnut()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }

        public IActionResult PadAngle()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }

        public IActionResult RoundedDoughnut()
        {
            return View(new[]
            {
                new { Category = "Search Engine", Value = 1048 },
                new { Category = "Direct", Value = 735 },
                new { Category = "Email", Value = 580 },
                new { Category = "Union Ads", Value = 484 },
                new { Category = "Video Ads", Value = 300 }
            });
        }

        public IActionResult Rose()
        {
            return View(new[]
            {
                new { Category = "A", Value = 100 },
                new { Category = "B", Value = 200 },
                new { Category = "C", Value = 300 },
                new { Category = "D", Value = 400 },
                new { Category = "E", Value = 500 }
            });
        }

        public IActionResult TrendLink()
        {
            ViewData["Rows"] = ChartInteractionData.ChannelTotals();
            ViewData["Trend"] = ChartInteractionData.ChannelTrend();
            ViewData["Scope"] = "全部渠道 · 月度访问趋势";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SelectChannel(string seriesKey, string dataKey)
        {
            var channel = ChartInteractionData.ChannelName(dataKey);
            if (seriesKey == "amount" && channel != null)
            {
                UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChartInteractionData.ChannelTrend(dataKey)));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(channel + " · 月度访问趋势");
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ResetChannels()
        {
            UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChartInteractionData.ChannelTrend()));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text("全部渠道 · 月度访问趋势");
            return UIHelper.Result();
        }

        public IActionResult MonthFilter()
        {
            var rows = ChartInteractionData.ChannelDistribution("all");
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChartInteractionData.DistributionSummary("all", rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterMonth(string month)
        {
            var rows = ChartInteractionData.ChannelDistribution(month);
            if (rows.Length > 0)
            {
                UIHelper.Chart("ChartChannelMonth").LoadData(JArray.FromObject(rows));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.DistributionSummary(month, rows));
            }
            return UIHelper.Result();
        }

        public IActionResult ChannelDetails()
        {
            var rows = ChartInteractionData.ChannelTotals();
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChartInteractionData.ChannelDetailsSummary(null, null);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReadChannel(string seriesKey, string dataKey)
        {
            if (seriesKey == "amount" && ChartInteractionData.ChannelName(dataKey) != null)
            {
                var rows = ChartInteractionData.ChannelTrend(dataKey);
                UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.ChannelDetailsSummary(dataKey, rows));
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ClearChannel()
        {
            var rows = new ChartInteractionData.ChartRow[0];
            UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChartInteractionData.ChannelDetailsSummary(null, rows));
            return UIHelper.Result();
        }
    }
}
