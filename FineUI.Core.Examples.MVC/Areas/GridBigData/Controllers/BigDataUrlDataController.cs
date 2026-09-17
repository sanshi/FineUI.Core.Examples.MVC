using Microsoft.AspNetCore.Mvc;
using System;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigDataUrlDataController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigDataUrlData
        public IActionResult Index(int total, string resultType)
        {
            string result = String.Empty;

            // 最大数限制
            if (total > 10000)
            {
                total = 10000;
            }

            if (resultType == "simple")
            {
                // 数据格式一
                result = BigDataUtil.GetSimpleBigDataString(total);
            }
            else
            {
                // 数据格式二
                result = BigDataUtil.GetBigDataString(total);
            }

            return Content(result);
        }

    }
}
