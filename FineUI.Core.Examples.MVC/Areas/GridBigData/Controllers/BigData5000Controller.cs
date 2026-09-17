using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.GridBigData.Controllers
{
    [Area("GridBigData")]
    public class BigData5000Controller : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: GridBigData/BigData5000
        public IActionResult Index()
        {
            ViewBag.Grid1DataSource = BigDataUtil.GetBigData(5000);
            return View();
        }


    }
}
