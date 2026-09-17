using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigDataUrlPagingDatabaseDataController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigDataUrlPagingDatabaseData
        public IActionResult Index(int total, int pageIndex, int pageSize)
        {
            // 最大数限制
            if (total > 10000)
            {
                total = 10000;
            }

            string result = GetPagedLargeData(total, pageIndex, pageSize);

            return Content(result);
        }

        private string GetPagedLargeData(int total, int pageIndex, int pageSize)
        {
            JObject jo = new JObject();

            // 总记录数
            jo.Add("recordCount", total);

            // 分页数据
            jo.Add("data", BigDataUtil.GetBigData(total, pageIndex, pageSize));

            return jo.ToString(Newtonsoft.Json.Formatting.None);
        }

    }
}
