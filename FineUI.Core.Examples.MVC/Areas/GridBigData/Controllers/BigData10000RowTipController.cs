using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigData10000RowTipController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigData10000RowTip
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = BigDataUtil.GetBigData(10000);
            return View();
        }


    }
}
