using Microsoft.AspNetCore.Mvc;


namespace FineUI.Core.Examples.MVC.Areas.Block.Controllers
{
    [Area("Block")]
    public class GridResponsiveController : FineUI.Core.Examples.MVC.Controllers.BaseController
    {
        // GET: Block/GridResponsive
        public IActionResult Index()
        {
            return View();
        }


    }
}
