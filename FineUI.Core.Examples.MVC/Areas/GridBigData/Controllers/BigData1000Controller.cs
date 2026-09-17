using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigData1000Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigData1000
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = BigDataUtil.GetBigData(1000);
            return View();
        }


    }
}
