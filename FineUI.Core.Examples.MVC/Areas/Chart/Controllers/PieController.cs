using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;
using System;
using ChartRow = FineUI.Core.Examples.MVC.Areas.Chart.ChartDataRows.ChartRow;

namespace FineUI.Core.Examples.MVC.Areas.Chart.Controllers
{
    [Area("Chart")]
    public class PieController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        public IActionResult ScrollableLegend()
        {
            return View(GetNameCounts());
        }

        private static object GetNameCounts()
        {
            const string surnames = "赵钱孙李周吴郑王冯陈褚卫蒋沈韩杨朱秦尤许何吕施张孔曹严华金魏陶姜戚谢邹喻柏水窦章云苏潘葛奚范彭郎鲁韦昌马苗凤花方俞任袁柳酆鲍史唐费廉岑薛雷贺倪汤滕殷罗毕郝邬安常乐于时傅皮卞齐康伍余元卜顾孟平黄和穆萧尹姚邵湛汪祁毛禹狄米贝明臧计伏成戴谈宋茅庞熊纪舒屈项祝董梁杜阮蓝闵席季麻强贾路娄危";
            var random = new Random();
            return Enumerable.Range(0, 50).Select(_ =>
            {
                // 沿用官网两种姓名格式，例如「赵王吴」或「赵钱孙李·周吴」。
                var name = random.NextDouble() > 0.65
                    ? MakeNamePart(random, surnames, 4, 1) + "·" + MakeNamePart(random, surnames, 3, 0)
                    : MakeNamePart(random, surnames, 2, 1);
                return new { Category = name, Value = (int)Math.Floor(random.NextDouble() * 100000 + 0.5) };
            }).ToArray();
        }

        private static string MakeNamePart(Random random, string surnames, int lengthRange, int minimumLength)
        {
            var letters = new char[(int)Math.Ceiling(random.NextDouble() * lengthRange + minimumLength)];
            for (int index = 0; index < letters.Length; index++)
            {
                letters[index] = surnames[random.Next(surnames.Length)];
            }
            return new string(letters);
        }

        public IActionResult LabelAlign()
        {
            return View(new[]
            {
                new { Category = "Apples", Value = 70 },
                new { Category = "Strawberries", Value = 68 },
                new { Category = "Bananas", Value = 48 },
                new { Category = "Oranges", Value = 40 },
                new { Category = "Pears", Value = 32 },
                new { Category = "Pineapples", Value = 27 },
                new { Category = "Grapes", Value = 18 }
            });
        }

        public IActionResult Basic()
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
            ViewData["Rows"] = ChannelVisitData.ChannelTotals();
            ViewData["Trend"] = ChannelVisitData.ChannelTrend();
            ViewData["Scope"] = "全部渠道 · 月度访问趋势";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartChannels_PointClick(string seriesKey, string pointId)
        {
            var channel = ChannelVisitData.ChannelName(pointId);
            if (seriesKey == "amount" && channel != null)
            {
                UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChannelVisitData.ChannelTrend(pointId)));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(channel + " · 月度访问趋势");
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnAllChannels_Click()
        {
            UIHelper.Chart("ChartChannelTrend").LoadData(JArray.FromObject(ChannelVisitData.ChannelTrend()));
            UIHelper.ToolbarText("ToolbarTextChartScope").Text("全部渠道 · 月度访问趋势");
            return UIHelper.Result();
        }

        public IActionResult MonthFilter()
        {
            var rows = ChannelVisitData.ChannelTotals();
            ViewData["Rows"] = rows;
            ViewData["Scope"] = DistributionSummary("all", rows);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ddlMonth_SelectedIndexChanged(string month)
        {
            var rows = month == "all" ? ChannelVisitData.ChannelTotals() : ChannelVisitData.ChannelTotals(month);
            if (rows.Length > 0)
            {
                UIHelper.Chart("ChartChannelMonth").LoadData(JArray.FromObject(rows));
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(DistributionSummary(month, rows));
            }
            return UIHelper.Result();
        }

        public IActionResult ChannelDetails()
        {
            var rows = ChannelVisitData.ChannelTotals();
            ViewData["Rows"] = rows;
            ViewData["Scope"] = ChannelDetailsSummary(null, null);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChartChannelDetails_PointClick(string seriesKey, string pointId)
        {
            if (seriesKey == "amount" && ChannelVisitData.ChannelName(pointId) != null)
            {
                var rows = ChannelVisitData.ChannelTrend(pointId);
                UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
                UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChannelDetailsSummary(pointId, rows));
            }
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult btnClear_Click()
        {
            var rows = new ChartRow[0];
            UIHelper.Grid("GridChannelMonths").DataSource(rows, new[] { "Category", "Amount" });
            UIHelper.ToolbarText("ToolbarTextChartScope").Text(ChannelDetailsSummary(null, rows));
            return UIHelper.Result();
        }

        private static string DistributionSummary(string month, ChartRow[] rows)
        {
            var range = month == "all" ? "全部月份" : Array.Find(ChannelVisitData.ChannelTrend(), row => row.Id == month)?.Category;
            return $"{range} · 总访问量 {rows.Sum(row => row.Amount)}";
        }

        private static string ChannelDetailsSummary(string key, ChartRow[] rows)
        {
            return key == null ? "请选择一个渠道" : $"{ChannelVisitData.ChannelName(key)} · 六个月访问量 {rows.Sum(row => row.Amount)}";
        }
    }
}
