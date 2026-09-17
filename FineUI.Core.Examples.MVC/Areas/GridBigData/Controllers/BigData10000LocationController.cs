using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigData10000LocationController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigData10000Location
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = BigDataUtil.GetBigData(10000);
            return View();
        }


    }
}
